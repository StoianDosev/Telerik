using System;

/*1.Refactor the following examples to produce code with well-named C# identifiers:*/

namespace CodeRefactoring
{
    public class BoolianExample
    {
        public const int MAX_COUNT = 6;

        public void PrintBoolOnConsole(bool param)
        {
            string boolString = param.ToString();
            Console.WriteLine(boolString);
        }
    }

    public class MainClass
    {
        public static void Main()
        {
            BoolianExample example = new BoolianExample();
            example.PrintBoolOnConsole(true);
        }
    }
}
