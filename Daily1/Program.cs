using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Daily1
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:
            WriteLine("Chose a secret system : [1] Rovarspraket / [2] Gaymer");
            string Chose = ReadLine();
            string space = "//////////////////////////////////////////////////////////////////////////////////////";
            if (Chose == "1")
            {
                Restart:
                WriteLine("Number 1 Chosen : B3gynd 4t skr1v3 nu");
                string Text = ReadLine();
                string output = "";
                char[] Konsonant = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'z' };

                foreach (char Hey in Text)
                {
                    if (Array.Exists(Konsonant, x => x == char.ToLower(Hey)))
                    {

                        output += (Hey + "o" + char.ToLower(Hey));
                    }
                    else
                    {
                        output += Hey;

                    }


                }
                WriteLine(space + Environment.NewLine + "Din sætning : " + Text + Environment.NewLine + "Oversat til : " + output + Environment.NewLine + space);
                goto Restart;
                ReadLine();

            }
            else if (Chose == "2")
            {
                Restart1:
                WriteLine("Number 2 Chosen : B3gynd at skr1v3 nu");
                string Text = ReadLine();
                char[] Vokal = { 'a', 'e', 'i', 'o', 'u', ' ' };
                string VokalOutput = "";
                string Output = "";
                foreach (char oversæt in Text)
                {
                    if (Array.Exists(Vokal, x => x == char.ToLower(oversæt)))
                    {
                        VokalOutput += oversæt;

                    }
                    else
                    {
                        Output += oversæt;
                    }
                   
                }
                WriteLine(space+Environment.NewLine+"Din sætning : " + Text + Environment.NewLine +"Oversat til : "+ Output + Environment.NewLine + space);
                goto Restart1;
                ReadLine();

            }
            else
            {
                WriteLine("*pzzz* Forkert nummer *pzzz*");
                goto Start;
                ReadLine();

            }
        }
    }
}
