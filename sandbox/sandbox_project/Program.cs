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

}
    