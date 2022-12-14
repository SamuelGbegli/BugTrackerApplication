using System.Security.Principal;

namespace BugTrackerApplication.Models
{
    public class Comment
    {
        public int Id { get; set; }
        //public Bug Bug { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public bool CanEdit { get; set; }

        public Comment()
        {

        }
    }
}
