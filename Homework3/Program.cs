using System;
using System.Text.RegularExpressions;

namespace HomeWork3
{
    internal class Program
    {
        static void PrintArr<T>(T[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write($"{arr[i]} ");
        }
        static string[] GetRegMarks(string s) => Regex.Matches(s, @"[АВЕКМНОРСТУХ]{2}\d{3}[АВЕКМНОРСТУХ]").Select(x => x.Value).ToArray();
        static void Main(string[] args)
        {
            PrintArr(GetRegMarks("ХХ001Х АО101К НО712Е"));
        }
    }
} 