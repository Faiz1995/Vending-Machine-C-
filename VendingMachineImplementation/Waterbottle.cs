using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineImplementation
{
    class Waterbottle
    {
        public int[,] Bottle = new int[10, 10];
        public int Bottlefinalstate = 4;
        public int currstate = 0;
        public int Bottlecounter = 2;
        public Waterbottle()
        {
            Bottle[0, 0] = 0;
            Bottle[0, 1] = 1;
            Bottle[0, 2] = 2;
            Bottle[0, 3] = 4;
            Bottle[1, 0] = 1;
            Bottle[1, 1] = 2;
            Bottle[1, 2] = 3;
            Bottle[1, 3] = 4;
            Bottle[2, 0] = 2;
            Bottle[2, 1] = 3;
            Bottle[2, 2] = 4;
            Bottle[2, 3] = 4;
            Bottle[3, 0] = 3;
            Bottle[3, 1] = 4;
            Bottle[3, 2] = 4;
            Bottle[3, 3] = 4;
            Bottle[4, 0] = 4;
            Bottle[4, 1] = 4;
            Bottle[4, 2] = 4;
            Bottle[4, 3] = 4;

        }

        public int Ttable(int state, int input, int[,] Bottle)
        {
            return Bottle[state, input];
        }
    }
}
