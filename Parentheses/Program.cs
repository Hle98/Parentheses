using System;
using System.Collections.Generic;

namespace Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string results = "";
            Parentheses(3,3, results);
        }
        static void Parentheses(int openingParentheses, int closingParentheses, string results)
        {
            if (openingParentheses == 0 && closingParentheses == 0)
            {
                Console.WriteLine(results);
                return;
            }
            if (openingParentheses > 0)
            { 
                Parentheses(openingParentheses - 1, closingParentheses, results + "(");
            }
            if (closingParentheses > openingParentheses)
            {
                Parentheses(openingParentheses, closingParentheses - 1, results + ")");
            }
        }
    }
}
