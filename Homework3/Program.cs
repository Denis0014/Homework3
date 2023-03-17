using System;
using System.Text.RegularExpressions;

namespace HomeWork3
{
    internal class Program
    {
        static void PrintArr<T>(T[] arr, string delim = " ")
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + delim);
            Console.WriteLine();
        }
        /// <summary>
        /// Возвращает корректные регистрационные знаки
        /// </summary>
        /// <param name="s">Исходная строка</param>
        /// <returns>Массив строк</returns>
        static string[] GetRegMarks(string s) => Regex.Matches(s, @"[АВЕКМНОРСТУХ]{2}\d{3}[АВЕКМНОРСТУХ]").Select(x => x.Value).ToArray();
        /// <summary>
        /// Преобразовывет текст, обрамленный в звездочки, в текст обрамленный тегом <em></em>, т.е. курсив. <br></br>
        /// Не трогает текст в двойных звездочках (жирный)
        /// </summary>
        /// <param name="s">Исходная строка</param>
        static void ToItalic(ref string s) => s = Regex.Replace(s, @"(?!<\*)\*([^*]+?)\*(?!\*)", x => "<em>" + x.Groups[1].Value + "</em>" );
        /// <summary>
        /// Проверяет корректность IPv4 Адреса
        /// </summary>
        /// <param name="s"></param>
        /// <returns>(false, true)</returns>
        static bool CheckIP(string s) => Regex.IsMatch(s, @"\b((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b");
        static void Main(string[] args)
        {
            // Задание 1
            PrintArr(GetRegMarks("ХХ001Х АО101К НО712Е"));
            // Задание 2
            string s = "*this is italic* **bold text(not italic)**";
            ToItalic(ref s);
            Console.WriteLine(s);
            // Задание 3
            Console.WriteLine($"{CheckIP("255.255.255.255")} {CheckIP("0.0.0.0")} {CheckIP("128.0.0.1")} {CheckIP("256.0.0.0")}");
        }
    }
}