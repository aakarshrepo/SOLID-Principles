using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Principles.LiskovSubstitution
{
    public class SqlFileManager
    {
        public List<ILoad> allFiles { get; set; }
        public List<IWrite> writeFiles { get; set; }

        public string GetTextFromFiles()
        {
            StringBuilder objStrBuilder = new StringBuilder();
            foreach (var objFile in allFiles)
            {
                objStrBuilder.Append(objFile.loadText());
            }
            return objStrBuilder.ToString();
        }
        public void SaveTextIntoFiles()
        {
            foreach (var objFile in writeFiles)
            {
                //if (!(objFile is ReadOnlyFile))
                    objFile.saveText();
            }
        }
    }
}
