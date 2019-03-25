using System;
using System.Collections.Generic;

namespace SelfOutput
{
    class Program
    {
        static void Main()
       {
            char quote = (char)34;
            char comma = (char)44;
            var list = new List<string>
            {
                "using System;",
                "using System.Collections.Generic;",
                "namespace SelfOutput",
                "{",
                "class Program",
                "{",
                "static void Main()",
                "{",
                "char quote = (char)34;",
                "char comma = (char)44;",
                "var list = new List<string>",
                "{",
                "",
                "};",
                "foreach (var item in list)",
                "{",
                "if (item == list[12])",
                "{",
                "foreach (var item2 in list)",
                "{",
                "Console.WriteLine(quote + item2 + quote + comma); ",
                "}",
                "}",
                "else",
                "{",
                "Console.WriteLine(item); ",
                "}",
                "}",
                "Console.ReadLine();",
                "}",
                "}",
                "}",
            };
            foreach (var item in list)
            {
                if (item == list[12])
                {
                    foreach (var item2 in list)
                    {
                        Console.WriteLine(quote + item2 + quote + comma);
                    }
                }
                else
                {
                    Console.WriteLine(item);
                }
            }
            Console.ReadLine();
        }
    }
}
