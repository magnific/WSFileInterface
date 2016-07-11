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
        public void AddLine(DataSet log_values)
        {
            string l_file = "LogFile.xml";
            FileStream l_Stream = new FileStream(l_file,FileMode.Append);
            log_values.WriteXml(l_Stream);
        }
    }
}
