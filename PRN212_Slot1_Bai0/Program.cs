namespace PRN212_Slot1_Bai0
{
    class Program
    {
        static void Main(string[] args)
        {
            // Câu 1: Chuyển số 2021 từ hệ 10 sang các hệ 2, 8, 16
            int decimalNumber = 2021;

            string binary2021 = Convert.ToString(decimalNumber, 2);
            string octal2021 = Convert.ToString(decimalNumber, 8);
            string hex2021 = Convert.ToString(decimalNumber, 16).ToUpper();

            Console.WriteLine("Cau 1:");
            Console.WriteLine("So 2021 doi sang he 2 la: " + binary2021);
            Console.WriteLine("So 2021 doi sang he 8 la: " + octal2021);
            Console.WriteLine("So 2021 doi sang he 16 la: " + hex2021);

            // Câu 2: Chuyển số 101111001010111001110 từ hệ 2 sang các hệ 8, 10, 16
            string binaryString = "101111001010111001110";
            int decimalFromBinary = Convert.ToInt32(binaryString, 2);

            string octalFromBinary = Convert.ToString(decimalFromBinary, 8);
            string hexFromBinary = Convert.ToString(decimalFromBinary, 16).ToUpper();

            Console.WriteLine("\nCau 2:");
            Console.WriteLine("So 101111001010111001110 doi sang he 10 la: " + decimalFromBinary);
            Console.WriteLine("So 101111001010111001110 doi sang he 8 la: " + octalFromBinary);
            Console.WriteLine("So 101111001010111001110 doi sang he 16 la: " + hexFromBinary);

            // Câu 3: Chuyển số 6DA3F9 từ hệ 16 sang các hệ 2, 8, 10
            string hexString = "6DA3F9";
            int decimalFromHex = Convert.ToInt32(hexString, 16);

            string binaryFromHex = Convert.ToString(decimalFromHex, 2);
            string octalFromHex = Convert.ToString(decimalFromHex, 8);

            Console.WriteLine("\nCau 3:");
            Console.WriteLine("So 6DA3F9 doi sang he 10 la: " + decimalFromHex);
            Console.WriteLine("So 6DA3F9 doi sang he 2 la: " + binaryFromHex);
            Console.WriteLine("So 6DA3F9 doi sang he 8 la: " + octalFromHex);
        }
    }
}
