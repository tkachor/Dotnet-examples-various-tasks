using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            // Concatenation

            string firstPart = "First", secondPart = "Second";

            string concatenation1 = "Result Concatenation:" + firstPart + " " + secondPart;

            concatenation1 += "!";

            string concatenation2 = string.Format("Result Concatenation: {firstPart} + {secondPart}", firstPart, secondPart);

            Console.WriteLine(concatenation1);
            Console.WriteLine(concatenation2);


            // Interpolation

            string interpolatio = $"Result Interpolatio: {firstPart} + {secondPart} ";

            Console.WriteLine(interpolatio);


            // Format Specifiers

            Console.WriteLine("1. C format: {0:C}", 2.50);     // 2.50 $
            Console.WriteLine("2. D format: {0:D}", 25);       // 25
            Console.WriteLine("3. E format: {0:E2}", 250000);  // 2,50E+005
            Console.WriteLine("4. F format: {0:F2}", 2.5);     // 2,50
            Console.WriteLine("5. G format: {0:G}", 2.5);      // 2.5 (По замовчуванню)
            Console.WriteLine("6. N format: {0:N}", 2500000);  // 2 500 000,00 Numeric
            Console.WriteLine("7. P format: {0:P}", 0.25);     // 25,00%
            Console.WriteLine("8. R format: {0:R}", 2.5);      // 2,5 (Без округлення)
            Console.WriteLine("9. X format: {0:X}", 250);      // FA (Шістнадцатеричний)


            // BNF: {<interpolationExpression>[,<alignment>][:<formatString>]}

            double interpolationExpression = 0.123456789_12345678;
            const int alignment = 30;

            Console.WriteLine($"10. R format: {interpolationExpression,-alignment:R} : End.");  // Round-Trip

            Console.WriteLine($"11. R format: {interpolationExpression,alignment:R} : End.");  // Round-Trip


            // EscapeSequences

            Console.WriteLine('\''); // Single quotation mark
            Console.WriteLine("\'");
            Console.WriteLine("'");

            Console.WriteLine("Peeter say: \"Hay\"."); // Double quotation mark
            Console.WriteLine(@"Peeter say: ""Hay"".");

            Console.WriteLine("C:\\Windows\\notepad.exe");
            Console.WriteLine(@"C:\Windows\notepad.exe");

            Console.WriteLine("Hello world!\0"); // Zero-termination string

            Console.WriteLine("\a");           // Alert 

            Console.Write("Backspace\b");      // Return one position
            Console.WriteLine("!");

            Console.Write("Hello\n");          // Enter

            Console.Write("Hello\r");          // Return to start string

            Console.WriteLine("1 \t 2 \t 3");  // Horizontal tabulation

            Console.WriteLine("1 \v 2 \v 3");  // Vertical tabulation


            // ASCII 

            Console.WriteLine("\x48\x65\x6c\x6c\x6f\x20\x57\x6f\x72\x6c\x64\x21");

            // Unicode

            Console.WriteLine("\x0048\x0065\x006c\x006c\x006f\x0020\x0057\x006f\x0072\x006c\x0064\x0021");

            // Divide the string into an array of words with one separator
            static string[] DivideTheString(string str)
            {
                return str.Split(' ');
            }

            // Remove spaces from the beginning and end of the line
            string source = "   I'm wider than I need to be.  ";
            var trimmedResult = source.Trim();
            var trimLeading = source.TrimStart();
            var trimTrailing = source.TrimEnd();

            // Replace the selected word or character in a string
            var replacement = source.Replace("need", "wont");
            var replacemantChar = source.Replace(' ', '_');

            // How many words begin or end with the same letter
            static int numberOfStartLetters(string str, char ch)
            {
                int counter = 0;

                string[] strArray = str.Split(' ');

                foreach (var s in strArray)
                {
                    if (s.ToLower().StartsWith(ch.ToString())) ; // or EndsWith() 
                    {
                        counter++;
                    }
                }
                return counter;
            }

            //Is the word palindrome
            static bool IsPalindron(string str)
            {
                int length = str.Length;

                for (int i = 0; i < length / 2; i++)
                {
                    if (str[i] != str[length - i - 1])
                    {
                        return false;
                    }
                }
                return true;
            }

            // How many words begin or end with the same letter with linq
            static int numberOfStartLettersLinq(string str, char ch)
            {
                return str.Split(' ').Where(n => ((n.StartsWith(ch) || (n.StartsWith(ch))))).Count();
            }


            // Divide the string into an array of words with many separators
            static string[] StringToArray(string str)
            {
                char[] delimiterChars = { ' ', ',', '.', ':', '\t' };

                return str.Split(delimiterChars);
            }

            // Сombine a string array into one string
            static string CombineString(string[] arrayOfString)
            {
                string newString = "";

                for (int i = 0; i < arrayOfString.Length; i++)
                {
                    newString += arrayOfString[i] + " ";
                }

                return newString;
            }

            // Сount the number of words in the text
            static int CountOfWords(string text)
            {
                int counterWords = 0;

                foreach (var item in text.Split(' '))
                {
                    counterWords++;
                }

                return counterWords;

            }

            // Сounting a specific word in the text
            static int CountOfOneWords(string text, string searchWord)
            {
                int counterWords = 0;
                foreach (var item in text.ToLower())
                {
                    if (text.Contains(searchWord))
                    {
                        counterWords++;
                    }
                }

                return counterWords;
            }

            // Counting letters in a text
            static int CountLetters(string text)
            {
                return text.ToCharArray().Length;
            }

            // Counting a specific letters in a text
            static int CountSpecificLetters(string text, char searchChar)
            {
                int counterChars = 0;
                foreach (var item in text.ToLower().ToCharArray())
                {
                    if (item == searchChar)
                    {
                        counterChars++;
                    }
                }
                return counterChars;
            }

            //Find the longest sequence of numbers in the text
            static int LongestSequenceOfNumbers(string str)
            {
                int result = 0;
                int.TryParse(string.Join("", str.Where(c => char.IsDigit(c))), out result);

                return result;
            }

            //Remove the first letters of all words from the text
            static string RemoveTheFirstLetters(string text)
            {
                string result = "";

                foreach (string item in text.Split(' '))
                {
                    result = result + " " + item.Substring(1);
                }

                return result;
            }

            //Delete all repeating words from the line
            static string DeleteAllRepeating(string text)
            {
                return text.Split(' ').Distinct().ToString();
            }

            //Compare string with Revers string
            static bool CompareStrWithReversStr(string str1, string str2)
            {
                char[] str2Revers = str2.ToCharArray();
                Array.Reverse(str2Revers);
                str2 = new string(str2Revers);

                return str1 == str2;
            }

            //Convert text to an abbreviation
            static string ConvertToAbbreviation(string text)
            {
                var textArray = text.ToUpper().Split(' ');
                return textArray[0].Substring(0, 1) + "." + textArray[1].Substring(0, 1);
            }

            //Convert text to an abbreviation with Linq
            static string ConvertToAbbreviationLinq(string text)
            {
                return string.Join(".", text.Split(' ').Select(w => w[0])).ToUpper();
            }

            //Find the text between two strings
            static string TextBetweenTwoString(string text, string openTag, string closeTag)
            {
                int openingPosition = text.IndexOf(openTag);
                int closingPosition = text.IndexOf(closeTag);

                openingPosition += openTag.Length;

                int length = closingPosition - openingPosition;

                return text.Substring(openingPosition, length);
            }

            //Find the text between which in the last parentheses
            static string TextBetweenLastParentheses(string text)
            {
                int openingPosition = text.IndexOf('(');
                openingPosition++;
                int closingPosition = text.IndexOf(')');

                return text.Substring(openingPosition, closingPosition - openingPosition);
            }

            //Replace String in Text
            static string ReplaceString(string text, string replaceText, string pasteText)
            {
                return text.Replace(replaceText, pasteText);
            }

            //Remove String in Text
            static string RmoveString(string text, int startIndex, int endIndex)
            {
                return text.Remove(startIndex, endIndex);
            }

            //Combine two strings without repeating characters and sorting
            static string CombineTwoString(string s1, string s2)
            {
                return new string(s1.Union(s2).OrderBy(i => i).ToArray());
            }

            //Smash all the thong characters through a comma (Method Join)
            static string CharactersThroughAComa(string text)
            {
                char[] charArray = text.ToCharArray();

                string result = "";

                foreach (var item in charArray)
                {
                    result += item + ", ";                  
                }               

                return result;
            }

            // Rever all word in string
            static string ReverseAllWords(string str)
            {
                string result = "";

                string[] arrString = str.Split(' ');

                for (int i = 0; i < arrString.Length; i++)
                {
                    result += new string(arrString[i].Reverse().ToArray()) + " ";
                }

                return result.TrimEnd();
            }

            // Rever all word in string Linq
            static string ReverseAllWordsLinq(string str)
            {
                return string.Join(" ", str.Split(' ').Select(i => new string(i.Reverse().ToArray())));
            }
        }

    }
}


