using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLibOperLog;
using System.Data;

namespace CLibFileInterface
{
    public enum _Setting  {Restore, Save};
    public class CFSynchronize
    {
               
        private CSettings l_settings = null;
        CHandLog l_log = null;
        public void Synchonize(CHandLog log)
        {
            l_log = log;
            // add settings
            l_settings = LoadSettings(log);

            MoveFile();
            log.AddLine(300, "New Line Test");
        }

        public CSettings LoadSettings(CHandLog log)
        {
            CSettings l_conf = new CSettings();

            return l_conf;
        }
        private bool MoveFile()
        {

            Console.WriteLine("Moving File");
            CActionClass l_Chain = Chaining();
            CBaseFile l_FileAccess= null;
            l_Chain.ProcessRequest(l_FileAccess);
            return false;
        }

        private  CActionClass Chaining()
        {
            CActionClass l_Watching = new CWatching();
            CActionClass l_Reading = new CReading();
            CActionClass l_Parsing = new CParsing();
            CActionClass l_Writing = new CWriting();
            l_Watching.SetNextAction(l_Reading);
            l_Reading.SetNextAction(l_Parsing);
            l_Parsing.SetNextAction(l_Writing);
            l_Writing.SetNextAction(l_Watching);

            return l_Watching;
        }
    }
}
