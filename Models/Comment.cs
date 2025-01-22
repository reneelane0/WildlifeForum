namespace WildlifeForum.Models
{
    public class Comment
    {
        public int CommentId { get; set; } // primary key
        public string Content { get; set; }
        public DateTime CreateDate { get; set; }
        public int DiscussionId { get; set; } // foreign key

        // navigation property
        public Discussion? Discussion { get; set; }

    }
}
