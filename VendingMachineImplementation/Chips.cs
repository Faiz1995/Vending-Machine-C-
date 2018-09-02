using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineImplementation
{
    class Chips
    {
        public int[,] chips = new int[7, 7];
        public int Chipsfinalstate = 5;
        public int currstate = 0;
        public int Chipscounter = 2;
        public Chips()
        {
            chips[0, 0] = 0;
            chips[0, 1] = 1;
            chips[0, 2] = 2;
            chips[0, 3] = 5;
            chips[1, 0] = 1;
            chips[1, 1] = 2;
            chips[1, 2] = 3;
            chips[1, 3] = 5;
            chips[2, 0] = 2;
            chips[2, 1] = 3;
            chips[2, 2] = 4;
            chips[2, 3] = 5;
            chips[3, 0] = 3;
            chips[3, 1] = 4;
            chips[3, 2] = 5;
            chips[3, 3] = 5;
            chips[4, 0] = 4;
            chips[4, 1] = 5;
            chips[4, 2] = 5;
            chips[4, 3] = 5;
            chips[5, 0] = 5;
            chips[5, 1] = 5;
            chips[5, 2] = 5;
            chips[5, 3] = 5;

        } 
        
        public int  Ttable(int state, int input,int [,]chips)
        

        {
            return chips[state,input];
        }


        }
    }
