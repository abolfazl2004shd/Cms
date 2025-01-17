﻿using System.ComponentModel.DataAnnotations;

namespace Cms.Models
{
    public class ArticleGroup
    {
        [Key]
        public int GroupId { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        public List<Article>? Articles { get; set; }
    }
}
