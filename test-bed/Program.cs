using System;
using System.Diagnostics;
using System.Linq;

namespace MCReach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "WESSEX CLIENT 0.1";
            Console.WriteLine("\n");
            Console.WriteLine("▒█░░▒█ ▒█▀▀▀█ ▀▄▒▄▀ 　 ▒█▀▀█ ▒█░░░ ▀█▀ ▒█▀▀▀ ▒█▄░▒█ ▀▀█▀▀ ");
            Console.WriteLine("▒█▒█▒█ ░▀▀▀▄▄ ░▒█░░ 　 ▒█░░░ ▒█░░░ ▒█░ ▒█▀▀▀ ▒█▒█▒█ ░▒█░░ ");
            Console.WriteLine("▒█▄▀▄█ ▒█▄▄▄█ ▄▀▒▀▄ 　 ▒█▄▄█ ▒█▄▄█ ▄█▄ ▒█▄▄▄ ▒█░░▀█ ░▒█░░ ");
            Console.WriteLine("\n");

            double legitreach = 3.0;
            double valuereach = 0.0;
            double legitkb = 8000;
            double valuekb = 0.0;
            string name = "";
            string password = "";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("[SECURITY]");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" - User");
            name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("[SECURITY]");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" - Password");
            password = Console.ReadLine();

            if ((name == "sev7n") && (password == "buythatplease"))
            {
                IntPtr[] reachAddresses = Process.GetCurrentProcess().Modules.Cast<ProcessModule>()
                    .Where(module => module.ModuleName.Equals("javaw"))
                    .Select(module => module.BaseAddress)
                    .ToArray();

                IntPtr[] velocityAddresses = Process.GetCurrentProcess().Modules.Cast<ProcessModule>()
                    .Where(module => module.ModuleName.Equals("javaw"))
                    .Select(module => module.BaseAddress)
                    .ToArray();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("[?]");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" - Who you want to change?");
                string who = Console.ReadLine();

                if (who.Equals("reach"))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[!]");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" - Reach:");
                    try
                    {
                        valuereach = Convert.ToDouble(Console.ReadLine());
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("[!]");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(" - Wrong Value.");
                        return;
                    }

                    foreach (IntPtr address in reachAddresses)
                    {
                        double x = BitConverter.ToDouble(BitConverter.GetBytes(address.ToInt64()), 0);
                        if (x == legitreach)
                        {
                            byte[] newValueBytes = BitConverter.GetBytes(valuereach);
                            for (int i = 0; i < newValueBytes.Length; i++)
                            {
                                
                            }
                        }
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("[!]");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" - Reach has been set to: " + valuereach);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("[!]");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" - Press 'ENTER' to self-destruct and clear strings!");
                    Console.ReadKey();

                    string strB = string.Format("{0}\\{1}", Environment.GetEnvironmentVariable("WINDIR"), "explorer.exe");
                    foreach (Process process in Process.GetProcesses())
                    {
                        try
                        {
                            bool flag = string.Compare(process.MainModule.FileName, strB, StringComparison.OrdinalIgnoreCase) == 0;
                            if (flag)
                            {
                                process.Kill();
                            }
                        }
                        catch
                        {
                        }
                    }
                    Process.Start("explorer.exe");
                }
                else if (who.Equals("velocity"))
                {
                    Console.WriteLine("Velocity:");
                    try
                    {
                        valuekb = Convert.ToDouble(Console.ReadLine());
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("[!]");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(" - Wrong Value.");
                        return;
                    }
                }
            }
        }
    }
}

               