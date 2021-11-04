using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeHome1_OOP_Lab
{
    class CalculateClass
    {
        // Singleton for CalculateClass
        private CalculateClass() { }

        private static CalculateClass instance = null;
        public static CalculateClass Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CalculateClass();
                }
                return instance;
            }
        }
        // end of Singleton for CalculateClass
        public double num1 { get; set; }
        public double num2 { get; set; }
        public double result { get; set; }

        public double SumC(double num1=0,double num2 = 0)
        {
        
            return num1 + num2;
        }
        /// This function is for substracting the two double numbers...
        public double SubC(double num1 = 0, double num2 = 0)
        {
            return num1 - num2;
        }
        /// This function is for Multpliction the two double numbers...

        public double MultC(double num1 = 0, double num2 = 0)
        {
            return num1 * num2;
        }
        /// This function is for divistion the two double numbers...
        public double DivC(double num1 = 0, double num2 = 1)
        {
            if (num2 == 0)
                throw new DivideByZeroException("Divide by zero!");
            else
                return num1 / num2;
        }
    }
}
