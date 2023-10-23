using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hospital_Sanin_Polupan.ClassHelper
{
     public static class EfClass
    {
        public static Entities1 Context { get; } = new Entities1();
    }
}
