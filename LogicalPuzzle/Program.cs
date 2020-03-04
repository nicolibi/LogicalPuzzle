namespace FibonacciNumbers
{
    class Program
    {

        static void Main(string[] args)
        {
            FibonacciLoop();
            FibonacciRecursiveMain();
            System.Console.ReadLine();
        }

        static void FibonacciLoop()
        {
            System.Console.WriteLine("Fibonaccinumbers Loop");
            int number1 = 0;
            int number2 = 1;
            int CountNumbers = 17;
            int[] FibonacciRow = new int[(CountNumbers)];
            FibonacciRow[0] = number1;
            FibonacciRow[1] = number2;
            for (int i = 0; i < (CountNumbers - 2); i++)
            {
                var result = number1 + number2;
                number1 = number2;
                number2 = result;
                FibonacciRow[i + 2] = result;
            }
            System.Console.WriteLine("[{0}]", string.Join(", ", FibonacciRow));
        }

        static void FibonacciRecursiveMain()
        {
            System.Console.WriteLine("Fibonaccinumbers Recursive Solution");
            int CountNumbers = 17;
            int[] FibonacciRow2 = new int[(CountNumbers)];
            FibonacciRow2[0] = 0;
            for (int i = 0; i < (CountNumbers - 1); i++)
            {
                FibonacciRow2[i + 1] = RecursiveSolution(i);
            }
            System.Console.WriteLine("[{0}]", string.Join(", ", FibonacciRow2));
        }

        private static int RecursiveSolution(int n)
        {
            if (n <= 1)
                return 1;

            int zahl1 = RecursiveSolution(n - 2);
            int zahl2 = RecursiveSolution(n - 1);
            return zahl1 + zahl2;

        }
    }
}
