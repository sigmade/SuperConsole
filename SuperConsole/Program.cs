using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; //Для создания пауз в мелодии


namespace SuperConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "My Rocking App";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("*********************************");
            Console.WriteLine("****Welcome to My Rocking App****");
            Console.WriteLine("*********************************");
            Console.BackgroundColor = ConsoleColor.Black;
            ShowEnvironmentDetails();
            refrenSolo();
            



            Console.ReadLine();

            MessageBox.Show("Готово!"); 


        }

        private static void ShowEnvironmentDetails()
        {
            // Print out the drives on this machine,
            // and other interesting details.
            foreach (string drive in Environment.GetLogicalDrives())
                Console.WriteLine("Drive: {0}", drive);

            Console.WriteLine("OS: {0}", Environment.OSVersion);
            Console.WriteLine("Number of processors: {0}",
                Environment.ProcessorCount);
            Console.WriteLine(".NET Version: {0}",
                Environment.Version);
            Console.WriteLine("Username: {0}",
                Environment.UserName);
            Console.WriteLine("PC name: {0}",
                Environment.MachineName);
        }
        static void refrenSolo()
        {
            Console.Beep(659, 300);
            Console.Beep(659, 300);
            Console.Beep(659, 300);
            Thread.Sleep(300);
            Console.Beep(659, 300);
            Console.Beep(659, 300);
            Console.Beep(659, 300);
            Thread.Sleep(300);
            Console.Beep(659, 300);
            Console.Beep(783, 300);
            Console.Beep(523, 300);
            Console.Beep(587, 300);
            Console.Beep(659, 300);
            Console.Beep(261, 300);
            Console.Beep(293, 300);
            Console.Beep(329, 300);
            Console.Beep(698, 300);
            Console.Beep(698, 300);
            Console.Beep(698, 300);
            Thread.Sleep(300);
            Console.Beep(698, 300);
            Console.Beep(659, 300);
            Console.Beep(659, 300);
            Thread.Sleep(300);
            Console.Beep(659, 300);
            Console.Beep(587, 300);
            Console.Beep(587, 300);
            Console.Beep(659, 300);
            Console.Beep(587, 300);
            Thread.Sleep(300);
            Console.Beep(783, 300);
            Thread.Sleep(300);
            Console.Beep(659, 300);
            Console.Beep(659, 300);
            Console.Beep(659, 300);
            Thread.Sleep(300);
            Console.Beep(659, 300);
            Console.Beep(659, 300);
            Console.Beep(659, 300);
            Thread.Sleep(300);
            Console.Beep(659, 300);
            Console.Beep(783, 300);
            Console.Beep(523, 300);
            Console.Beep(587, 300);
            Console.Beep(659, 300);
            Console.Beep(261, 300);
            Console.Beep(293, 300);
            Console.Beep(329, 300);
            Console.Beep(698, 300);
            Console.Beep(698, 300);
            Console.Beep(698, 300);
            Thread.Sleep(300);
            Console.Beep(698, 300);
            Console.Beep(659, 300);
            Console.Beep(659, 300);
            Thread.Sleep(300);
            Console.Beep(783, 300);
            Console.Beep(783, 300);
            Console.Beep(698, 300);
            Console.Beep(587, 300);
            Console.Beep(523, 600);
            Thread.Sleep(600);
        }
        
    }
}
