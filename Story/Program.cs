using System;

namespace Story
{
    class Program
    {
        static int RenderScreen(string output)
        {
            Console.Clear();
            int line_length = 80;
            int desired_length = line_length - 5;

            Console.WriteLine("".PadRight(line_length, '='));
            while (output.Length > desired_length)
            {
                Console.WriteLine("| " + output.Substring(0, desired_length).PadRight(line_length - 3) + "|");
                output = output.Remove(0, desired_length);
            }
            Console.WriteLine("| " + output.PadRight(line_length - 3) + "|");
            Console.WriteLine("".PadRight(line_length, '='));
            Console.ReadLine();
            return output.Length;
        }
        static int RenderScreen(string output, string[] options)
        {
            Console.Clear();
            int line_length = 80;
            int desired_length = line_length - 5;
            int player_choice = -1;

            Console.WriteLine("".PadRight(line_length, '='));
            while (output.Length > desired_length)
            {
                Console.WriteLine("| " + output.Substring(0, desired_length).PadRight(line_length - 3) + "|");
                output = output.Remove(0, desired_length);
            }
            Console.WriteLine("| " + output.PadRight(line_length - 3) + "|");
            Console.WriteLine("".PadRight(line_length, '-'));
            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine(string.Format("|   {0}: {1}", i + 1, options[i]).PadRight(line_length - 1) + "|");
            }
            Console.WriteLine("".PadRight(line_length, '='));
            player_choice = int.Parse(Console.ReadLine());
            return player_choice - 1;
        }

        static void Main(string[] args)
        {
            string stuff = "This is a string that runs along for several characters worth of length to be able to test our string chopping funcion.";
            Console.WriteLine(string.Format("The previous string was {0} characters long!", RenderScreen(stuff)));
            RenderScreen("This is a simple screen.");
            RenderScreen("This is an incredibly robust and interesting screen that is going to present epic amounts of data, and incredible runon sentences that can just never ever ever ever be stopped no matter how hard we try to stop them it just won't ever happen!!!!!");
            string weapon_acquisition = "You see a small rectangular item laying on the ground near your feet. In takes on the orange glow of the artificial light in the room. You strongly suspect that it's a Numenera... What will you do?";
            string[] weapon_choices = new string[2] { "Pick it up, it might be useful...", "Leave it there, Numenera are always dangerous..." };
            Console.WriteLine(string.Format("The Player chose: {0}", RenderScreen(weapon_acquisition, weapon_choices)));
        }
    }
}
