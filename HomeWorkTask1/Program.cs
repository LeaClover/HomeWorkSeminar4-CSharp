// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


namespace GB.CSharp.Seminar4
{
    class homework1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите число A и число B, и мы возведем A в степень B!");
            Console.WriteLine("Введите число A: ");
            double numberA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число B (степень): ");
            int numberB = Convert.ToInt32(Console.ReadLine());
            double res = GetExponen(numberA, numberB);
            Console.WriteLine($"{numberA}^{numberB} = {res}");
        }
        public static double GetExponen(double A, int B)
        {
            double result = 1;
            result = result*A;
            for(int i = 1; i<B; i++)
            {
                result = result*A;
            }
            return result;
        }
    }
}