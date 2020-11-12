using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkOgolla.Models
{
    public class Group
    {
        public Group()
        {
        }


        public Group(string name) : this()
        {
            Roles = new List<GroupRole>();
            Name = name;
        }


        [Key]
        [Required]
        public virtual string Id { get; set; }

        [Display(Name="Group Name")]
        public virtual string Name { get; set; }

        public virtual bool IsDefault { get; set; }

        public virtual ICollection<GroupRole> Roles { get; set; }
    }
}