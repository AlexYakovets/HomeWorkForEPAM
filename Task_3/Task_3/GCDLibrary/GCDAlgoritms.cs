using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace GCDLibrary
{
    public class GCDAlgoritms
    {
        public static int GCDByEuclide(int number1, int number2, out long runTime)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            // Format and display the TimeSpan value.

            int maxnumber;
            int balance;
            if (number1 == number2) balance = number1;
            else
            {
                if (number1 < number2)
                {
                    number1 += number2;
                    number2 = number1 - number2;
                    number1 -= number2;
                }
                maxnumber = number1;
                balance = number2;
                while (balance != 0)
                {
                    while (maxnumber > balance)
                    {
                        maxnumber -= balance;
                    }
                    if (balance == maxnumber) break;

                    balance += maxnumber;
                    maxnumber = balance - maxnumber;
                    balance -= maxnumber;


                }

            }
            stopWatch.Stop();
            runTime = stopWatch.ElapsedTicks;

            return balance;
        }

        public static int GCDByStein(int number1, int number2,out long runTime)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int k = 1;
            while ((number1 != 0) && (number2 != 0))
            {
                while ((number1%2 == 0) && (number2%2 == 0))
                {
                    number1 /= 2;
                    number2 /= 2;
                    k *= 2;
                }
                while (number1%2 == 0) number1 /= 2;
                while (number2%2 == 0) number2 /= 2;
                if (number1 >= number2) number1 -= number2;
                else number2 -= number1;
            }
            stopWatch.Stop();
            runTime = stopWatch.ElapsedTicks;
            //time = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",ts.Hours, ts.Minutes, ts.Seconds,ts.Milliseconds / 10);

            return number2*k;
        }

    }


}
