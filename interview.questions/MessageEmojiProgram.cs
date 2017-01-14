using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Linq;

class Program {
    private const string YES_STR = "YES";
    private const string NO_STR = "NO";
    private const char OPEN_PAREN = '(';
    private const char CLOSED_PAREN = ')';
    private const char COLON = ':';
    //Would have liked to use String.Empty but couldn't get that to work
    private const string EMPTY_STR ="";
    //When john gets a little weird and winks
    private const char SEMICOLON = ';';
    
    static void Main(string[] args) {
        
        using (StreamReader reader = new StreamReader(Console.OpenStandardInput()))
        while (!reader.EndOfStream) {
            string line = reader.ReadLine();
            Stack openParens = new Stack();
            
            if(line.Equals(EMPTY_STR))
            {
                Console.WriteLine(YES_STR);
            }
            else
            {
                for(var i = 0; i < line.Length; i++)
                {
                    char? previousChar = i == 0 ? null : line[i-1] as char?;
                    var currentChar = line[i];
                    
                    if(currentChar.Equals(OPEN_PAREN){
                        openParens.Push(currentChar);
                    }
                    
                    else if(openParens.Count > 0)
                    {
                       if(previousChar.HasValue && (previousChar.Equals(COLON) || previousChar.Equals(SEMICOLON))
                       {
                           openParens.Pop();
                       }
                        else if(currentChar.Equals(COLON) || previousChar.Equals(SEMICOLON))
                        {
                            openParens.Pop();
                        }
                        
                       else if(currentChar.Equals(CLOSED_PAREN)){
                           openParens.Pop();
                       }
                    }
                }
                
                var output = openParens.Count > 0 ? NO_STR : YES_STR;
                Console.WriteLine(output);
            }
        }
    }
}
