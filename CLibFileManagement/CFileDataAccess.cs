using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLibFileManagement
{
    abstract class CFileDataAccess
    {
        protected string l_connString;
        public virtual void Connect(string connstring)
        {
            l_connString = connstring;
        }
        public abstract void Move();
    }
}
