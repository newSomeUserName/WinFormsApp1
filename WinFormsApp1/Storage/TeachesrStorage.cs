using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Storage
{
    internal static class TeachesrStorage
    {

        static public List<string> Names { get; set; }

        static TeachesrStorage()
        {
            Names= new List<string>() { "озерова", "тупикина", "кригер", "тельянц", "тахиров"};  
        }
    }
}
