using System;
using sys = System;
using System.Collections.Generic;
using System.Text;

namespace A2019.DateTime
{
    public class DateTime
    {
        public sys.DateTime Parse(string date)
        {
            return sys.DateTime.Parse(date);
        }

        public string DateDiff(string date1, string date2, string format = "TotalDays")
        {
            sys.DateTime d1 = sys.DateTime.Parse(date1);
            sys.DateTime d2 = sys.DateTime.Parse(date2);
            sys.TimeSpan diff = d2.Subtract(d1);

            return diff.GetType().GetProperty(format).GetValue(diff, null).ToString();

        }

        public string DateDiff(sys.DateTime date1, sys.DateTime date2, string format = "TotalDays")
        {
            sys.TimeSpan diff = date2.Subtract(date1);
            string form = diff.GetType().GetProperty(format).GetValue(diff, null).ToString();
            return form;
        }

        public string DateTimeInfo(sys.DateTime date, string property)
        {
            return date.GetType().GetProperty(property).GetValue(date, null).ToString();
        }

    }
}
