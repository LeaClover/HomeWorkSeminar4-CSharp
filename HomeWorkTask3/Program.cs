// Напишите программу, которая задаёт случайный массив случайного размера 
// (от 5 до 10) элементов (значение элементов от 1 до 40) и 
// выводит на экран массив квадратов этих чисел.

// 1, 2, 5, 7, 19 -> [2, 4, 25, 49, 361]
// 6, 1, 33 -> [36, 1, 1089]

namespace GB.CSharp.Seminar4
{
    class homework3
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Создаем случайный массив и возводим его значения в квадрат!");
            int N = new Random().Next(5, 11);
            Console.WriteLine($"Размер массива равен {N}");
            int [] array = GetArray(N);
            Console.Write($"Сгенерирован следующий массив: ");
            for(int i = 0; i < N; i++)
            {
                Console.Write($"{array[i]}" + " ");
            }
            int [] arrayCh = GetSquaresArray(array);
            Console.WriteLine();
            Console.Write($"Квадрат сгенерированного массива: ");
            for(int i = 0; i < N; i++)
            {
                Console.Write($"{arrayCh[i]}" + " ");
            }
        }
        public static int [] GetSquaresArray(int [] arrayS)
        {
            for (int i = 0; i < arrayS.Length; i++)
            {
                arrayS[i] = arrayS[i]*arrayS[i];
            }
            return arrayS;
        }

        public static int[] GetArray(int n)
        {
            int[] ArrayN = new int [n];
            for (int index = 0; index < n; index++)
            {
                ArrayN[index] = new Random().Next(1, 41);
            }
            return ArrayN;
        }
    }
}