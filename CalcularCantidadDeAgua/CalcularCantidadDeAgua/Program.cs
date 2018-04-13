using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularCantidadDeAgua
{
    class Program
    {
        static void Main(string[] args)
        {
            int flag = 0, i = 0, mayordia = 0, menordia = 0, x = 7;
            int[] dia = new int[7];
            float menor = 0, mayor = 0, promedio = 0, contagua = 0;
            float[] agua = new float[x + 1];


            do
            {
                Console.Write("Ingrese dia:");
                dia[i] = int.Parse(Console.ReadLine());

                Console.Write("Ingrese agua caida:");
                agua[i] = float.Parse(Console.ReadLine());

                if (flag == 0)
                {
                    mayordia = dia[i];
                    menordia = dia[i];
                    mayor = agua[i];
                    menor = agua[i];
                    flag = 1;
                }
                else
                {
                    if (agua[i] > mayor)
                    {
                        mayordia = dia[i];
                        mayor = agua[i];
                    }
                    if (agua[i] < menor)
                    {
                        menordia = dia[i];
                        menor = agua[i];
                    }
                }

                contagua += agua[i];

                if (i == 29)
                {
                    Console.Write("la semana tiene 7 dias s/n ?");
                    if (Console.ReadLine() == "s")
                        x = x + 1;
                }
                i++;
            } while (i < x);

            promedio = contagua / i;

            if (menor == mayor)
            {
                Console.Write("\nNo hubo mayor y menor dia de agua caida, fue igual para todos los dias {0}", menor);
            }
            else
            {
                Console.WriteLine("\nLa mayor cantidad de agua caida por dia fue de {0} milímetros", mayor);
                for (i = 0; i < x; i++)
                    if (agua[i] == mayor)
                        Console.Write("\nDia {0}", dia[i]);

                Console.WriteLine("\n\nLa menor cantidad de agua caida por dia fue de {0} milímetros", menor);
                for (i = 0; i < x; i++)
                    if (agua[i] == menor)
                        Console.Write("\nDia {0}", dia[i]);
            }
            Console.WriteLine("\n\nEl promedio de agua caida en {0} dias es {1}", x, promedio);

            Console.WriteLine("\n\nLuis E. Guzman R.     - 11-EISN-1-347");
            Console.WriteLine("Marcelo Peguero Isa.  - 14-EISN-1-114");
            Console.WriteLine("Luis E. Corporan T.   - 14-SISM-1-042");
            Console.WriteLine("Jose M. Shanlatte M.  - 14-EISM-1-148");
            Console.WriteLine("Misael Geronimo       - 15-EIST-1-075");

            Console.Read();
        }
    }
}
