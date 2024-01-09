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
        var numWords = new Dictionary<string, int>
        {
            {"one", 1}, {"two", 2}, {"three", 3}, {"four", 4},
            {"five", 5}, {"six", 6}, {"seven", 7}, {"eight", 8}, {"nine", 9}
        };
        List<int> nums = new List<int>();
        int sum = 0;

        string[] lines = File.ReadAllLines("input.txt");
        char[] digitsArray = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        for (int j = 0; j < lines.Length; j++)
        {
            string input = lines[j];

            for (int i = 0; i < input.Length; i++)
            {
                if (digitsArray.Contains(input[i]))
                {
                    nums.Add(int.Parse(input[i].ToString()));
                }

                for (int end = i + 1; end <= input.Length; end++)
                {
                    string substring = input.Substring(i, end - i);
                    if (numWords.ContainsKey(substring))
                    {
                        i = end - 1;
                        break;
                    }
                }
            }

            string result = "";
            if (nums.Count > 1)
            {
                result = nums.FirstOrDefault() + nums.LastOrDefault().ToString();
            }
            else if (nums.Count == 1)
            {
                result = nums.First().ToString()+ nums.First().ToString();
            }

            nums.Clear();

            if (int.TryParse(result, out int parsedResult))
            {
                sum += parsedResult;
            }

            Console.WriteLine($"Iteration: {j + 1} Value:{parsedResult} Sum:{sum}");
        }

        Console.WriteLine($"Total Sum: {sum}");
    }
}