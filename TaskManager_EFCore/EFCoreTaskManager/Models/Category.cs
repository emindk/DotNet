namespace EFCoreTaskManager.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Relationship: One Category -> Many Tasks
        public List<TaskItem>? Tasks { get; set; }

    }
}
