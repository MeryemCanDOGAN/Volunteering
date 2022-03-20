using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using volunteer;
public class AnnouncementRepository : IAnnouncementRepository
{

    private readonly VolunteerContext _context;
    public AnnouncementRepository(VolunteerContext context)
    {
        _context = context;
    }

    public async Task<Announcement> CreateAnnouncement(Announcement announcement)
    {
     await _context.Set<Announcement>().AddAsync(announcement);
     await _context.SaveChangesAsync();
     return announcement;
    }

    public async Task<Announcement> DeleteAnnouncement(int id)
    {
        var  DeleteAnnouncement = await _context.Announcements.FirstOrDefaultAsync(a=>a.Id==id);
        _context.Announcements.Remove( DeleteAnnouncement);
        await _context.SaveChangesAsync();
        return null;

    }

    public async Task<Announcement> FindAnnouncementByReleaseDate(DateTime releaseDate)
    {
        return await _context.Set<Announcement>().FirstOrDefaultAsync(a=>a.ReleaseDate==releaseDate);
    }

    public async Task<List<Announcement>> GetAllAnnouncement()
    {
        return await _context.Set<Announcement>().ToListAsync();
    }

  
    public async Task<Announcement> GetAnnouncementBySchoolId(int schoolId)
    {
        var aSchool = await _context.Set<Announcement>().SingleOrDefaultAsync(a=>a.SchoolId==schoolId);
        if(aSchool !=null)
        {
            return aSchool;
        }
        return null;
    }

    public async Task<Announcement> UpdateAnnouncement( Announcement announcement)
    {
        _context.Announcements.Update(announcement);
        await _context.SaveChangesAsync();
        return announcement;
    }
}
