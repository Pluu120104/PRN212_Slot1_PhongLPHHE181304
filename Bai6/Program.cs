namespace Bai6
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 5;
            for (int i = rows; i >= 1; i--)
            {
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write("  ");
                }
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
