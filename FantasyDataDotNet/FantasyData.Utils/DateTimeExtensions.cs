using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.Utils
{
  public static class DateTimeExtensions
  {
    public static string ToShortMonthName(this DateTime date)
    {
      return CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(date.Month);
    }

    public static string ToMonthName(this DateTime date)
    {
      return CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(date.Month);
    }
  }
}
