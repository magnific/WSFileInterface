using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLibFileInterface.File_Base
{
    class CDirectoryAccess : CBaseFile
    {
        public override bool Reading()
        {
            return base.Reading();
        }

        public override bool Parsing()
        {
            return base.Parsing();
        }

        public override bool Starting()
        {
            return base.Starting();
        }
        
        public override bool Writing()
        {
            return base.Writing();
        }

        //private string l_filename = "test.txt";
        //private string l_sourcePath = @"c:\PublicFolder";
        //private string l_targetPath = @"c:\PublicFolder\Detino";

        //public override void Move()
        //{
        //    string l_sourceFile = Path.Combine(l_sourcePath, l_filename);
        //    string l_targetFile = Path.Combine(l_targetPath, l_filename);
        //    if (Directory.Exists(l_targetPath))
        //    {
        //        Directory.CreateDirectory(l_targetPath);
        //    }

        //    File.Move(l_sourceFile, l_targetPath);
        //    //throw new NotImplementedException();
        //}
    }
}
