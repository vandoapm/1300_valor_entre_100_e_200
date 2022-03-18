using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1300_valor_entre_100_e_200
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Determinar se valor pertence ao intervalo:  100 <= x <= 200 ");
            Console.WriteLine();

            Console.Write("Informe o valor: ");
            float a = float.Parse(Console.ReadLine());

            Console.WriteLine();

            if (a >= 100 && a <= 200)
            {

                Console.WriteLine("Valor dentro do intervalo");

            }
            else
            {

                Console.WriteLine("Valor fora do intervalo");

            }

            Console.ReadLine();

        }
    }
}
