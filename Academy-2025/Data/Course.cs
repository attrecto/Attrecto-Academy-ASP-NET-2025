namespace Academy_2025.Data
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public ICollection<User> Users { get; set; } = [];
    }
}
