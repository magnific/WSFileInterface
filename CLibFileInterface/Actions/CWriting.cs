using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLibFileInterface
{
    class CWriting : CActionClass
    {
        public override void ProcessRequest(CBaseFile file)
        {
            l_NextAction.ProcessRequest(file);
        }
    }
}
