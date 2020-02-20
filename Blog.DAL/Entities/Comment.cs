using System;
using System.ComponentModel.DataAnnotations;

namespace Blog.DAL.Entities
{
    public class Comment
    {
        public int Id { get; set; }

        [MinLength(3, ErrorMessage = "Длина имени не должна быть менее 3 символов"),
            MaxLength(32, ErrorMessage = "Длина имени не должна быть более 32 символов")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Добавьте текст комментария"),
            MaxLength(120, ErrorMessage = "Длина комментария не должна превышать 120 символов")]
        public string Text { get; set; }
        public DateTime Date { get; set; }

        public int? ArticleId { get; set; }
        public virtual Article Article { get; set; }
    }
}
