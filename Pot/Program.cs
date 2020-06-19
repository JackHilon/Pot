using System;
using System.Collections.Generic;

namespace Pot
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pot
            // https://open.kattis.com/problems/pot
            // power series in some example 

            var samplesNum = EnterNumOfSamples();

            var samples = new List<int>();
            for (int p = 0; p < samplesNum; p++)
            {
                samples.Add(StringToIntConverter(EnterValidString()));
            }

            Console.WriteLine(ListIntSum(samples));
        }
        private static string EnterValidString()
        {
            string str = "";
            try
            {
                str = Console.ReadLine();
                if (str.Length < 2 || str.Length > 4)
                    throw new IndexOutOfRangeException();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return EnterValidString();
            }
            return str;
        }

        private static int ListIntSum(List<int> list)
        {
            int sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sum = sum + list[i];
            }
            return sum;
        }

        private static char[] ArrayMinusOne(char[] arr)
        {
            char[] nums = new char[arr.Length - 1];
            for (int k = 0; k < nums.Length; k++)
            {
                nums[k] = arr[k];
            }
            return nums;
        }
        private static string ToString(char[] arr)
        {
            string str = arr[0].ToString();
            for (int h = 1; h < arr.Length; h++)
            {
                str = str + arr[h].ToString();
            }
            return str;
        }
        private static int StringToIntConverter(string str)
        {
            char[] arr = str.ToCharArray();
            string nStr = ToString(ArrayMinusOne(arr));
            string powerStr = arr[arr.Length - 1].ToString();

            int num = 0;
            int power = 0;

            int result = 1;
            try
            {
                num = int.Parse(nStr);
                power = int.Parse(powerStr);
                result = (int)Math.Pow(num, power);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return StringToIntConverter(Console.ReadLine());
            }
            return result;
        }

        private static int EnterNumOfSamples()
        {
            string str = "";
            int a = 0;
            str = Console.ReadLine();

            try
            {
                a = int.Parse(str);
                if (a < 1 || a > 10)
                    throw new ArgumentException();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return EnterNumOfSamples();
            }
            return a;
        }
    }
}
