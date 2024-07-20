using System.ComponentModel.DataAnnotations;

namespace Cms.Models
{
    public class PageGroup
    {
        [Key]
        public int GroupId { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        public List<Page>? Pages { get; set; }
    }
}
