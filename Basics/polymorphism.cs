using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    public class polymorphism
    {

        public void game(string football, string cricket)
        {
            Console.WriteLine("Total player in football" + football);
            Console.WriteLine("Total player in cricket" + cricket);
        }

        public void game(int football, int cricket, int chess)

        {
            Console.WriteLine("Total player in football:" + football);
            Console.WriteLine("Total player in cricket:" + cricket);
            Console.WriteLine("Total player in chess:" + chess);
            Console.ReadLine();

        }
    }
}

