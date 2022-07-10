// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

// 4  -> 24
// 5  -> 120

namespace GB.CSharp.Seminar4
{ 
    class task1 
    { 
        public static void Main(string[] args) 
        { 
            Console.WriteLine("Введите число N и мы найдем произведение от 1 до N!");
            int N = Convert.ToInt32(Console.ReadLine());
            int res = GetProduct(N);
            Console.WriteLine(res);
        } 

        public static int GetProduct(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result = result * i;
            }
            return result;
        }
    } 
}