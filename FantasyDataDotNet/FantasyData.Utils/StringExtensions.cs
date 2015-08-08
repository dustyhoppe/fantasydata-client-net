using FantasyData.NFL.Entities;
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

        public static string ToSeason(this int year, SeasonTypes seasonType)
        {
            var seasonString = string.Empty;

            switch (seasonType)
            {
                case SeasonTypes.REGULAR:
                    seasonString = "REG";
                    break;
                case SeasonTypes.PRE:
                    seasonString = "PRE";
                    break;
                case SeasonTypes.POST:
                    seasonString = "POST";
                    break;
                default:
                    seasonString = "REG";
                    break;
            }

            return string.Format("{0}{1}", year, seasonString);
        }
    }
}
