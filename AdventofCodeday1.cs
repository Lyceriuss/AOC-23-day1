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

        string input;
        string result ="";
        string[] lines = File.ReadAllLines("input.txt");
        char[] digitsArray = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        for(int j=0; j<lines.Count();j++)
        {
            input=lines[j];

        for (int i = 0; i < input.Length; i++)
        {
            if (digitsArray.Contains(input[i]))
            {
                int digit = int.Parse(input[i].ToString());
                Nums.Add(digit);
            }
        }

        if(Nums.Count>1){
        result = Nums.FirstOrDefault() + Nums.LastOrDefault().ToString();
        }
        else if(Nums.Count==1)
        {
        result = Nums.First().ToString();
        }
        else{
        result = "";
        }

        Nums.Clear();

        if (int.TryParse(result, out int parsedResult))
        {
            sum += parsedResult;
        }

            System.Console.WriteLine($"Iteration: {j+1} Sum:{sum}");

        }   //End of j

        System.Console.WriteLine($"{sum}");

    }
}