using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineImplementation
{
    class Pepsi
    {
        public int [,] pepsi=new  int[7,7];
      public   int pepsifinalstate=6;
     public  int currstate=0;
     public int pepsicounter = 2;
        public Pepsi()
       {
            pepsi[0, 0] = 0;
            pepsi[0, 1] = 1;
            pepsi[0, 2] = 2;
            pepsi[0, 3] = 5;
            pepsi[1, 0] = 1;
            pepsi[1, 1] = 2;
            pepsi[1, 2] = 3;
            pepsi[1, 3] = 6;
            pepsi[2, 0] = 2;
            pepsi[2, 1] = 3;
            pepsi[2, 2] = 4;
            pepsi[2, 3] = 6;
            pepsi[3, 0] = 3;
            pepsi[3, 1] = 4;
            pepsi[3, 2] = 5;
            pepsi[3, 3] = 6;
            pepsi[4 ,0] = 4;
            pepsi[4, 1] = 5;
            pepsi[4, 2] = 6;
            pepsi[4, 3] = 6;
            pepsi[5, 0] = 5;
            pepsi[5, 1] = 6;
            pepsi[5, 2] = 6;
            pepsi[5, 3] = 6;
            pepsi[6, 0] = 6;
            pepsi[6, 1] = 6;
           pepsi[6, 2] = 6;
           pepsi[6, 3] = 6;
         
        }
        public int  Ttable(int state, int input,int [,]pepsi)
        

        {
            return pepsi[state,input];
        }

    }
}
