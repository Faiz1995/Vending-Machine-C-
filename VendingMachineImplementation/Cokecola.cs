using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineImplementation
{
    class Cokecola
    {
       public int [,] coke=new  int[7,7];
      public   int cokefinalstate=6;
     public  int currstate=0;
     public int cokecounter = 2;
        public Cokecola()
       {
            coke[0, 0] = 0;
            coke[0, 1] = 1;
            coke[0, 2] = 2;
            coke[0, 3] = 5;
            coke[1, 0] = 1;
            coke[1, 1] = 2;
            coke[1, 2] = 3;
            coke[1, 3] = 6;
            coke[2, 0] = 2;
            coke[2, 1] = 3;
            coke[2, 2] = 4;
            coke[2, 3] = 6;
            coke[3, 0] = 3;
            coke[3, 1] = 4;
            coke[3, 2] = 5;
            coke[3, 3] = 6;
            coke[4 ,0] = 4;
            coke[4, 1] = 5;
            coke[4, 2] = 6;
            coke[4, 3] = 6;
            coke[5, 0] = 5;
            coke[5, 1] = 6;
            coke[5, 2] = 6;
            coke[5, 3] = 6;
            coke[6, 0] = 6;
            coke[6, 1] = 6;
           coke[6, 2] = 6;
           coke[6, 3] = 6;
         
        }
        public int  Ttable(int state, int input,int [,]coke)
        

        {
            return coke[state,input];
        }

    }
}
