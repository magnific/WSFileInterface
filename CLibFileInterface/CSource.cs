using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLibFileManagement;
namespace CLibFileInterface
{
    public class CSource
    {
        private bool l_newFile = true;
        public bool HasNewFile(CFile file)
        {
            return l_newFile;
        }
    }
}
