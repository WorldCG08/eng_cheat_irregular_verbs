using System;
using System.Linq;

namespace eng_cheat
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new VerbContext())
            {
                string searchText = null;

                while (searchText != "exit")
                {
                    Console.WriteLine("Search or type exit:");
                    searchText = Console.ReadLine();
                    Console.Clear();
                    // Display all Blogs from the database
                    var query = db.Verbs.Where(v => v.Infinitive.Contains(searchText) || v.Participle.Contains(searchText) || v.Simple.Contains(searchText));

                    foreach (var item in query)
                    {
                        Console.WriteLine(item.Infinitive + "\t" + item.Simple + "\t" + item.Participle);
                    }
                }
            }
        }
    }
}
