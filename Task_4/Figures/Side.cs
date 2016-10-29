﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
   public class Side
    {
        public Point aPoint{get; set;}
        public Point bPoint{get; set;}



        public Side(Point a, Point b)
        {
            aPoint = a;
            bPoint = b;
        }

       public double Length()
       {
           return Math.Sqrt(Math.Abs(aPoint.X - bPoint.X) + Math.Abs(aPoint.Y - bPoint.Y));
       }
    }
}