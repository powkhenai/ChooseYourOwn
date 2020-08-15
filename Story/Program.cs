using System;

namespace Story
{
    class Program
    {
        static void Main(string[] args)
        {
            string stuff = "ja;lskdfja;osihdf;aposidhf;aosidfh;aoslidkf;fkjha;osidfkha;sldkfija;sodifha;sodfihja;slidfja;solidfa;posidfh";
            Console.WriteLine(string.Format("The previous string was {0} characters long!", RenderScreen(stuff)));
            RenderScreen("This is a simple screen.");
            RenderScreen("This is an incredibly robust and interesting screen that is going to present epic amounts of data, and incredible runon sentences that can just never ever ever ever be stopped no matter how hard we try to stop them it just won't ever happen!!!!!");
        }

        static int RenderScreen(string output)
        {
            Console.Clear();
            int line_length = 80;

            Console.WriteLine("".PadRight(line_length, '='));
            if (output.Length > line_length - 10)
            {
                int num_lines = output.Length / (line_length - 10) + 1;
                for (int i = 0; i < num_lines; i++)
                {
                    if (i == num_lines - 1)
                    {
                        Console.WriteLine("| " + output.Substring((line_length - 10) * i, output.Length - (line_length - 10) * i).PadRight(line_length - 3) + "|");
                    }
                    else
                    {
                        Console.WriteLine("| " + output.Substring((line_length - 10) * i, line_length - 10).PadRight(line_length - 3) + "|");
                    }
                }
            }
            else
            {
                Console.WriteLine("| " + output.PadRight(line_length - 3) + "|");
            }
            Console.WriteLine("".PadRight(line_length, '='));
            Console.ReadLine();
            return output.Length;
        }
    }
}
