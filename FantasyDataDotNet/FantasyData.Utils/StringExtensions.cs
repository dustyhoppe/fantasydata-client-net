using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.Utils
{
    public static class StringExtensions
    {
      public static string ToApiDate(this DateTime date)
      {
        return string.Format("{0}-{1}-{2:D2}", date.Year, date.ToShortMonthName().ToUpper(), date.Day);
      }
    }
}
