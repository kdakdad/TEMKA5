using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StringComparisonExample
{
    public static void Main(string[] args)
    {
        string str1 = "Hello";
        string str2 = "hello";
        string str3 = "Hello World";
        string str4 = "Hello";


        // Compare() - сравнение с учетом регистра
        Console.WriteLine($"Compare(\"{str1}\", \"{str2}\"): {string.Compare(str1, str2)}"); // < 0 (str1 < str2)
        Console.WriteLine($"Compare(\"{str1}\", \"{str4}\"): {string.Compare(str1, str4)}"); // 0 (str1 == str4)
        Console.WriteLine($"Compare(\"{str1}\", \"{str3}\"): {string.Compare(str1, str3)}"); // < 0 (str1 < str3)


        // CompareOrdinal() - сравнение без учета регистра
        Console.WriteLine($"CompareOrdinal(\"{str1}\", \"{str2}\"): {string.CompareOrdinal(str1, str2)}"); // <0 (str1 < str2)
        Console.WriteLine($"CompareOrdinal(\"{str1}\", \"{str4}\"): {string.CompareOrdinal(str1, str4)}"); // 0 (str1 == str4)
        Console.WriteLine($"CompareOrdinal(\"{str1}\", \"{str3}\"): {string.CompareOrdinal(str1, str3)}"); // < 0 (str1 < str3)


        // Equals() - сравнение с учетом регистра
        Console.WriteLine($"Equals(\"{str1}\", \"{str2}\"): {str1.Equals(str2)}"); // false
        Console.WriteLine($"Equals(\"{str1}\", \"{str4}\"): {str1.Equals(str4)}"); // true


        // == и != - сравнение с учетом регистра
        Console.WriteLine($"(\"{str1}\" == \"{str2}\"): {str1 == str2}"); // false
        Console.WriteLine($"(\"{str1}\" == \"{str4}\"): {str1 == str4}"); // true
        Console.WriteLine($"(\"{str1}\" != \"{str2}\"): {str1 != str2}"); // true


        // IndexOf() - поиск подстроки
        Console.WriteLine($"IndexOf(\"World\" in \"{str3}\"): {str3.IndexOf("World")}"); // 6


        // Contains() - проверка на наличие подстроки
        Console.WriteLine($"Contains(\"World\" in \"{str3}\"): {str3.Contains("World")}"); // true
        Console.WriteLine($"Contains(\"xyz\" in \"{str3}\"): {str3.Contains("xyz")}"); // false

        Console.ReadKey(); // Задержка для просмотра результата в консоли
    }
}