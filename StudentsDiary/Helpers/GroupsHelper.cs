using System.Collections.Generic;

namespace StudentsDiary
{
    internal class GroupsHelper
    {
        public static List<Group> GetGroups(string defaultGroup)
        {
            return new List<Group>
            {
                new Group(0, defaultGroup),
                new Group(1, "1a"),
                new Group(2, "1b")
            };
        }
    }
}
