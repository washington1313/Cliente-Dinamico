using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente_dinamico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de Funcionarios a serem cadastrados:");

            int contador = int.Parse(Console.ReadLine());
            string[] nomeCliente = new string[contador];

            Console.Clear();

            for (int i = 0; i < nomeCliente.Length; i++)
            {
                Console.WriteLine("Informe o nome para cadastro:");
                nomeCliente[i] = Console.ReadLine();
                Console.Clear();
            }

            for (int i = 0; i < nomeCliente.Length; i++)
            {
                Console.WriteLine(nomeCliente[i]);
            }
            Console.ReadKey();
        }
    }
}
