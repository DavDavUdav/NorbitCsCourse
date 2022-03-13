using System;

namespace ClassLibraryBmiWeight
{
    public class ClassBmiWeight
    {
        public static double BmiCount(double weight, double height)
        {
            return  Math.Round(weight / Math.Pow(height, 2), 1) ;
        }

        
    }
}
