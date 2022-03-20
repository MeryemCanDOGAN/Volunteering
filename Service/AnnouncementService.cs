using Microsoft.EntityFrameworkCore;

using Microsoft.AspNetCore.Mvc;
using volunteer;

public class AnnouncementService : IAnnouncementService
{

    private readonly IAnnouncementRepository _announcementRepository;

    public AnnouncementService(IAnnouncementRepository announcementRepository)
    {
        _announcementRepository = announcementRepository;
    }

    public async Task<ServiceResponse<Announcement>> CreateAnnouncement(Announcement announcement)
    {
         ServiceResponse<Announcement>response = new ServiceResponse<Announcement>();
        try
        {
            response.Data = await _announcementRepository.CreateAnnouncement(announcement);
            response.ResponseCode = ResponseCodeEnum.Success;
            return response;
        }
        catch (Exception e)
        {
            response.Data = null;
            response.ResponseCode = ResponseCodeEnum.Error;
            return response;
        }
    }

    public async Task<ServiceResponse<Announcement>> DeleteAnnouncement(int id)
    {
        ServiceResponse<Announcement> response = new ServiceResponse<Announcement>();
       
        try
        {
            response.Data = await _announcementRepository.DeleteAnnouncement(id);
            response.ResponseCode = ResponseCodeEnum.Success;
            return response;
        }
        catch (Exception e)
        {
            response.Data = null;
            response.ResponseCode = ResponseCodeEnum.Error;
            return response;
        }
    }

    public async Task<ServiceResponse<Announcement>> FindAnnouncementByReleaseDate(DateTime releaseDate)
    {
        ServiceResponse<Announcement> response = new ServiceResponse<Announcement>();
        var add = await _announcementRepository.FindAnnouncementByReleaseDate(releaseDate);

        if (add != null)
        {

            response.Data = add;
            response.ResponseCode = ResponseCodeEnum.Success;
            return response;
        }
        response.Data = null;
        response.ResponseCode = ResponseCodeEnum.Error;
        return response;

    }

    public async Task<ServiceResponse<List<Announcement>>> GetAllAnnouncement()
    {
        ServiceResponse <List< Announcement>> response = new ServiceResponse<List<Announcement>> ();
        var add = await _announcementRepository.GetAllAnnouncement();

        if (add != null)
        {

            response.Data = add;
            response.ResponseCode = ResponseCodeEnum.Success;
            return response;
        }
        response.Data = null;
        response.ResponseCode = ResponseCodeEnum.Error;
        return response;

    }

    public async Task<ServiceResponse<Announcement>> GetAnnouncementBySchoolId(int schoolId)
    {
         ServiceResponse<Announcement> response = new ServiceResponse<Announcement>();
        var add = await _announcementRepository.GetAnnouncementBySchoolId(schoolId);

        if (add != null)
        {

            response.Data = add;
            response.ResponseCode = ResponseCodeEnum.Success;
            return response;
        }
        response.Data = null;
        response.ResponseCode = ResponseCodeEnum.Error;
        return response;
    }

    public async Task<ServiceResponse<Announcement>> UpdateAnnouncement(Announcement announcement)
    {
         ServiceResponse<Announcement> response = new ServiceResponse<Announcement>();
        var ExistCity = await _announcementRepository.UpdateAnnouncement(announcement);
        if (ExistCity != null)
        {
            response.Data = ExistCity;
            response.ResponseCode = ResponseCodeEnum.Success;
            return response;
        }
        response.Data = null;
        response.ResponseCode = ResponseCodeEnum.Error;
        return response;
    }
}
