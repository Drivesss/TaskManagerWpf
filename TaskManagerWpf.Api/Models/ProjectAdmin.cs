namespace TaskManagerWpf.Api.Models
{
    public class ProjectAdmin
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public List<Project> Projects { get; set; } = new List<Project>();

        public Project Admin { get; set; }
        public ProjectAdmin(User user)
        {
            UserId = user.Id;
            User = user;
        }

    }
}
 