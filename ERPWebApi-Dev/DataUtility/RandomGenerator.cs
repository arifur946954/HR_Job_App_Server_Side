using System;
using System.Collections.Generic;
using System.Text;

namespace DataUtility
{
    public class RandomGenerator
    {
        //RandomGenerator generator = new RandomGenerator();
        //int rand = generator.RandomNumber(5, 100);
        //Console.WriteLine($"Random number between 5 and 100 is {rand}");    
    
        //string str = generator.RandomString(10, false);
        //Console.WriteLine($"Random string of 10 chars is {str}");    
    
        //string pass = generator.RandomPassword();
        //Console.WriteLine($"Random string of 6 chars is {pass}");    

        // Generate a random number between two numbers    
        public static int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        // Generate a random string with a given size    
        public static string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }

        // Generate a random password    
        public static string RandomPassword()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4, true));
            builder.Append(RandomNumber(1000, 9999));
            builder.Append(RandomString(2, false));
            return builder.ToString();
        }        

        public static string RandomNumericPassword()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomDigits(10));
            return builder.ToString();
        }

        public static string RandomDigits(int length)
        {
            var random = new Random();
            string s = string.Empty;
            for (int i = 0; i < length; i++)
                s = String.Concat(s, random.Next(10).ToString());
            return s;
        }
    }
}
