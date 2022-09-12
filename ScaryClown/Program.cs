using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScaryClown
{
    class Program
    {
        static void Main(string[] args)
        {
            IClown fingersTheClown = new ScaryScary("big red nose", 14);

            fingersTheClown.Honk();

            //IScaryClown iScaryClownReference = fingersTheClown;
            //iScaryClownReference.ScareLittleChildren();

            if (fingersTheClown is ScaryScary scaryClown)
                scaryClown.ScareLittleChildren();
        }
    }
}
