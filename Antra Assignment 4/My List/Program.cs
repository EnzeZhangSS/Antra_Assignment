using System;

namespace My_List
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> Mlist = new MyList<string>();
            Mlist.Add("beef");
            Mlist.Add("chicken");
            Mlist.Add("lamb");
            if (Mlist.Contains("chicken"))
            {
                Console.WriteLine("Chicken is in the list.");
            }
            Mlist.Add("duck");
            Mlist.Add("pork");
            Mlist.Add("shrimp");
            Console.WriteLine($"The item {Mlist.Remove(4)} has been removed.");
            if(Mlist.Contains("pork") == false)
            {
                Console.WriteLine("Pork is not in the list.");
            }
            Mlist.InsertAt("fish", 0);
            Console.WriteLine($"The first item in the list is {Mlist.Find(0)}.");
            Mlist.DeleteAt(0);
            Console.WriteLine($"The first item in the list is {Mlist.Find(0)}.");
            Mlist.Clear();
            if(Mlist.Contains("beef") == false)
            {
                Console.WriteLine("Beef is no longer in the list.");
            }
        }
    }
}
