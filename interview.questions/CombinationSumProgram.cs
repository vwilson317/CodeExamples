using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Collections;

class Program {
    public static int distinctCombinationsCount = 0;
    
    static void Main(string[] args) {
        using (StreamReader reader = new StreamReader(Console.OpenStandardInput()))
        while (!reader.EndOfStream) {
            string line = reader.ReadLine();

            //going to assume a valid int input
            var total = int.Parse(line);
            
            CheckCombinationsSum(total, 0);
            
            Console.WriteLine(distinctCombinationsCount);
        }
    }
    
    private static void CheckCombinationsSum(int total, int setSum)
    {
        if(total == setSum)
        {
            distinctCombinationsCount = distinctCombinationsCount + 1;
        }
        else if(setSum < total)
        {

            CheckCombinationsSum(total, setSum + 1);
            CheckCombinationsSum(total, setSum + 2);
        }
    }
}