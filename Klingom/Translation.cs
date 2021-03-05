using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Collections;
using Teste_F360___Klingon.Sorter;

namespace Teste_F360___Klingon.Methods
{
    class Translation
    {
        public static int Preposition(string path)
        {
            string fooLetters = "slfwk";
            string[] klingomWord = { };
            int preposition = 0;

            using (StreamReader sr = File.OpenText(path))
            {
                string ln;

                while ((ln = sr.ReadLine()) != null)
                {
                    klingomWord = ln.Split(" ");
                }

                foreach (string word in klingomWord)
                {
                    char lastLetter = word[word.Length - 1];
                    if (word.Length == 3 && !fooLetters.Contains(lastLetter) && !word.Contains('d'))
                    {
                        preposition++;
                    }
                }

                return preposition;
            }
        }

        public static void Verb(string path)
        {
            string fooLetters = "slfwk";
            string[] klingomWord = { };
            int verb = 0;
            int verbFirstPerson = 0;

            using (StreamReader sr = File.OpenText(path))
            {
                string ln;

                while ((ln = sr.ReadLine()) != null)
                {
                    klingomWord = ln.Split(" ");
                }

                foreach(string word in klingomWord)
                {
                    char firstLetter = word[0];
                    char lastLetter = word[word.Length - 1];

                    
                    if(word.Length >= 8 && fooLetters.Contains(lastLetter))
                    {
                        verb++;
                        if(!fooLetters.Contains(firstLetter))
                        {
                            verbFirstPerson++;
                        }
                    }
                }

                Console.WriteLine("Verb: " + verb);
                Console.WriteLine("Verb First Person: " + verbFirstPerson);
            }
        }

        public static void WordTranslation(string path)
        {
            string[] klingomWord = { };


            using (StreamReader sr = File.OpenText(path))
            {
                string ln;

                while ((ln = sr.ReadLine()) != null)
                {
                    if(!klingomWord.Contains(ln))
                    {
                        klingomWord = ln.Split(" ");
                    }                   
                }                
            }

            Array.Sort(klingomWord, AlphabetSorter.CompareStrings);

            int count = 0; 

            foreach (string s in klingomWord)
            {
                if(count <= 10)
                {
                    Console.Write(s + " ");
                    count++;
                }
                else
                {
                    Console.WriteLine();
                    count = 0;
                }               
            }
        }

        public static void Numbers(string path)
        {
            string[] klingomWord = { };
            List<double> KlingomBeautifulNumbers = new List<double>();
            var KlingomAlphabet = "kbwrqdnfxjmlvhtcgzps";

            using (StreamReader sr = File.OpenText(path))
            {
                string ln;

                while ((ln = sr.ReadLine()) != null)
                {
                    if (!klingomWord.Contains(ln))
                    {
                        klingomWord = ln.Split(" ");
                    }
                }
            }

            foreach (string word in klingomWord)
            {
                double Number = 0;
                double Base = 1;

                foreach (char letter in word)
                {
                    Number += KlingomAlphabet.IndexOf(letter) * Base;
                    Base *= 20;

                    if(Number >= 440566 && Number % 3 == 0 && !KlingomBeautifulNumbers.Contains(Number))
                    {
                        KlingomBeautifulNumbers.Add(Number);
                    }
                }
            }

            Console.WriteLine("Beautiful Numers: " + KlingomBeautifulNumbers.Count());
        }
    }
}
