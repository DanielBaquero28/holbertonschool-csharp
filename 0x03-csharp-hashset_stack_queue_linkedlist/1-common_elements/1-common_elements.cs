using System;
using System.Collections.Generic;
class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        var hashSet1 = new HashSet<int>(list1);
        var hashSet2 = new HashSet<int>(list2);
        hashSet1.IntersectWith(hashSet2);

        var sortedHash = new SortedSet<int>(hashSet1);
        var newList = new List<int>(sortedHash);

        return(newList);
    }
}