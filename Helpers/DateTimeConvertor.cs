using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    public static class DateTimeConvertor
    {
        public static string ToHijriDate(this DateTime time)
        {
            var hijri = new HijriCalendar();
            return hijri.GetYear(time) + "/" + hijri.GetMonth(time) + "/" + hijri.GetDayOfMonth(time);
        }
    }
}
