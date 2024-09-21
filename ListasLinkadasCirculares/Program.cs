using System;
using System.Collections;
using System.Collections.Generic;

public class CircularLinkedList<T> : LinkedList<T>
{
    public new IEnumerator<T> GetEnumerator()
    {
        return new CircularLinkedListEnumerator<T>(this);
    }
}

public class CircularLinkedListEnumerator<T> : IEnumerator<T>
{
    private LinkedListNode<T>? _current;
    private LinkedList<T> _list;

    public T Current
    {
        get
        {
            if (_current == null)
                throw new InvalidOperationException("Current is null.");
            
            return _current.Value;
        }
    }

    object IEnumerator.Current => Current;

    public CircularLinkedListEnumerator(LinkedList<T> list)
    {
        _list = list;
        _current = _list.First;
    }

    public bool MoveNext()
    {
        if (_current == null) return false;
        
        _current = _current.Next ?? _list.First;
        return true;
    }

    public void Reset()
    {
        _current = _list.First;
    }

    public void Dispose() { }
}

public static class CircularLinkedListExtensions
{
    public static LinkedListNode<T>? Next<T>(this LinkedListNode<T> node)
    {
        return node?.Next ?? node?.List?.First;
    }

    public static LinkedListNode<T>? Previous<T>(this LinkedListNode<T> node)
    {
        return node?.Previous ?? node?.List?.Last;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        CircularLinkedList<string> categories = new CircularLinkedList<string>();

        // Adicionando itens
        categories.AddLast("Esportes");
        categories.AddLast("Cultura");
        categories.AddLast("História");
        categories.AddLast("Geografia");
        categories.AddLast("Pessoas");
        categories.AddLast("Tecnologia");
        categories.AddLast("Natureza");
        categories.AddLast("Ciência");

        Random random = new Random();
        int totalTime = 0;
        int remainingTime = 0;
        
        IEnumerator<string> enumerator = categories.GetEnumerator();
        while (true)
        {
            if (remainingTime <= 0)
            {
                Console.WriteLine("Pressione [Enter] para girar a roleta ou qualquer outra tecla para sair.");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.Enter:
                        totalTime = random.Next(1000, 5000);
                        remainingTime = totalTime;
                        break;
                    default:
                        return;
                }
            }

            int categoryTime = (-450 * remainingTime) / (totalTime - 50) + 500 + (22500 / (totalTime - 50));
            remainingTime -= categoryTime;
            System.Threading.Thread.Sleep(categoryTime);
            Console.ForegroundColor = remainingTime <= 0 ? ConsoleColor.Red : ConsoleColor.Gray;

            enumerator.MoveNext();
            Console.WriteLine(enumerator.Current);

            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}