using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basico_Aula01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Saída de dados
            Console.WriteLine("Ola, Mundo!");
            
            /*------------------------------------------------*/

            // Criando variáveis

            int idade = 20; // Declarando e inicializando a variável
            string nome; // Apenas declarando a variável

            float altura = 1.55f; // float usa f no final
            double altura_2 = 1.55; 



            /*-------------------------------------------------*/

            // Entrada de dados
            Console.WriteLine("Digite o seu nome: ");
            nome = Console.ReadLine(); // Lê a entrada de dados

            Console.WriteLine("O seu nome é: {0}", nome); // Exibe o nome na tela
            Console.WriteLine("A sua idade é: {0}", idade);
            Console.WriteLine("A sua altura é: {0}", altura);
            Console.WriteLine("A altura usando o Double é: {0}", altura_2);


        }
    }
}
