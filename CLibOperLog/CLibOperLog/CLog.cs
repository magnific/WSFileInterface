using System;
using log4net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLibOperLog
{
    public class CLog
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        
        public void AddErrorLine(string objectname,Exception e)
        {
            log.Error(objectname, e);
        }
        public void AddErrorLine(string line)
        {
            log.Error(line);
        }
        public void Add_WarnLine(string line)
        {
            log.Warn(line);            
        }

        public void Add_DebugLine(string line)
        {
            log.Debug(line);
        }

        public void Add_Context(string line)
        {
            // Push a message on to the Nested Diagnostic Context stack
            using (log4net.NDC.Push("NDC_Message"))
            {
                log.Warn("This should have an NDC message");
                // Set a Mapped Diagnostic Context value  
                MDC.Set("auth", "auth-none");
                log.Warn("This should have an MDC message for the key 'auth'");
            } // The NDC message is popped off the stack at the end of the using {} block
        }
        public void Add_InfoLine(string line)
        {
            if (log.IsInfoEnabled) log.Info(line);
        }

    }
}
