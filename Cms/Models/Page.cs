using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cms.Models
{
    public class Page
    {
        [Key]
        public int PageId { get; set; }

        [Required]
        public int GroupId { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;
        [Required]
        public string ShortDescription { get; set; } = string.Empty;
        [Required]
        public string Context { get; set; } = string.Empty;
        [Required]
        public DateTime RegistrationDate { get; set; }
        public bool ShowInSlider { get; set; } = false;

        [ForeignKey(nameof(GroupId))]
        public required PageGroup PageGroup { get; set; }

        public List<PageComment>? PageComments { get; set; }
    }
}