namespace PRN212_Slot1_Bai7
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, chuVi, dienTich;

            a = NhapCanh("Nhap canh thu nhat (a > 0): ");
            b = NhapCanh("Nhap canh thu hai (b > 0): ");
            c = NhapCanh("Nhap canh thu ba (c > 0): ");

            if (KiemTraTamGiac(a, b, c))
            {

                chuVi = a + b + c;

                double p = chuVi / 2;

                dienTich = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

                Console.WriteLine($"Chu vi cua tam giac la : {chuVi:F2}");
                Console.WriteLine($"Dien tich cua tam giac la : {dienTich:F2}");
            }
            else
            {
                Console.WriteLine("Ba canh nay khong tao thanh tam giac hop le.");
            }
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

        static bool KiemTraTamGiac(double a, double b, double c)
        {
            return (a + b > c) && (a + c > b) && (b + c > a);
        }
    }
}
