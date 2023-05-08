namespace ObjectOrientedProgramming.ContentContext
{
    public abstract class Content
    {
        protected Content()
        {
            Id =  Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? Url { get; set; }
    }
}
