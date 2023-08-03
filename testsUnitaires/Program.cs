using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testsUnitaires
{
    public class Program
    {
        static void Main(string[] args)
        {
            int resultat = MyMath.Addition(2, 2);
            Fortune fortune = new Fortune();
            string aleat = fortune.phrase(3);
        }
    }
}
 