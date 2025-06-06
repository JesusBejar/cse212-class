using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

public partial class Program
{
    static void Main(string[] args)
    {
        // This project is here for you to use as a "Sandbox" to play around
        // with any code or ideas you have that do not directly apply to
        // one of your projects.

        Console.WriteLine("Hello Sandbox World!");

    }

    // Test cases:
    
    // 1. Trace.Assert(FindIntersection(list1, list2), "there are no intersections, intersectionNums is empty"); // true
    // var result = FindIntersection(list1, list2);
    // Console.WriteLine(result);
    // 2. Trace.Assert(FindIntersection(list1, list2), "they are all intersections, list1 and list2 are empty"); // true
    // var result = FindIntersection(list1, list2);
    // Console.WriteLine(result);
    // 3. Trace.Assert(FindUnion(list1, list2), "union is complete"); // true
    // var result = FindIntersection(list1, list2);
    // Console.WriteLine(result);



    // O(n) because it depends on the size of the set
    static List<int> FindIntersection(List<int> list1, List<int> list2)
    {
        // intersection is a list of items that are in list1 and list2
        var intersectionNums = new List<int>();
        // list1 and list2 are parameters
        var set2 = new HashSet<int>(list2);
        
        foreach (int element in list1)
        {
            // check if the element is in list2 and also not in intersectionNums (double check)
            if (set2.Contains(element) && !intersectionNums.Contains(element))
            {
                intersectionNums.Add(element);
            }
        }
        
        return intersectionNums;
    }
    // O(2n) because both foreach loops depend on the size of the set
    static List<int> FindUnion(List<int> list1, List<int> list2)
    {
        // true list
        var union = new List<int>();
        // check list
        var seen = new HashSet<int>();
        // loops not nested
        foreach (int element in list1)
        {
            // adding to hashset to detects then prohibits duplicates, returns true or false based on if it exists in hashset
            if (seen.Add(element))
            {
                union.Add(element);
            }
        }
        
            foreach (int element in list2)
        {
            if (seen.Add(element))
            {
                union.Add(element);
            }
        }
        
        return union;
    }

}
    