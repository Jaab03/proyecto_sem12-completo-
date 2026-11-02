using System;

namespace proyecto_sem_12.burbuja
{
    internal class Program
    {
        public static void muestraArreglo(int[] valor)
        {
            for (int i = 0; i < valor.Length; i++)
            {
                Console.Write("| " + valor[i] + " |");
            }
        }
        static void Main(string[] args)
        {
            int valor_independiente;
            //Creamos un arreglo con 5 valores
            int[] valor = { 15, 10, 7, 11, 8 };

            for (int i = 0; i < valor.Length - 1; i++)
            {
                for (int j = 0; j < valor.Length - 1 - i; j++)
                {
                    if (valor[j] > valor[j + 1])
                    {
                        valor_independiente = valor[j + 1];
                        valor[j + 1] = valor[j];
                        valor[j] = valor_independiente;
                    }
                    muestraArreglo(valor);
                    Console.ReadKey();
                }
            }

        }
    }
}
