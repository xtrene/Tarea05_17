
/*
17) Crea un array de 10 posiciones de números con valores pedidos por teclado. Muestra
por consola el índice y el valor al que corresponde. Haz dos métodos, uno para rellenar
valores y otro para mostrar.
*/


using System;

namespace Tarea05_17
{
    class Program
    {
        static int[] lista = new int[10];

        static void introduceValor (int posicion, int valor)
        {
            lista[posicion] = valor;
        }

        static void muestraValor(int posicion) 
        {
            Console.WriteLine("{0} --> {1}",posicion,lista[posicion]);
        }
        static void Main(string[] args)
        {
  
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Introduce valor {0}/10: ",i+1);
                int temporal = Convert.ToInt32(Console.ReadLine());
                introduceValor(i, temporal);

            }


            Console.WriteLine("Índice/Valor: ");
            for (int i=0; i < 10; i++)
            {
                muestraValor(i);
            }






            Console.ReadKey();
        }
    }
}
