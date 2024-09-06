namespace PRN212_Slot1_Bai6
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, chuVi, dienTich;

            a = NhapCanh("Nhap canh goc vuong thu nhat (a > 0): ");
            b = NhapCanh("Nhap canh goc vuong thu hai (b > 0): ");
            c = Math.Sqrt(a * a + b * b);
            chuVi = a + b + c;
            dienTich = (a * b) / 2;

            Console.WriteLine($"Chu vi cua tam giac vuong la : {chuVi:F2}");
            Console.WriteLine($"Dien tich cua tam giac vuong la : {dienTich:F2}");
        }

        static double NhapCanh(string prompt)
        {
            double canh;
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (double.TryParse(input, out canh))
                {
                    if (canh > 0)
                    {
                        return canh; 
                    }
                    else
                    {
                        Console.WriteLine("Gia tri phai la so duong. Vui long nhap lai!");
                    }
                }
                else
                {
                    Console.WriteLine("Gia tri phai la so duong. Vui long nhap so!");
                }
            }
        }
    }
}
