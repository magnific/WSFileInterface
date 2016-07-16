
namespace CLibFileInterface
{
    abstract class CActionClass
    {
        protected CActionClass l_NextAction;

        public void SetNextAction(CActionClass next)
        {
            l_NextAction = next;
        }

        public abstract void ProcessRequest(CBaseFile file);
    }
}
