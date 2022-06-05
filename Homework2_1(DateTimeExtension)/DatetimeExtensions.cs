using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2_1_DateTimeExtension_
{
    public static class DatetimeExtensions
    {
        public static string Ago(this DateTime time)
        {
            var now = DateTime.Now;
            Console.WriteLine(time );

        }
    }
}
