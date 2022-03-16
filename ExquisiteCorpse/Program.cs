using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExquisiteCorpse
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Exquisite Corpse with C#.
            This program creates an Exquisite Corpse. Participants draw either a head, body, or feet of a creature. The players don’t know how their part of the body connects to the other two, until the drawing is finished and revealed.
            Overall, developing it helped me to practice my skill creating Methods in C#.
            Author: Ricardo Carvalheira
            */
            Console.WriteLine("Welcome to the Exquisite Corpse Program!");
            Console.Write("\r\nPlease select the program mode:\r\n 1 - Create your own Exquisite Corpse\r\n 2 - Create a random Corpse\r\n\r\nMode: ");
            int programMode = Convert.ToInt32(Console.ReadLine());

            if (programMode == 1)
            {

                Console.WriteLine("\r\nPlease enter the body part: \r\nGhost\r\nBug\r\nMonster\r\n");
                Console.Write("Head: ");
                int headNum = TranslateToNumber(Console.ReadLine());
                Console.Write("Body: ");
                int bodyNum = TranslateToNumber(Console.ReadLine());
                Console.Write("Feet: ");
                int feetNum = TranslateToNumber(Console.ReadLine());
                SwitchCase(headNum, bodyNum, feetNum);
            }

            else if (programMode == 2)
            {
                RandomMode();
            }

            else
            {
                Console.WriteLine("\r\nInvalid Enter!\r\nGoodbye!");
            }
            Console.WriteLine("Press enter to end program");
            Console.ReadLine();
            //SwitchCase(headNum, bodyNum, feetNum);
        }
        static void BuildACreature(string head, string body, string feet)
        {

            int headNum = TranslateToNumber(head);
            int bodyNum = TranslateToNumber(body);
            int feetNum = TranslateToNumber(feet);
            SwitchCase(headNum, bodyNum, feetNum);

        }
        static void RandomMode()
        {
            Random randomNumber = new Random();
            int head = randomNumber.Next(1, 4);
            int body = randomNumber.Next(1, 4);
            int feet = randomNumber.Next(1, 4);
            SwitchCase(head, body, feet);

        }
        static void SwitchCase(int head, int body, int feet)
        {
            //  string headString = TranslateToString(head);
            //  string headString = TranslateToString(body);
            //string feetString = TranslateToString(feet);
            Console.WriteLine($"\r\nYour monster had a head of a {TranslateToString(head)}, body of a {TranslateToString(body)}, and feet of a {TranslateToString(feet)}!");
            switch (head)
            {
                case 1:
                    GhostHead();
                    break;
                case 2:
                    BugHead();
                    break;
                case 3:
                    MonsterHead();
                    break;
            }

            switch (body)
            {
                case 1:
                    GhostBody();
                    break;
                case 2:
                    BugBody();
                    break;
                case 3:
                    MonsterBody();
                    break;

            }

            switch (feet)
            {
                case 1:
                    GhostFeet();
                    break;
                case 2:
                    BugFeet();
                    break;
                case 3:
                    MonsterFeet();
                    break;

            }


        }
        static int TranslateToNumber(string creature)
        {
            switch (creature)
            {
                case "ghost":
                    return 1;
                case "bug":
                    return 2;
                case "monster":
                    return 3;
                default:
                    return 1;
            }

        }
        static string TranslateToString(int creature)
        {
            switch (creature)
            {
                case 1:
                    return "ghost";
                case 2:
                    return "bug";
                case 3:
                    return "monster";
                default:
                    return "ghost";
            }

        }
        static void GhostHead()
        {
            Console.WriteLine("     '~~~' ");
            Console.WriteLine("     /   \\");
        }

        static void GhostBody()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
        }

        static void GhostFeet()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    '~~~~~'");
        }

        static void BugHead()
        {
            Console.WriteLine("     /   \\");
            Console.WriteLine("     \\. ./");
            Console.WriteLine("    (o + o)");
        }

        static void BugBody()
        {
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
        }

        static void BugFeet()
        {
            Console.WriteLine("     v   v");
            Console.WriteLine("     *****");
        }

        static void MonsterHead()
        {
            Console.WriteLine("     _____");
            Console.WriteLine(" .-,;='';_),-.");
            Console.WriteLine("  \\_\\(),()/_/");
            Console.WriteLine("　   (,___,)");
        }

        static void MonsterBody()
        {
            Console.WriteLine("   ,-/`~`\\-,___");
            Console.WriteLine("  / /).:.('--._)");
            Console.WriteLine(" {_[ (_,_)");
        }

        static void MonsterFeet()
        {
            Console.WriteLine("    |  Y  |");
            Console.WriteLine("   /   |   \\");
            Console.WriteLine("   \"\"\"\" \"\"\"\"");
        }


    }
}
