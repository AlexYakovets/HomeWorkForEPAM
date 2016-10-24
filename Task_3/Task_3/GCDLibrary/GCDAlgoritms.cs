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
        public static int GCDByEuclide(int number1, int number2,out string time)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Thread.Sleep(1000);
            

            // Format and display the TimeSpan value.
            
            int maxnumber;
            int balance;
            if (number1 == number2) balance=number1;
            else
            {
                if (number1 < number2)
                {
                    number1 +=number2;
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
            long ts = stopWatch.ElapsedMilliseconds;
            //time = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",ts.Hours, ts.Minutes, ts.Seconds,ts.Milliseconds / 10);
            time = Convert.ToString(ts) ;
            return balance;
        }



    }
}
