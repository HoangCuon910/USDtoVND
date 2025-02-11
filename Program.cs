using System;

namespace MoneyCoverter
{
    class Program
    {
        static void Main(string[] args)
        {
            float rate = 25300f;

            Console.WriteLine("Nhap gia tri USD: ");
            float usdValue = float.Parse(Console.ReadLine());
            
            float vndValue = usdValue * rate;

            Console.WriteLine($"{usdValue} USD = {vndValue} VND.");
        }
    }
}