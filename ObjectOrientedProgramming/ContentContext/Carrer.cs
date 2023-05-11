namespace ObjectOrientedProgramming.ContentContext
{
    public class Carrer : Content
    {
        public Carrer()
        {
            Items = new List<CareerItem>();
        }
        public IList<CareerItem> Items { get; set; }

        //Expression Body
        public int TotalCourses => Items.Count;
    }
}
