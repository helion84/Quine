using System;
using System.Collections.Generic;

namespace SelfOutput
{
    class Program
    {
        static void Main()
       {
            var quote = (char)34;
            var comma = (char)44;
            var codeLineList = new List<string>
            {
                "using System;",
                "using System.Collections.Generic;",
                "namespace SelfOutput",
                "{",
                "class Program",
                "{",
                "static void Main()",
                "{",
                "var quote = (char)34;",
                "var comma = (char)44;",
                "var codeLineList = new List<string>",
                "{",
                "",
                "};",
                "foreach (var codeLine in codeLineList)",
                "{",
                "if (codeLine == codeLineList[12])",
                "{",
                "foreach (var listLine in codeLineList)",
                "{",
                "Console.WriteLine(quote + listLine + quote + comma);",
                "}",
                "}",
                "else",
                "{",
                "Console.WriteLine(codeLine);",
                "}",
                "}",
                "Console.ReadLine();",
                "}",
                "}",
                "}",
            };
            foreach (var codeLine in codeLineList)
            {
                if (codeLine == codeLineList[12])
                {
                    foreach (var listLine in codeLineList)
                    {
                        Console.WriteLine(quote + listLine + quote + comma);
                    }
                }
                else
                {
                    Console.WriteLine(codeLine);
                }
            }
            Console.ReadLine();
        }
    }
}
