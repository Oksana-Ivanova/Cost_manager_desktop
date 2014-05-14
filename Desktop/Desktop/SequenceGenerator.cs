using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop
{
    class SequenceGenerator
    {
        public static string GenerateUniqueString()
        {
            long secondsCount = DateTime.Now.DayOfYear * 24 + DateTime.Now.Hour;
            secondsCount = secondsCount * 60 + DateTime.Now.Minute;
            secondsCount = secondsCount * 60 + DateTime.Now.Second;
            secondsCount = secondsCount * 1000 + DateTime.Now.Millisecond;

            string resultString = secondsCount.ToString("X").ToLower();

            while (resultString.Length < 10)
            {
                resultString = "0" + resultString;
            }

            return resultString;
        }
    }
}
