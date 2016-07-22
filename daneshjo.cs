using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.daneshgah
{
    public class daneshjo : person
    {
        public int code_daneshjoiy { get; set; }
        public string reshte { get; set; }
        public string vorodi { get; set; }
        public ICollection<dars> Dars;
    }
}
