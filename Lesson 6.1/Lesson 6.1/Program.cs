using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson_6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Process[] proces = System.Diagnostics.Process.GetProcesses();
            
            foreach (var pro in proces)
            {
                Console.WriteLine($"{pro}: Ид процесса {pro.Id}\n");
            }
            int a=Convert.ToInt32(Console.ReadLine());
           
                try
                {
                    Process();
                }
                catch
                {
                    Console.WriteLine("введено неверное значения ");
                    Process();
                }
      
          
          




        }

        private static void Process()
        {
            Console.WriteLine("как хотите закрыть процесс ?");
            Console.WriteLine("1- при помощи имени процесса");
            Console.WriteLine("2- при помощи его ид");
            int choise = Convert.ToInt32(Console.ReadLine());
            if (choise == 1)
            {
                Console.WriteLine("Ввидите имя процесса");

                string name = Console.ReadLine();
                Process process = System.Diagnostics.Process.Start(name);
                process.Kill();

                Console.WriteLine(process.ExitCode);
            }
            if (choise == 2)
            {
                Console.WriteLine("Ввидите Ид процесса");
                int a1 = Convert.ToInt32(Console.ReadLine());


                Process process1 = System.Diagnostics.Process.GetProcessById(a1);
                process1.Kill();
                Console.WriteLine(process1.ExitCode);
            }
            else
            {
                Console.WriteLine("выбирите конкретно между 1 и 2");
            }
        }
    }
}
