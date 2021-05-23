using BattleSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using textAdventure;

namespace Puzzle
{
    public class Puzzle
    {
        public List<Torch> TorchPuzzle = new List<Torch>();

        public enum Torch
        {
            t1,
            t2,
            t3,
            t4
        }
        public static string pdecide;
        public static string pmove;
        public static void controlPuzzle()
        {
            Console.WriteLine($"\n\nCommands:> TORCH[1] TORCH[2] TORCH[3] TORCH[4] [STOP] [EXIT]");
            Console.Write("Input:> ");
            pmove = Console.ReadLine();
            pmove = pmove.ToUpper();
            if (pmove == "STOP" || pmove == "S")
            {
                textAdventure.Program.HallOfTorches();
            }
            if (pmove == "EXIT")
            {
                while (pdecide != "YES" || pdecide != "Y" || pdecide != "NO" || pdecide != "N")
                {
                    Console.Clear();
                    Console.WriteLine($"Are you sure you want to stop playing? There is no save function. Sorry.");
                    Console.Write("[Y]ES/[N]O:> ");
                    pdecide = Console.ReadLine().ToUpper();

                    if (pdecide == "YES" || pdecide == "Y")
                    {
                        Console.Clear();
                        Console.WriteLine($"Thank you for playing!");
                        Console.WriteLine(" _____   ___  ___  ___ _____   _____  _   _ ___________");
                        Console.WriteLine("|  __ \\ / _ \\ |  \\/  ||  ___| |  _  || | | |  ___| ___ \\");
                        Console.WriteLine("| |  \\// /_\\ \\| .  . || |__   | | | || | | | |__ | |_/ /");
                        Console.WriteLine("| | __ |  _  || |\\/| ||  __|  | | | || | | |  __||    / ");
                        Console.WriteLine("| |_\\ \\| | | || |  | || |___  \\ \\_/ /\\ \\_/ / |___| |\\ \\ ");
                        Console.WriteLine(" \\____/\\_| |_/\\_|  |_/\\____/   \\___/  \\___/\\____/\\_| \\_|\n\n");
                        Console.WriteLine("Press Enter to exit.");
                        Console.ReadLine();
                        Environment.Exit(-1);
                    }
                    else if (pdecide == "NO" || pdecide == "N")
                    {
                        Console.Clear();
                        Console.WriteLine("You decide against leaving. You shake your head as to say: I've come this far, there's no point in turning back now!");
                        Console.WriteLine("Press Enter to continue.");
                        Console.ReadLine();
                    }
                }
            }
        }

            /*            while (true) // while (List<Torch> TorchPuzzle != O,O,X,X)
                        {
                            if (pmove == "TORCH1" || pmove == "1")
                            {
                                if (t1 == 1)
                                {
                                    //change torch 1 to lit - change char1 in the list to X
                                }
                                else if (t1 == 0)
                                {
                                    //change torch 1 to unlit change char1 in the list to O
                                }
                            }
                            else if (pmove == "TORCH2" || pmove == "2")
                            {
                                if (t2 == 1)
                                {
                                    //change torch 2 to lit
                                }
                                else if (t2 == 0)
                                {
                                    //change torch 2 to unlit
                                }
                            }
                            else if (pmove == "TORCH3" || pmove == "3")
                            {
                                if (t3 == 1)
                                {
                                    //change torch 3 to lit
                                }
                                else if (t3 == 0)
                                {
                                    //change torch 3 to unlit
                                }
                            }
                            if (pmove == "TORCH4" || pmove == "4")
                            {
                                if (t4 == 1)
                                {
                                    //change torch 4 to lit
                                }
                                else if (t4 == 0)
                                {
                                    //change torch 4 to unlit
                                }
                            }
                        }
            */
        }
    }
