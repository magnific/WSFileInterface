using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLibOperLog;

namespace CLibFileInterface
{
    public enum _Setting  {Restore, Save};
    public class CFSynchronize
    {

        private CFileReader l_reader = new CFileReader();
        private CFileWriter l_writer = new CFileWriter();
        private CFileMonitoring l_monitor = new CFileMonitoring();
        private CSettings l_settings = new CSettings();
        public void Synchonize(CHandLog log)
        {
            
        }
        public bool MoveFile()
        {
            return false;
        }
    }
}
