// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12


namespace GB.CSharp.Seminar4
{
    class homework2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите число, а мы посчитаем сумму цифр в числе!");
            Console.Write("Введите число A: ");
            int number = Convert.ToInt32(Console.ReadLine());
            string str = Convert.ToString(number);
            int length = str.Length;
            int[] array = GetArray(number, str.Length);
            int res = GetSum(array, length);
            Console.WriteLine($"Сумма цифр числа {number} равна {res}");
        }
        public static int GetSum(int[] arrayS, int size)
        {
            int result = 0;
            for (int i = 0; i < size; i++)
            {
                result = result + arrayS[i];
            }
            return result;
        }

        public static int[] GetArray(int numberX, int n)
        {
            int[] ArrayN = new int[n];
            int index = 0;
            while (index < n)
            {
                ArrayN[n - 1 - index] = numberX % 10;
                numberX = numberX - ArrayN[n - 1 - index];
                numberX = numberX / 10;
                index++;
            }
            return ArrayN;
        }
    }
}