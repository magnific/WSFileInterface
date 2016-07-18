using System;
using System.Data;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLibOperLog
{
    public class CHandLog
    {        
        public CHandLog()
        {
            Logger = new CLog();
        }
        public CLog Logger { set; get; }        
        // additional funcions will be added
    }
}

