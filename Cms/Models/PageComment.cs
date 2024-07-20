using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cms.Models
{
    public class PageComment
    {
        [Key]
        public int CommentId { get; set; }

        [Required]
        public int PageId { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Content { get; set; } = string.Empty;

        [Required]
        public DateTime RegistrationDate { get; set; }

        [ForeignKey(nameof(PageId))]
        public required Page Page { get; set; }
    }
}
