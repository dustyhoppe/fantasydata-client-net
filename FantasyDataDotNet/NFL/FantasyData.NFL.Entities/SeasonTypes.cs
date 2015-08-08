using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.NFL.Entities
{
    public enum SeasonTypes
    {
        [EnumMember]
        PRE,

        [EnumMember]
        REGULAR,

        [EnumMember]
        POST
    }
}
