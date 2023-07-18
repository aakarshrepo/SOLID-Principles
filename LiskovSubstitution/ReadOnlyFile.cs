using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.LiskovSubstitution
{
    class ReadOnlyFile : ILoad //File
    {
        public string filePath { get; set; }
        public string fileText { get; set; }
        public string loadText()
        {
            return "Read only file";
        }
    //    public void saveText()
    //    {
    //        throw new IOException("Can't Save");
    //    }
    }
}
