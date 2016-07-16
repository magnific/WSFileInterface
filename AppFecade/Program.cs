using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLibFileInterface;
using CLibOperLog;

namespace AppFecade
{
    class Program
    {
        static void Main(string[] args)
        {
            CHandLog l_log = new CHandLog();
            CFSynchronize l_Synch = new CFSynchronize();
            l_Synch.Synchonize(l_log);
            // waiting
            Console.ReadKey();
            l_log.Flush();
        }
    }
}
