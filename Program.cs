using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var s = new daneshgah.daneshjo
            {
                code = 8558651,
                code_daneshjoiy = 900151913,
                name = "sepehr",
                family = "iqani",
                Dars = new List<daneshgah.dars>
                {
                    new daneshgah.dars
                    {
                        dars_id = 23,
                        dars_name = "fizik",
                        vahed = 3,
                    },
                    new daneshgah.dars
                    {
                        dars_id = 24,
                        dars_name = "riyazi",
                        vahed = 3,
                    },
                }
            };

            Console.WriteLine(s.name);
            Console.WriteLine(s.family);
            Console.WriteLine(s.code_daneshjoiy);
            Console.WriteLine(s.Dars.Count);
            Console.WriteLine(s.Dars.Sum(x=>x.vahed));
            Console.ReadLine();
        }
    }
}

