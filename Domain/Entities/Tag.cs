using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Tag
    {
        public int Id { get; set; }

        [Required,
            MinLength(3, ErrorMessage = "Длина названия не должна быть меньже 3 символов"),
            MaxLength(24, ErrorMessage = "Длина названия не должна быть больше 24 символов"),]
        public string Name { get; set; }

        public virtual ICollection<Article> Articles { get; set; }
    }
}
