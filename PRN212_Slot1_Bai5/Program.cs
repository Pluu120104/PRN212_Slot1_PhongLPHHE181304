namespace PRN212_Slot1_Bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            double diemThi1, diemOnline, diemThiCuoiKy, diemTongKet;


            diemThi1 = NhapDiem("Nhap diem thi lan 1 (0-10): ");
            diemOnline = NhapDiem("Nhap diem online (0-10): ");
            diemThiCuoiKy = NhapDiem("Nhap diem thi cuoi ky (0-10): ");


            diemTongKet = (diemThi1 * 0.25) + (diemOnline * 0.25) + (diemThiCuoiKy * 0.50);

            Console.WriteLine($"Diem tong ket cua mon Ngon ngu lap trinh C#: {diemTongKet:F2}");
        }

        static double NhapDiem(string prompt)
        {
            double diem;
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (double.TryParse(input, out diem))
                {

                    if (diem >= 0 && diem <= 10)
                    {
                        return diem;
                    }
                    else
                    {
                        Console.WriteLine("Diem khong hop le. Vui long nhap lai! (0-10).");
                    }
                }
                else
                {
                    Console.WriteLine("Dau vao khong hop le. Vui long nhap so!");
                }
            }
        }
    }
}
