namespace volunteer
{
    public class Announcement
    {
        public int Id { get; set; }
        public int? SchoolId { get; set; }
        public School? School { get; set; }
        public string? ADetails { get; set; }
        public DateTime? ReleaseDate { get; set; }

    }
}