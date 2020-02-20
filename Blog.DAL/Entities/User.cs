using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Blog.DAL.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "")]
        [MaxLength(24, ErrorMessage = "")]
        public string Username { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [EmailAddress]
        [Required]
        public string Email { get; set; }

        public virtual ICollection<Article> Articles { get; set; }
    }
}
