using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLibFileInterface
{
    class CReading : CActionClass
    {    
        public override void ProcessRequest(CBaseFile file)
        {
            try
            {
                Log.Logger.Add_InfoLine(string.Format("Reading file {0}",file.FileName));
                file.Status = _Status_.reading;
                l_NextAction.ProcessRequest(file);                
            }
            catch (Exception e)
            {
                Log.Logger.AddErrorLine(string.Format("Reading file {0} with error",file.FileName), e);
            }
            
        }
    }
}
