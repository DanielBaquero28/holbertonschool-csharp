using System;
using System.Collections.Generic;
class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        var hashSet1 = new HashSet<int>(list1);
        var hashSet2 = new HashSet<int>(list2);
        var tmpSet = new HashSet<int>(hashSet1);

        hashSet1.ExceptWith(hashSet2);
        hashSet2.ExceptWith(tmpSet);
        hashSet1.UnionWith(hashSet2);

        var sortSet = new SortedSet<int>(hashSet1);
        var myList = new List<int>(sortSet);

        return(myList);

    }
}