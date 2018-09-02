using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineImplementation
{
    class Coffee
    {
        public int [,] coffee = new  int[10,10];
      public   int coffeefinalstate=8;
      public  int currstate=0;
      public int coffeecounter = 2;
        public Coffee()
       {
            coffee[0, 0] = 0;
            coffee[0, 1] = 1;
            coffee[0, 2] = 2;
            coffee[0, 3] = 5;
            coffee[1, 0] = 1;
            coffee[1, 1] = 2;
            coffee[1, 2] = 3;
            coffee[1, 3] = 6;
            coffee[2, 0] = 2;
            coffee[2, 1] = 3;
            coffee[2, 2] = 4;
            coffee[2, 3] = 7;
            coffee[3, 0] = 3;
            coffee[3, 1] = 4;
            coffee[3, 2] = 5;
            coffee[3, 3] = 8;
            coffee[4 ,0] = 4;
            coffee[4, 1] = 5;
            coffee[4, 2] = 6;
            coffee[4, 3] = 8;
            coffee[5, 0] = 5;
            coffee[5, 1] = 6;
            coffee[5, 2] = 7;
            coffee[5, 3] = 8;
            coffee[6, 0] = 6;
            coffee[6, 1] = 7;
            coffee[6, 2] = 8;
            coffee[6, 3] = 8;
            coffee[7, 0] = 7;
            coffee[7, 1] = 8;
            coffee[7, 2] = 8;
            coffee[7, 3] = 8;
            coffee[8, 0] = 8;
            coffee[8, 1] = 8;
            coffee[8, 2] = 8;
            coffee[8, 3] = 8;
            




         
        }

        
        public int  Ttable(int state, int input,int [,]coffee)
        

        {
            return coffee[state,input];
        }

  
    }
    }

