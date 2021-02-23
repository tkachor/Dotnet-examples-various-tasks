using System;

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

           
        }
    }
}
