using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace EntityFrameworkOgolla.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class User
    {
        public User()
        {
            Groups = new HashSet<UserGroup>();
        }
        
        #nullable enable    
        [Key]
        [Required]
        public virtual string Id { get; set; }
        public string UserCode { get; set; }
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string LastName { get; set; }

        #nullable disable

        //navigation property - create 1 to many r/ship
        public virtual ICollection<UserGroup> Groups { get; set; }

    }
}