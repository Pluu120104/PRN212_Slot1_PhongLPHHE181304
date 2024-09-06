namespace PRN212_Slot1_Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Nhap mot so nguyen duong n (0 < n < 1000): ");
                n = Convert.ToInt32(Console.ReadLine());
                if (n <= 0 || n >= 1000)
                {
                    Console.WriteLine("So ban nhap khong phu hop.");
                    Console.WriteLine("Vui long nhap lai.");
                }
            } 
            while (n <= 0 || n >= 1000);
            Console.WriteLine("Cac ky so cua so nguyen duong la :", n);

            if (n >= 100) 
            {
                Console.WriteLine(n / 100); 
                Console.WriteLine((n / 10) % 10); 
                Console.WriteLine(n % 10); 
            }
            else if (n >= 10) 
            {
                Console.WriteLine(n / 10); 
                Console.WriteLine(n % 10); 
            }
            else 
            {
                Console.WriteLine(n);
            }
        }
    }
}
