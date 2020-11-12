namespace EntityFrameworkOgolla.Models
{
    using System.ComponentModel.DataAnnotations;

    public partial class RoleMenu
    {
        public string Id { get; set; }

        [Required]
        [StringLength(128)]
        public string RoleId { get; set; }

        [Required]
        [StringLength(128)]
        public string MenuId { get; set; }

        public virtual Role Role { get; set; }
        public virtual Menu Menu { get; set; }
    }
}
