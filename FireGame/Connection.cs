using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireGame
{
    
   public class Connection
    {
        //object of random class that is used generate the random using the method of the random class
        Random instance = new Random();

        //this method is used to find the result of the game 
        public void result(int y)
        {
            Random random_Object = new Random();
            int z = random_Object.Next(1, 3);
            int rslt = 0;
            //compare the no once with the random clk 
            if (y == z)
            {
                rslt++;
              
            }

        }

    }
}
