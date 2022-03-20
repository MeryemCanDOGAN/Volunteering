namespace volunteer
{
    public interface IAnnouncementRepository
    {
        Task<List<Announcement>>GetAllAnnouncement();
        Task<Announcement> FindAnnouncementByReleaseDate(DateTime releaseDate);
        Task<Announcement> GetAnnouncementBySchoolId(int schoolId);
        Task<Announcement> CreateAnnouncement(Announcement announcement);
        Task<Announcement> UpdateAnnouncement(Announcement announcement);
        Task<Announcement> DeleteAnnouncement(int id);



    }
}