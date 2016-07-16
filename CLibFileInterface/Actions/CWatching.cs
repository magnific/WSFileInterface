using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLibFileInterface
{
    class CWatching : CActionClass
    {
        public override void ProcessRequest(CBaseFile file)
        {
            //throw new NotImplementedException();
            l_NextAction.ProcessRequest(file);
        }

    }
}
