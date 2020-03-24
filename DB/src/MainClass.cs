using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaoGest.src
{
    class MainClass
    {
        public static void Main()
        {
            DbConnect dC= new DbConnect();
            String s = "CaoSeguro";
            dC.Update(s);
        }
    }
}
