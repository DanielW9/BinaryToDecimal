using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binarne
{
    internal class Program
    {
        public class Binary
        {
            // Konwersja liczby binarnej na dziesiętną
            public static int Convert(string binary)
            {
                int ValueDecimal = 0;
                
                // Pobranie długości ciągu binarnego
                int binaryLength = binary.Length;

                for (int i = 0; i < binaryLength; i++)
                {
                   
                    int number = binary[binaryLength - i - 1] - '0';
                    ValueDecimal += number * (int)Math.Pow(2, i);
                }

                return ValueDecimal;
            }
            // Zmiana z binarnej na dziesiętną
            public static void Main(string[] args)
            {
                // Wprowadzamy liczbę binarną, którą chcemy zmienić
                string NumberBinary = "11101001";

                int NumberDecimal = Convert(NumberBinary);

                Console.WriteLine($"Liczba binarna {NumberBinary} w systemie dziesiętnym to {NumberDecimal}");
            }
        }
    }
}

