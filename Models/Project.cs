namespace BugTrackerApplication.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        //public User User { get; set; }
        public List<Bug> Bugs { get; set; }

        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }

        public Project() { }
    }
}
