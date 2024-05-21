using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Funcoes1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            area();

            Console.WriteLine("Função executada com sucesso");

            Console.ReadKey();
        }

        static void area()
        {
            Console.WriteLine("Escolha uma das seguintes formas geométricas (Quadrado, Retângulo, Trapézio, Losango): ");
            string forma = Console.ReadLine();

            switch (forma)
            {
                case "Quadrado":
                    Console.WriteLine("Digite o valor do lado do quadrado: ");
                    double ladoq = double.Parse(Console.ReadLine());

                    double areaq = ladoq * ladoq;
                    Console.WriteLine("A área do quadrado é: " + areaq);
                    break;

                case "Retângulo":
                    Console.WriteLine("Digite o valor da base do retângulo: ");
                    double baser = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o valor da altura do retângulo: ");
                    double alturar = double.Parse(Console.ReadLine());

                    double arear = baser * alturar;
                    Console.WriteLine("A área do retângulo é: " + arear);
                    break;

                case "Trapézio":
                    Console.WriteLine("Digite o valor da base menor: ");
                    double basemenor = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o valor da base maior: ");
                    double basemaior = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o valor da altura: ");
                    double alturat = double.Parse(Console.ReadLine());

                    double areat = (basemaior + basemenor) * alturat / 2;
                    Console.WriteLine("A área do trapézio é: " + areat);
                    break;

                case "Losango":
                    Console.WriteLine("Digite o valor da diagonal menor: ");
                    double diagonalmenor = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o valor da diagonal maior: ");
                    double diagonalmaior = double.Parse(Console.ReadLine());

                    double areal = (diagonalmenor * diagonalmaior) / 2;
                    Console.WriteLine("A área do losango é: " + areal);
                    break;

            }
            Console.ReadKey();


        }

    }
}
