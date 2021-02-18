using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadgeRepo
{
    public class BadgeRepository
    {
        readonly private Dictionary<int, List<string>> _badgeDict = new Dictionary<int, List<string>>();

        public void AddBadge(int badgeID, List<string> doorNames)
        {
            _badgeDict.Add(badgeID, doorNames);
        }

        public Badge GetBadgeByID(int badgeID)
        {
            Badge badge = new Badge(badgeID, _badgeDict[badgeID]);
            return badge;
        }

        public void AddDoorAccess(int badgeID, string doorID)
        {
            _badgeDict[badgeID].Add(doorID);
        }

        public void RemoveDoorAccess(int badgeID, string doorID)
        {
            _badgeDict[badgeID].Remove(doorID);
        }

        public Dictionary<int, List<string>> SeeAllBadges()
        {
            return _badgeDict;
        }


    }
}

