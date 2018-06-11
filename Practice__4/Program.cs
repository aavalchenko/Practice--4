using System;
using InputOutputLib;

namespace Practice__4
{
    static class Program
    {
        static void Main(string[] args)
        {
            Int32 p = Convert.ToInt32(GetArray(), 2);
            p *= 3;
            Console.WriteLine("\nДвоичное представление числа 3p:\n" + Convert.ToString(p, 2));
            Console.ReadKey();
        }

        private static string GetArray()
        {
            Int32 n = Get.Int32("Введите число n: ", 1);
            Int16[] array = new Int16[n];
            for (Int32 i = 0; i < n; i++)
                array[i] = Get.Int16("Введите значение в " + i + " ячейке последовательности: ", 0, 1);
            Array.Reverse(array);
            return array.ArrayToString();
        }

        private static string ArrayToString(this Int16[] array)
        {
            string output = "";
            foreach (Int16 digit in array)
            {
                output += digit;
            }

            return output;
        }
    }
}
