using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
class Solution
{
    static void Main(String[] args)
    {
        int stringsCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> inputs = new List<string>();

        for (int i = 0; i < stringsCount; i++)
        {
            string stringsItem = Console.ReadLine();
            inputs.Add(stringsItem);
        }

        foreach (var input in inputs)
        {
            string separatedInput = SeparateWord(input);
            Console.WriteLine(separatedInput);
        }
    }

    public static string SeparateWord(string word)
    {
        char[] letters = word.ToCharArray(); 
        
        string oddLetters = null;
        string evenLetters = null;

        for (int i = 0; i < word.Length; i++)
        {
            if (i % 2 == 0)
            {
                evenLetters = string.Concat(evenLetters, letters[i]);
            }
            else
            {
                oddLetters = string.Concat(oddLetters, letters[i]);
            }
        }

        string separatedWord = String.Format("{0} {1}", evenLetters, oddLetters);

        return separatedWord;
    }
}