using ObjectOrientedProgramming.ContentContext.Enums;
using ObjectOrientedProgramming.SharedContext;

namespace ObjectOrientedProgramming.ContentContext
{
    public class Lecture : Base
    {
        public int Order { get; set; }
        public string? Title { get; set; }
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }

    }
}
