using CLibOperLog;
namespace CLibFileInterface
{
    abstract class CActionClass
    {
        protected CActionClass l_NextAction;
        public CHandLog Log { set; get; }
        public void SetNextAction(CActionClass next)
        {
            l_NextAction = next;
        }
        public abstract void ProcessRequest(CBaseFile file);
    }
}
