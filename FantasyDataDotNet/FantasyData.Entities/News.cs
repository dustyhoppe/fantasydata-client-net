using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.Entities
{
  public class News : List<NewsItem>
  {
  }

  public class NewsItem
  {
    public string Content { get; set; }
    public int NewsID { get; set; }
    public int PlayerID { get; set; }
    public string Source { get; set; }
    public string Team { get; set; }
    public string TermsOfUse { get; set; }
    public string Title { get; set; }
    public string Url { get; set; }
    public DateTime Updated { get; set; }
  }
}
