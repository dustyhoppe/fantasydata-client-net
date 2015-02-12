using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData
{
  public interface IFantasyDataEntity
  {
    /// <summary>
    /// The Id of the entity.
    /// </summary>
    int Id { get; }
  }
}
