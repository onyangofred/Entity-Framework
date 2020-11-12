using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkOgolla.Models
{
    public class UserGroup
    {
        [Required]
        public virtual string UserId { get; set; }
        [Required]
        public virtual string GroupId { get; set; }

        public virtual User User{ get; set; }
        public virtual Group Group { get; set; }
    }
}