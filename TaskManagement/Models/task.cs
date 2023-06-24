//create task class with properties
namespace TaskManagement.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }

        public DateTime TaskDueDate { get; set; }

        public bool TaskStatus { get; set; }
    }
}