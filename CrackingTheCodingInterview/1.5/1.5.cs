﻿using System;
using System.Collections.Generic;

namespace CrackingTheCodingInterview
{
    public class OneDotFive
    {
        public static void Main(string[] args)
        {
            // 1.5: One Away: There are three types of edits that can be performed on strings: insert a character, remove a character, or replace a character.
            // Given two strings, write a function to check if they are one edit (or zero edits) away.

            Console.WriteLine(IsOneAway("pale", "ple"));
            Console.WriteLine(IsOneAway("pales", "pale"));
            Console.WriteLine(IsOneAway("pale", "bale"));
            Console.WriteLine(IsOneAway("pale", "bake"));
            Console.WriteLine(IsOneAway("aaaa", "abaa"));
            Console.ReadLine();
        }

        //Technically this is a O(n) solution but is not very optimal at all...
        public static bool IsOneAway(string a, string b)
        {
            Dictionary<char, int> mappedString = new Dictionary<char, int>();
            foreach(char c in a.ToCharArray())
            {
                if(mappedString.ContainsKey(char.ToLower(c)) == false)
                {
                    mappedString.Add(char.ToLower(c), 1);
                }
                else
                {
                    mappedString[char.ToLower(c)] += 1;
                }
            }

            foreach(char c in b.ToCharArray())
            {
                if(mappedString.ContainsKey(char.ToLower(c)) == true)
                {
                    mappedString[c] -= 1;
                }
            }

            int numberAway = 0;
            foreach (char c in mappedString.Keys)
            {
                numberAway += mappedString[c];
            }

            if (numberAway <= 1)
                return true;
            else
                return false;
        }
    }
}
