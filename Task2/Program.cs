// Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.

// [1,0,1,1,0,1,0,0]

namespace GB.CSharp.Seminar4
{ 
    class task2
    { 
        public static void Main(string[] args) 
        { 
            Console.WriteLine("Генератор случайного массива с элементами 0 и 1!");
            int length = 8;
            int [] array = GetArray(length);
            Console.Write($"Сгенерирован следующий массив: ");
            for(int i = 0; i < length; i++)
            {
                Console.Write($"{array[i]}" + " ");
            }
        } 

        public static int [] GetArray(int n)
        {
            int[] ArrayN = new int [n];
            for (int index = 0; index < n; index++)
            {
                ArrayN[index] = new Random().Next(0, 2);
            }
            return ArrayN;
        }
    } 
}