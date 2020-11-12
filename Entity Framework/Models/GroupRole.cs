namespace EntityFrameworkOgolla.Models
{
    public class GroupRole
    {
        public virtual string RoleId { get; set; }
        public virtual string GroupId { get; set; }

        public virtual Role Role { get; set; }
        public virtual Group Group { get; set; }
    }
}