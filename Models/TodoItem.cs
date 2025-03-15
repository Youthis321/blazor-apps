namespace TodoItem.Models
{
    public class TodoItem
    {
        public string? Title { get; set; }
        public bool IsDone { get; set; } = false;
        public string Category { get; set; } = "Pribadi"; // Default kategori
        public DateTime? Deadline { get; set; } // Nullable untuk optional deadline
    }
}