using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Memory;
using System.Threading.Tasks;
using Ares.Handler;
using Ares.Handler.CMD;

namespace Ares.Wndws
{
    internal class mainConsoleWndw
    {
        public static Mem Memory = new Mem();

        static void Main(string[] args)
        {
            Startup();
        }

        static void Startup()
        {
            //set size and title, also removes the scroll bar unless you resize it
            Console.BufferWidth = Console.WindowWidth = 110;
            Console.BufferHeight = Console.WindowHeight = 28;
            WindowUtility.MoveWindowToCenter();
            checkProcess();
            Options();
        }

        static void Options()
        {
            Console.Clear();
            WriterUtility.writeLogo();
            Console.WriteLine("");

            WriterUtility.optionsWriter("Unlimited ammo");
            WriterUtility.optionsWriter("Exit");

            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    if (Data.procOpen)
                    {
                        try
                        {
                            Console.Clear();
                            WriterUtility.resetOptions();
                            WindowUtility.centerText("Select weapon:");
                            WriterUtility.optionsWriter("Intervention");
                            WriterUtility.optionsWriter("Deagle");
                            var weapon = Console.ReadLine();
                            switch (weapon)
                            {
                                case "1":
                                    Memory.FreezeValue(Data.interventionAmmoPointer, "int", "30");
                                    WriterUtility.resetOptions();
                                    Options();
                                    return;

                                case "2":
                                    Memory.FreezeValue(Data.deagleAmmoPointer, "int", "30");
                                    WriterUtility.resetOptions();
                                    Options();
                                    return;

                                default:
                                    WriterUtility.resetOptions();
                                    Options();
                                    return;
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.Clear();
                            Console.WriteLine(ex.Message);
                            Console.ReadLine();
                            WriterUtility.resetOptions();
                            Options();
                        }
                    }
                    break;

                case "2":
                    Environment.Exit(0);
                    break;

                default:
                    WriterUtility.resetOptions();
                    Options();
                    return;
            }
        }


        static void checkProcess()
        {
            Process[] processes = Process.GetProcessesByName("iw4x");
            if (processes.Length == 0)
            {
                Console.Title = "Ares | iw4x not detected";
                Data.procOpen = false;
            }
            else
            {
                Console.Title = "Ares | iw4x detected";
                Memory.OpenProcess("iw4x");
                Data.procOpen = true;
            }
        }
    }

}
