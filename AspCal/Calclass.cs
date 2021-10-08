using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspCal
{
    public class Calculator
    {
        public static int Add(int val1, int val2)
        {
            int result = val1 + val2;
            return result;

        }
        public static int Sub(int val1, int val2)
        {
            int result = val1 - val2;
            return result;

        }
        public static int Mul(int val1, int val2)
        {
            int result = val1 * val2;
            return result;

        }
        public static int Div(int val1, int val2)
        {
            int result = val1 / val2;
            return result;

        }

    }
}