using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Criando a tabela hash (dicionário) para armazenar o código de barras e a prateleira correspondente
        Dictionary<string, string> tabelaHash = new Dictionary<string, string>();

        // Carregando no mínimo 20 produtos com códigos de barras e suas localizações (5 produtos por prateleira)
        tabelaHash.Add("123456789012", "A1");
        tabelaHash.Add("234567890123", "A1");
        tabelaHash.Add("345678901234", "A1");
        tabelaHash.Add("456789012345", "A1");
        tabelaHash.Add("567890123456", "A1");

        tabelaHash.Add("678901234567", "B2");
        tabelaHash.Add("789012345678", "B2");
        tabelaHash.Add("890123456789", "B2");
        tabelaHash.Add("901234567890", "B2");
        tabelaHash.Add("012345678901", "B2");

        tabelaHash.Add("112233445566", "C3");
        tabelaHash.Add("223344556677", "C3");
        tabelaHash.Add("334455667788", "C3");
        tabelaHash.Add("445566778899", "C3");
        tabelaHash.Add("556677889900", "C3");

        tabelaHash.Add("667788990011", "A4");
        tabelaHash.Add("778899001122", "A4");
        tabelaHash.Add("889900112233", "A4");
        tabelaHash.Add("990011223344", "A4");
        tabelaHash.Add("001122334455", "A4");

        // Loop para solicitar o código do produto e retornar a localização da prateleira
        while (true)
        {
            Console.WriteLine("Digite o código de barras do produto ou 'sair' para encerrar:");
            string? codigo = Console.ReadLine(); // Código pode ser nulo

            // Verificando se o usuário deseja sair
            if (string.IsNullOrEmpty(codigo) || codigo.ToLower() == "sair")
                break;

            // Verificando se o código de barras está na tabela
            if (codigo != null && tabelaHash.ContainsKey(codigo))
            {
                string prateleira = tabelaHash[codigo];
                Console.WriteLine($"O produto de código {codigo} está na prateleira {prateleira}.");
            }
            else
            {
                Console.WriteLine("Código de barras não encontrado. Verifique o código e tente novamente.");
            }
        }
    }
}