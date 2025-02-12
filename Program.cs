using System;

namespace MoneyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            float rate = 25300f;

            float usdValue;
            while (true)
            {
                Console.WriteLine("Nhap so luong USD: ");
                string input = Console.ReadLine();

                if (float.TryParse(input, out usdValue))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Vui long nhap ky tu dang so.");
                }
            }

            float vndValue = usdValue * rate;
            Console.WriteLine($"{usdValue} USD = {vndValue} VND.");
        }
    }
}
