using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineImplementation
{
    class Popcorn
    {   
        
      public int [,] popcorn = new  int[11,11];
      public   int Popcornfinalstate=10;
      public  int currstate=0;
      public int Popcorncounter = 2;
        public Popcorn()
       {
            popcorn[0, 0] = 0;
            popcorn[0, 1] = 1;
            popcorn[0, 2] = 2;
            popcorn[0, 3] = 5;
            popcorn[1, 0] = 1;
            popcorn[1, 1] = 2;
            popcorn[1, 2] = 3;
            popcorn[1, 3] = 6;
            popcorn[2, 0] = 2;
            popcorn[2, 1] = 3;
            popcorn[2, 2] = 4;
            popcorn[2, 3] = 7;
            popcorn[3, 0] = 3;
            popcorn[3, 1] = 4;
            popcorn[3, 2] = 5;
            popcorn[3, 3] = 8;
            popcorn[4 ,0] = 4;
            popcorn[4, 1] = 5;
            popcorn[4, 2] = 6;
            popcorn[4, 3] = 9;
            popcorn[5, 0] = 5;
            popcorn[5, 1] = 6;
            popcorn[5, 2] = 7;
            popcorn[5, 3] = 10;
            popcorn[6, 0] = 6;
            popcorn[6, 1] = 7;
            popcorn[6, 2] = 8;
            popcorn[6, 3] = 10;
            popcorn[7, 0] = 7;
            popcorn[7, 1] = 8;
            popcorn[7, 2] = 9;
            popcorn[7, 3] = 10;
            popcorn[8, 0] = 8;
            popcorn[8, 1] = 9;
            popcorn[8, 2] = 10;
            popcorn[8, 3] = 10;
            popcorn[9, 0] = 9;
            popcorn[9, 1] = 10;
            popcorn[9, 2] = 10;
            popcorn[9, 3] = 10;
            popcorn[10, 0] = 10;
            popcorn[10, 1] = 10;
            popcorn[10, 2] = 10;
            popcorn[10, 3] = 10;
            




         
        }

        
        public int  Ttable(int state, int input,int [,]popcorn)
        

        {
            return popcorn[state,input];
        }

  
    }
}
