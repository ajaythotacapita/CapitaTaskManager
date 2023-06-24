//create static class to read data from file
namespace TaskManagement.Services
{
    public static class datafile
    {
        private static List<Task> tasks = new List<Task>();

        //create a method to add task to the list
        public static void AddTask(Task task)
        {
            tasks.Add(task);
        }

        //remove task from the list
        public static void RemoveTask(Task task)
        {
            tasks.Remove(task);
        }

        //return the list of tasks
        public static List<Task> GetTasks()
        {
            return tasks;
        }

        //update the task
        public static void UpdateTask(Task task)
        {
            tasks.Remove(tasks.Find(t => t.Id == task.Id));
            tasks.Add(task);
        }

        
    }

    
}