using System;
using System.IO;
using System.Diagnostics;

namespace StartAll
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Usage: StartAll <StartDir>");
                Console.ReadLine();
                return;
            }
            if (!Directory.Exists(args[0]))
            {
                Console.WriteLine($"Directory {args[0]} not found");
                Console.ReadLine();
                return;
            }
            string[] files = Directory.GetFiles(args[0], "*.exe", SearchOption.AllDirectories);
            foreach (string file in files)
            {
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = file;
                psi.CreateNoWindow = true;
                Process.Start(psi);
            }
        }
    }
}
