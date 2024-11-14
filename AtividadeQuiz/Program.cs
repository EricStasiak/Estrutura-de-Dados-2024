﻿using System;
using AtividadeQuiz;

class Program
{
    private static BinaryTree<QuizItem> GetTree()
    {
        BinaryTree<QuizItem> tree = new BinaryTree<QuizItem>();

        tree.Root = new BinaryTreeNode<QuizItem>(new QuizItem("Você tem experiência em desenvolvimento de aplicações?"));
        tree.Root.Left = new BinaryTreeNode<QuizItem>(new QuizItem("Você trabalhou como desenvolvedor por mais de 5 anos?"));
        tree.Root.Right = new BinaryTreeNode<QuizItem>(new QuizItem("Você completou a universidade?"));

        tree.Root.Left.Left = new BinaryTreeNode<QuizItem>(new QuizItem("Candidate-se a desenvolvedor sênior!"));
        tree.Root.Left.Right = new BinaryTreeNode<QuizItem>(new QuizItem("Candidate-se a desenvolvedor pleno!"));

        tree.Root.Right.Left = new BinaryTreeNode<QuizItem>(new QuizItem("Candidate-se a desenvolvedor júnior!"));
        tree.Root.Right.Right = new BinaryTreeNode<QuizItem>(new QuizItem("Você conseguirá tempo durante o semestre?"));

        tree.Root.Right.Right.Left = new BinaryTreeNode<QuizItem>(new QuizItem("Candidate-se ao programa de estágio de longa duração!"));
        tree.Root.Right.Right.Right = new BinaryTreeNode<QuizItem>(new QuizItem("Candidate-se ao programa de estágio de verão!"));


        return tree;
    }

    static void Main(string[] args)
    {
        BinaryTree<QuizItem> tree = GetTree();
        BinaryTreeNode<QuizItem> node = tree.Root;

        while (node != null)
        {
            if (node.Left != null || node.Right != null)
            {
                Console.Write(node.Data.Text + " (S/N): ");
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.S:
                        Console.WriteLine(" Sim");
                        node = node.Left;
                        break;
                    case ConsoleKey.N:
                        Console.WriteLine(" Não");
                        node = node.Right;
                        break;
                }
            }
            else
            {
                Console.WriteLine(node.Data.Text);
                node = null;
            }
        }
    }
}