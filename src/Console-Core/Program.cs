using Console_Desktop;

namespace Console_Core
{
    public class Program
    {
        public static void Main(string[] args)
        {
            foreach (var c in Resource1.String1)
            {
                if (c == '\r')
                    System.Console.Write("\\r");
                else if (c == '\n')
                    System.Console.Write("\\n");
                else if (c == '\t')
                    System.Console.Write("\\t");
                else
                    System.Console.Write(c);
            }
            System.Console.WriteLine();
        }
    }
}
