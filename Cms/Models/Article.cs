using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cms.Models
{
    public class Article
    {
        [Key]
        public int ArticleId { get; set; }

        [Required]
        public int GroupId { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;
        [Required]
        [StringLength(400)]
        public string ShortDescription { get; set; } = string.Empty;
        [Required]
        [StringLength(1000)]
        public string Context { get; set; } = string.Empty;
        [Required]
        public DateTime RegistrationDate { get; set; }
        public bool ShowInSlider { get; set; } = false;

        [ForeignKey(nameof(GroupId))]
        public required ArticleGroup ArticleGroup { get; set; }

        public List<ArticleComment>? ArticleComments { get; set; }
        public List<Keyword>? Keywords { get; set; }
    }
}