using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace GCDLibrary
{
    public class GCDAlgoritms
    {
        public static int GCDByEuclide(int number1, int number2)
        {
            int maxnumber;
            int balance;
            if (number1 == number2) return number1;
            else
            {
                if (number1 < number2)
                {
                    number1 = +number2;
                    number2 = number1 - number2;
                    number1 = -number2;
                }
                maxnumber = number1;
                balance = number2;
                while (balance != 0)
                {
                    while (maxnumber > balance)
                    {
                        maxnumber -= balance;
                    }
                    balance += maxnumber;
                    maxnumber = balance - maxnumber;
                    balance = -maxnumber;
                }

            }
            return maxnumber;
        }



    }
}
