namespace volunteer
{

    public interface IAnnouncementService
    {
        Task<ServiceResponse<List<Announcement>>> GetAllAnnouncement();
        Task<ServiceResponse<Announcement>> FindAnnouncementByReleaseDate(DateTime releaseDate);
        Task<ServiceResponse<Announcement>>GetAnnouncementBySchoolId(int schoolId);
        Task<ServiceResponse<Announcement>> CreateAnnouncement(Announcement announcement);
        Task<ServiceResponse<Announcement>> UpdateAnnouncement(Announcement announcement);
        Task<ServiceResponse<Announcement>> DeleteAnnouncement(int id);

    }


}