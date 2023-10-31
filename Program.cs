namespace Metod
{
    internal class Program
    {

        public static int Add(int firstNumber, int secondNumber, int thirdNumber)
        {

            return firstNumber * secondNumber * thirdNumber;

        }
        static void Main(string[] args)
        {

            int result = Add(5, 4, 2);
            Console.WriteLine(result);


        }
    }
}