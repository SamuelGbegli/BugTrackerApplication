namespace BugTrackerApplication.Models
{
    public class Bug
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Project Project { get; set; }
        public string Description { get; set; }
        public Severity Severity { get; set; }
        public bool IsOpen { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public List<Comment> Comments { get; set; }

        public Bug()
        {

        }
    }
    public enum Severity{
        Low,
        Medium, High
        }
}
