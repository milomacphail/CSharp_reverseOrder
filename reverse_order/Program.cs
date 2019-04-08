using System;

namespace reverse_order
{
        public static class mainClass
        {
            private static int Main(string[] args)
        {
            Console.WriteLine("Enter a number to reverse: ");
                Number = int.Parse(Console.ReadLine());
                int reverseNumber = 0;
                while (Number > 0)
                {
                    int remainder = Number % 10;
                    reverseNumber = (reverseNumber * 10) + remainder;
                    Number = Number / 10;
                }
            
            Console.WriteLine(reverseNumber);

        }
    }
}
