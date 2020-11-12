namespace EntityFrameworkOgolla.Models
{
    using System.ComponentModel.DataAnnotations;

    public partial class Menu
    {
        public string Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Code { get; set; }

        [StringLength(80)]
        public string MenuTitle { get; set; }

        [Required]
        [StringLength(150)]
        public string MenuName { get; set; }

        [Required]
        [StringLength(128)]
        public string ParentId { get; set; }

        [StringLength(150)]
        public string Action { get; set; }

        [StringLength(150)]
        public string Controller { get; set; }

        [StringLength(150)]
        public string RouteData { get; set; }

        public int MenuOrder { get; set; }

        [StringLength(50)]
        public string MenuIcon { get; set; }

        public int? MenuLevel { get; set; }

        public bool ExpandOnly { get; set; }

        public int? TableID { get; set; }

        public bool IsVisible { get; set; }

    }
}
