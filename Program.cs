﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable_Value_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = null;
            //int number = null;
            int num; // int num = 0 ;

            Nullable<int> num3 = new Nullable<int>();
            num3 = null;
            int? num12 = null;
            Console.WriteLine(num12.HasValue);
            int? numew = num3;//همان تعریف  نال ایبل بودن است
            if (numew.HasValue)
            {
                Console.Write(numew);
            }
            else
            {
                Console.WriteLine(numew.GetValueOrDefault());//با این کار اکسپشن رخ نمی دهد مقدار عددی نال را برمیگرداند = 0
            }
            Console.ReadLine();





        }
    }
}
