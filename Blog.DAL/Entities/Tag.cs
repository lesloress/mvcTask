﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Blog.DAL.Entities
{
    public class Tag
    {
        //public int Id { get; set; }

        [Key,
            MinLength(3, ErrorMessage = "Длина названия не должна быть меньже 3 символов"),
            MaxLength(24, ErrorMessage = "Длина названия не должна быть больше 24 символов"),]
        public string Name { get; set; }

        public virtual IList<Article> Articles { get; set; }

        public Tag()
        {
            Articles = new List<Article>();
        }
    }
}
