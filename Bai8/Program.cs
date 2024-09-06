namespace Bai8
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 6; 
            int cols = 10; 
            for (int i = 1; i <= rows; i++)
            {
                if (i == 1 || i == rows)
                {
                    for (int j = 1; j <= cols; j++)
                    {
                        Console.Write("* ");
                    }
                }
                else 
                {
                    Console.Write("* "); 
                    for (int j = 1; j <= cols - 2; j++) 
                    {
                        Console.Write("  "); 
                    }
                    Console.Write("* "); 
                }
                Console.WriteLine();
            }
        }
    }
}
