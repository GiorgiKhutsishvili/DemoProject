using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Specialized;


namespace TaskScheduler
{
    class Program
    {        
        private static void Main(string[] args)
        {
            CronNET.CronManager.Start();
            Console.ReadLine();
        }
    }

}
