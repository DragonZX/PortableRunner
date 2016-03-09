using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace PortableRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            string Dir = AppDomain.CurrentDomain.BaseDirectory + "/App";
            string Arch = "";
            string ProjName = "Victoria";
            string Exec, Run, Echo;
            string Arguments = "";

           switch (Arch)
            {
                case "x64":
                    Arch = "x64";
                    break;
                case "x86":
                    Arch = "x86";
                    break;
                default: Arch = "x86";
                    break;
            };

            Exec = Dir + /*"/" + Arch +*/ "/vcr447.exe";
            Run = Exec + Arguments;
            Echo = "Starting " + ProjName + " " + Arch;
            Console.WriteLine(File.Exists(Exec) ? Echo : "File " + Exec + " does not exist.");
            if (File.Exists(Exec)) { Process.Start(Run); } else { Thread.Sleep(2000); Environment.Exit(0); };
            Environment.Exit(0);
        }
    }
}
