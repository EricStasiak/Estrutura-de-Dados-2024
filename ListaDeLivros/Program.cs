using System;
using System.Collections.Generic;
using System.Linq;

class Livro
{
    public string Nome { get; set; }
    public string Editora { get; set; }
    public string Autor { get; set; }
    public int NumeroPaginas { get; set; }

    public Livro(string nome, string editora, string autor, int numeroPaginas)
    {
        Nome = nome;
        Editora = editora;
        Autor = autor;
        NumeroPaginas = numeroPaginas;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Editora: {Editora}");
        Console.WriteLine($"Autor: {Autor}");
        Console.WriteLine($"Número de Páginas: {NumeroPaginas}");
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        List<Livro> livros = new List<Livro>
        {
            new Livro("1984", "Companhia das Letras", "George Orwell", 416),
            new Livro("Revolução dos Bichos", "Companhia das Letras", "George Orwell", 152),
            new Livro("A Arte da Guerra", "Estação Liberdade", "Sun Tzu", 160),
            new Livro("O Príncipe", "Martins Fontes", "Nicolau Maquiavel", 136),
            new Livro("A Odisséia", "Penguin Classics", "Homero", 560)
        };

        // Encontrar o livro com o maior número de páginas
        Livro livroMaiorNumeroPaginas = livros.OrderByDescending(l => l.NumeroPaginas).First();

        Console.WriteLine("Livro com o maior número de páginas:");
        livroMaiorNumeroPaginas.ExibirInformacoes();
    }
}
