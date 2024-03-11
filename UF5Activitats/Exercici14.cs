/* Qihang Li Jiang
* M03_UF5 Programacio
* 11/03/2024
* Exercici 14. Implementa un mètode (diferent per a cada opció) que:
*    - comprovi que una cadena conté només un conjunt determinat de caràcters (en aquest cas a-z, A-Z i 0-9).
*    - comprovi si una cadena conté una a seguida de zero o més b's.
*    - comprovi si una cadena conté una a seguida de dos o tres b's.
*    - trobi seqüències de lletres minúscules unides amb un guió baix
*/

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MyProgram
{
    public class MyCode
    {
        public static void Main()
        {
            Console.WriteLine(MethodA("abc"));
            Console.WriteLine(MethodA("---"));

            Console.WriteLine(MethodB("aii"));
            Console.WriteLine(MethodB("abb"));

            Console.WriteLine(MethodC("abb"));
            Console.WriteLine(MethodC("www"));

            Console.WriteLine(MethodD("abc"));
            Console.WriteLine(MethodC("pcd"));
        }

        public static bool MethodA(string text)
        {
            string pattern = "^[a-zA-Z0-9]*$";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(text);
        }

        //INTENTAT
        public static bool MethodB(string text)
        {
            string pattern = "";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(text);
        }

        public static bool MethodC(string text)
        {
            string pattern = "ab{2,3}";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(text);
        }

        //INTENTAT
        public static bool MethodD(string text)
        {
            string pattern = "";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(text);
        }

    }
}
