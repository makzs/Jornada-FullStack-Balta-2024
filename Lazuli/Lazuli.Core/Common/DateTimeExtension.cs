using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lazuli.Core.Common
{
    public static class DatetimeExtension
    {
        public static DateTime GetFirstDay(this DateTime date, int? year = null, int? month = null)
            => new(year ?? date.Year, month ?? date.Month, day: 1);
            
        public static DateTime GetLasttDay(this DateTime date, int? year = null, int? month = null)
            => new DateTime(
                year ?? date.Year,
                month ?? date.Month,
                day: 1)
            .AddMonths(1)
            .AddDays(-1);
            
    }
}