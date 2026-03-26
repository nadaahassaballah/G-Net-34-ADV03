namespace G_Net_34_ADV03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region q1

            List<int> grades = [85, 92, 78, 95, 88, 70, 100, 65];
            Helper.PrintList("grades",grades);
            int first = grades[0];
            int lastgrade = grades[grades.Count - 1];
            Console.WriteLine($"grade count :{grades.Count} ,first grade={first},last grade={lastgrade}");

            grades.Sort();
            Helper.PrintList("grades", grades);
            int first90 = grades.Find(x => x > 90);
            Console.WriteLine($" first grade above 90 :{first90} ");

            List<int>below = grades.FindAll(x => x < 75);
            Helper.PrintList("below", below);
            grades.RemoveAll(x => x < 75);
            Helper.PrintList("grades", grades);
            bool any = grades.Exists(x => x == 100);
            Console.WriteLine($"100 exists?{any}");
             List<string> gradeStrings = grades.Select(g => "Grade: " + g).ToList();

            foreach (var g in gradeStrings)
            {
                Console.WriteLine(g);
            }
            #endregion
        }
    }
}
