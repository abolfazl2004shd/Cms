using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cms.Models
{
    public class ArticleComment
    {
        [Key]
        public int CommentId { get; set; }

        [Required]
        public int ArticleId { get; set; }

        [Required]
        public string Content { get; set; } = string.Empty;

        [Required]
        public DateTime RegistrationDate { get; set; }

        [ForeignKey(nameof(ArticleId))]
        public Article Article { get; set; }
    }
}
