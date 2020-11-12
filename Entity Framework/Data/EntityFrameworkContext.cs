using EntityFrameworkOgolla.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkOgolla.Data
{
    class EntityFrameworkDbContext:DbContext
    {
        public DbSet<Group> Groups { get; set; }
        public DbSet<GroupRole> GroupRoles { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RoleMenu> RoleMenus { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserGroup> UserGroups { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source='.\';Initial Catalog='EntityFrameworkOgolla';Persist Security Info=True;User ID='staff_portal';Password=123@Team");
        }

    }
}
