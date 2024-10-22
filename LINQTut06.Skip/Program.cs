using LINQTut02.Shared;

namespace LINQTut06.Skip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emps = Repository.LoadEmployees();
            var q1 = emps.Skip(10);
            q1.Print("Skiiped the first 10 elements");
            var q2 = emps.SkipWhile(e => e.Salary != 214400);
            q2.Print("Skip while salary != 214400");
            var q3 = emps.SkipLast(10);
            q3.Print("skipp last 10 emps");

        }
    }
}
