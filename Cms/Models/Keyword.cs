using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cms.Models
{
    public class Keyword
    {
        [Key]
        public int KeywordId { get; set; }
        [Required]
        public int ArticleId { get; set; }
        [Required]
        public string Word { get; set; } = string.Empty;

        [ForeignKey(nameof(ArticleId))]
        public required Article Article { get; set; }
    }
}
