namespace G_Net_34_ADV03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region q1

            //List<int> grades = [85, 92, 78, 95, 88, 70, 100, 65];
            //Helper.PrintList("grades", grades);
            //int first = grades[0];
            //int lastgrade = grades[grades.Count - 1];
            //Console.WriteLine($"grade count :{grades.Count} ,first grade={first},last grade={lastgrade}");

            //grades.Sort();
            //Helper.PrintList("grades", grades);
            //int first90 = grades.Find(x => x > 90);
            //Console.WriteLine($" first grade above 90 :{first90} ");

            //List<int> below = grades.FindAll(x => x < 75);
            //Helper.PrintList("below", below);
            //grades.RemoveAll(x => x < 75);
            //Helper.PrintList("grades", grades);
            //bool any = grades.Exists(x => x == 100);
            //Console.WriteLine($"100 exists?{any}");
            //List<string> gradeStrings = grades.Select(g => "Grade: " + g).ToList();

            //foreach (var g in gradeStrings)
            //{
            //    Console.WriteLine(g);
            //}
            #endregion

            #region q2
            //SortedList<int, string> Leaderboard = new()
            //{
            //    [500] = "Ahmed",
            //    [200] = "Sara",
            //    [800] = "Ali",
            //    [350] = "Mona"
            //};
            //foreach (var i in Leaderboard)
            //    Console.WriteLine($"{i.Key},{i.Value}");

            //Console.WriteLine($" first key :{Leaderboard.Keys[0]}, first value{Leaderboard.Values[0]}");
            //bool contain = Leaderboard.ContainsKey(500);
            //Console.WriteLine($"500 in lis ??{contain}");
            //if (Leaderboard.TryGetValue(900, out var value))
            //{
            //    Console.WriteLine(value);
            //}
            //else
            //{
            //    Console.WriteLine("not exists");
            //}
            //Leaderboard.Remove(200);
            //foreach (var i in Leaderboard)
            //    Console.WriteLine($"{i.Key},{i.Value}");
            #endregion

            #region Q3
            //Dictionary<string, int> PhoneBook = new()
            //{
            //    ["AH"] = 011,
            //    ["BC"] = 012,


            //};
            //PhoneBook["LN"] = 23;
            //PhoneBook["AH"] = 013;
            ////PhoneBook.Add("AH", 23);
            //PhoneBook.TryAdd("AH", 23);
            //Console.WriteLine(PhoneBook.ContainsKey("sdd"));

            //if (PhoneBook.TryGetValue("LN", out int vvalue))
            //{
            //    Console.WriteLine(vvalue);
            //}
            //else
            //    Console.WriteLine("Not Found");

            //Console.WriteLine("KEYS:");
            //foreach (var i in PhoneBook.Keys) {
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("VALUES:");

            //foreach (var i in PhoneBook.Values)
            //{
            //    Console.WriteLine(i);
            //}



            #endregion

            #region q4
            HashSet<string> email = new(StringComparer.OrdinalIgnoreCase)
            {
"ahmed@test.com",
                "AHMED@test.com",
                "sara@test.com"
, "Sara@Test.Com"

            };
            Console.WriteLine(email.Count);
            //because hash dont duplicate
            HashSet<int> a = [1, 2, 3, 4, 5];
            HashSet<int> b = [4, 5, 6, 7, 8];
            HashSet<int> Union = new(a);

            Union.UnionWith(b);
            Helper.PrintHashSet("A Union B", Union);

            HashSet<int> intersect = new(a);

            intersect.IntersectWith(b);
            Helper.PrintHashSet("A intersect B", intersect);
            HashSet<int> exp = new(a);

           exp.ExceptWith(b);
            Helper.PrintHashSet("A except B", exp);


            HashSet<int> c = [1,2];

            bool isSubset = c.IsSubsetOf(b);
            Console.WriteLine("is [1,2]is the subset");
            Console.WriteLine(isSubset);

            #endregion

            #region q5
            #endregion

            #region q6
            #endregion
        }
    }
}
