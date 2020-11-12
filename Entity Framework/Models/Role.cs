using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkOgolla.Models
{
    public class Role : GroupRole
    {
        public Role() : base() { }

        public Role(string name) : base()
        {
            this.Name = name;
            MenuItems = new HashSet<RoleMenu>();
        }
        public virtual string Name { get; set; }

        [Column(TypeName ="decimal(18,2)")]
        public virtual decimal Cost { get; set; }
        public ICollection<RoleMenu> MenuItems { get; set; }

    }
}