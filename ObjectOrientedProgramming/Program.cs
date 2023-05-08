using ObjectOrientedProgramming.ContentContext;

namespace ObjectOrientedProgramming
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Word");

            var course = new Course();
            course.Level = ContentContext.Enums.EContentLevel.Fundamental;
        }

    }
}