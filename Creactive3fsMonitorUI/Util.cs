using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Creactive.Windows._3fs
{
    class Util
    {
        public enum FileType
        {
            NOT_EXIST,
            FILE,
            DIRECTORY
        }

        public static FileType getFileType(String path)
        {
            if (File.Exists(path))
            {
                return FileType.FILE;
            }
            else if (Directory.Exists(path))
            {
                return FileType.DIRECTORY;
            }
            else
            {
                return FileType.NOT_EXIST;
            }
        }
    }
}
