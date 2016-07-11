using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CLibFileManagement
{
    class CDirectoryAccess : CFileDataAccess
    {

        private string l_filename = "test.txt";
        private string l_sourcePath = @"c:\PublicFolder";
        private string l_targetPath = @"c:\PublicFolder\Detino";

        public override void Move()
        {
            string l_sourceFile = Path.Combine(l_sourcePath, l_filename);
            string l_targetFile = Path.Combine(l_targetPath, l_filename);
            if (Directory.Exists(l_targetPath))
            {
                Directory.CreateDirectory(l_targetPath);
            }

            File.Move(l_sourceFile, l_targetPath);
            //throw new NotImplementedException();
        }

    }
}
