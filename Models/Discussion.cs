namespace WildlifeForum.Models
{
    public class Discussion
    {
        public int DiscussionId { get; set; } // primary key

        public string Title { get; set; } = string.Empty;
        public string Content { get; set; }
        public string ImageFilename { get; set; }
        public DateTime CreateDate { get; set; }

        // navigation property
        public List<Comment>? Comments { get; set; }

    }
}
