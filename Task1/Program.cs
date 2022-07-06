// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

// 4  -> 24
// 5  -> 120

namespace HelloWorld 
{ 
    class Program 
    { 
        public static void Main(string[] args) 
        { 
            Console.WriteLine("Введите число N и мы найдем произведение от 1 до N!");
            int N = Convert.ToInt32(Console.ReadLine());
            int result = 1;
            for (int i = 1; i <= N; i++)
            {
                result = result * i;
            }
            Console.WriteLine(result);
        } 
    } 
}