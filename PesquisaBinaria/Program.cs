using System;

namespace PesquisaBinaria
{
    class Program
    {
        static void Main(string[] args)
        {
            var numeros = new[] { 1, 5, 0, 34, 3, 9 };

            Array.Sort(numeros);

            var index = BinarySearch(numeros, 3);
            Console.WriteLine(index);

            Console.ReadKey();
        }

        private static int BinarySearch(int[] array, int item)
        {
            return BinarySearch(array, 0, array.Length - 1, item);
        }

        private static int BinarySearch(int[] array, int esquerda, int direita, int item)
        {

            if (esquerda <= direita)
            {
                var meioDoArray = (esquerda + direita) / 2;

                if (array[meioDoArray] == item)
                    return meioDoArray;

                if (array[meioDoArray] > item)
                    return BinarySearch(array, esquerda, meioDoArray - 1, item);
                else
                    return BinarySearch(array, meioDoArray + 1, direita, item);
            }

            return -1;
        }
    }
}
