using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EFCoreTaskManager.Models
{
    public class TaskItem
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        // Marks this as the Primary Key and Auto-Incremented
        public int Id { get; set; }
        [Required] // Ensures this field is not null
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
        // Foreign Key for Category
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
