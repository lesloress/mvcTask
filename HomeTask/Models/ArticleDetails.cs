using System;
using System.Collections.Generic;

namespace HomeTask.Models
{
    public class ArticleDetails
    {
        public int Id { get; set; }
        public string AuthorName { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Date { get; set; }
        public byte[] Image { get; set; }

        public int AuthorId { get; set; }
        public virtual ICollection<CommentViewModel> Comments { get; set; }
        public virtual ICollection<TagViewModel> Tags { get; set; }

        public ArticleDetails()
        {
            Comments = new List<CommentViewModel>();
            Tags = new List<TagViewModel>();
        }
    }
}