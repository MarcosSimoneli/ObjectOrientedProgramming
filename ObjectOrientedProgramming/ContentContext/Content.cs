namespace ObjectOrientedProgramming.ContentContext
{
    public abstract class Content : Base
    {
        protected Content(string title, string url)
        {
            Title = title;
            Url = url;
        }

        public string? Title { get; set; }
        public string? Url { get; set; }
    }
}
