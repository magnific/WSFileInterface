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
            try
            {
                // initial status.
                if (file.Status == _Status_.undefined)
                {
                    Log.Logger.Add_InfoLine(string.Format("Wating reading file on path {0}.", file.FileNamPath));                    
                    file.Status = _Status_.undefined;
                    l_NextAction.ProcessRequest(file);
                }
                else
                {
                    Log.Logger.Add_InfoLine(string.Format("End end processing file {0}",file.FileNamPath));
                }
            }
            catch (Exception e)
            {
                Log.Logger.AddErrorLine(string.Format("Error watching file {0}",file.FileName), e);
                throw;
            }
        }
    }
}
