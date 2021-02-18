using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadgeRepo
{
    public class Badge
    {
        public int BadgeId { get; set; }
        public List<string> DoorNames { get; set; }

        public Badge() { }
        public Badge(int badgeId, List<string> doorNames)
        {
            BadgeId = badgeId;
            DoorNames = doorNames;
        }
    }
}
