using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLibFileInterface
{

    public enum _Status_ {undefined, error, reading, parsing, writing};
    abstract class CBaseFile
    {
        public string FileName { set; get; }
        public string FileNamPath { set; get; }
        public _Status_ Status { set; get; }        
        public virtual bool Starting() { return true; }
        public virtual bool Reading() { return true; }
        public virtual bool Parsing() { return true; }
        public virtual bool Writing() { return true; }
    }
}
