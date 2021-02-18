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

/* Dictionary<int, List<string>> dict = GetBadgeDict();
 Badge badgeOne = new Badge(132, new List<string> { "A1", "B2", "A4" });
 Badge badgeTwo = new Badge(265, new List<string> { "A1", "A4", "B3" });
 Badge badgeThree = new Badge(112, new List<string> { "A3", "B5", "A1" });
 Badge badgeFour = new Badge(211, new List<string> { "A2", "B1", "A3" });

 AddBadgeToDict(badgeOne);
 AddBadgeToDict(badgeTwo);
 AddBadgeToDict(badgeThree);
 AddBadgeToDict(badgeFour);*/