using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.LiskovSubstitution
{
    public class File : ILoad, IWrite
    {
        public string loadText()
        {
            /* Code to read text from file */
            return string.Empty;
        }
        public void saveText()
        {
            /* Code to save text into file */
        }
    }
}
