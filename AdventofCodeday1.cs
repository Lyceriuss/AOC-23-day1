using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;




class Program
{
    static void Main(string[] args)
    {
        List<int> Nums = new List<int>();
        int sum = 0;

        System.Console.Write("Insert data:");
        string input = "2rtjhvsvrmtwo1hgzpeightdjkhxhmseven7"; 
        char[] digitsArray = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        for (int i = 0; i < input.Length; i++)
        {
            if (digitsArray.Contains(input[i]))
            {
                int digit = int.Parse(input[i].ToString());
                Nums.Add(digit);
            }
        }

        string result = Nums.FirstOrDefault() + Nums.LastOrDefault().ToString();

        if (int.TryParse(result, out int parsedResult))
        {
            sum += parsedResult;
        }

        System.Console.WriteLine($"{sum}");

    }
}