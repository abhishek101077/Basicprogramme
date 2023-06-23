using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    public abstract class Abstract
    {
      
            public abstract void sport();
            public void Displayname()
            {
                Console.WriteLine("The best sport is football");
            }
        }
        public class bat : Abstract
        {
            public override void sport()
            {
                Console.WriteLine("The best sport is chess");
            }
        }
    }

