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
        }

        public CSettings LoadSettings(CHandLog log)
        {
            CSettings l_conf = new CSettings();
            return l_conf;
        }
        // Moving files 
        private bool MoveFile()
        {
            CDirectoryAccess l_ProcessFile = new CDirectoryAccess();
            // start with status file not defined
            l_ProcessFile.Status = _Status_.undefined;
            Console.WriteLine("Moving File");
            CActionClass l_Watching = Chaining();
            l_Watching.ProcessRequest(l_ProcessFile);
            return false;
        }

        private  CActionClass Chaining()
        {
            // define process actions 
            CActionClass l_Watching = new CWatching();
            CActionClass l_Reading = new CReading();
            CActionClass l_Parsing = new CParsing();
            CActionClass l_Writing = new CWriting();
            // chaining actions
            l_Watching.SetNextAction(l_Reading);
            l_Reading.SetNextAction(l_Parsing);
            l_Parsing.SetNextAction(l_Writing);
            l_Writing.SetNextAction(l_Watching);
            // set object log 
            l_Watching.Log = l_log;
            l_Reading.Log = l_log;
            l_Parsing.Log = l_log;
            l_Writing.Log = l_log;

            return l_Watching;
        }
    }
}
