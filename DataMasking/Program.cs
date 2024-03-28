using System;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace DataMasking
{
    internal class Program
    {
        static string MaskCreditCard(string input)
        {
            string result = "";
            for(int i=0;i<input.Length-4;i++)
            {
                if (input[i] >= '0' && input[i] <= '9')
                    result += 'X';
                else result += input[i];
            }
            result += input.Substring(input.Length - 4, 4);
            return result;
        }

        static string MaskSocialSecurity(string input)
        {
            string result = "";
            int i;
            for ( i = 0; i < 3; i++)
            {
                result += 'X';
            }
            result += input.Substring(i, 4);
            i += 4;
            for (; i < input.Length; i++)
            {
                result += 'X';
            }
            return result;
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] words = input.Split(' ');

            Regex creditCardRegex = new Regex("^[0-9]*-[0-9]*-[0-9]*-[0-9]*$");
            Regex securityRegex = new Regex("^[0-9]*-[0-9]*-[0-9]*$");
           // Console.WriteLine(creditCardRegex.IsMatch("1234 - 5678 - 9012 - 3456"));

            for (int i=0;i<words.Length;i++)
            {
               // Console.WriteLine(words[i]);
                if (creditCardRegex.IsMatch(words[i]))
                {
                    Console.WriteLine("Hii");
                    words[i] = MaskCreditCard(words[i]);
                }
                else if (securityRegex.IsMatch(words[i]))
                {
                    words[i] = MaskSocialSecurity(words[i]);    
                }
            }

            Console.WriteLine(string.Join(' ', words));

            

        }
    }
}
