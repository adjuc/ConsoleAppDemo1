﻿using System;

namespace ConsoleAppDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello ConsoleAppDemo1!"); 
            CalculateSumClass C1 = new CalculateSumClass();
            int sum = C1.CalculateSumOf8(1,2,3,4,5,6,7,8);
            Console.WriteLine("Simple sum is " + sum.ToString()); 
            Console.WriteLine("SumClass sum of 11: " + C1.CalculateSumOf11(1,2,3,4,5,6,7,8,9,10, 11).ToString()); 
            ICalculate iCal = new Calculate();
            Console.Write("ProductOf2:" + iCal.CalculateProductOf2(2,4).ToString() + "\n");
            Console.Write("ProductOf4:" + iCal.CalculateProductOf4(1,2,3,4).ToString() + "\n");
            Console.Write("DivisionOf 8/4:" + iCal.CalculateDivision(8, 4).ToString()+ "\n");
            Console.Write("SumOf8:" + iCal.CalculateSumOf8(1,2,3,4,5,6,7,8).ToString() + "\n");
            Console.Write("SumOf9:" + iCal.CalculateSumOf9(1,2,3,4,5,6,7,8,9).ToString() + "\n");
            Console.Write("SumOf10:" + iCal.CalculateSumOf10(1,2,3,4,5,6,7,8,9,10).ToString() + "\n");  
            LongMethodClass lc = new LongMethodClass();
            Console.Write(lc.GetLongString("LongString: ") + "\n");          
            Console.Write("End of procedure\n");
        }
    }
}