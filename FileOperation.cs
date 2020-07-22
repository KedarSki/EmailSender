using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
   class FileOperation
    {
        public string getFile()
        {
            string text = System.IO.File.ReadAllText(@"EmailSent.txt");
            return text;
        }
    } 
}
