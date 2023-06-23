using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    public class mathodoverriding
    {

        public void sport()
        {

            Console.WriteLine("chess");
        }
        public class Rubik : mathodoverriding
        {
            public void sport()
            {
                Console.WriteLine("Basketball");
                Console.ReadLine();
            }
        }
    }
}
    

