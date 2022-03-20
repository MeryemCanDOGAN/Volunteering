using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using FluentValidation.Results;
namespace volunteer
{
    [ApiController]
    [Route("[controller]")]
    public class AnnouncementController : ControllerBase
    {
        private readonly IAnnouncementService _announcementService;
        private ResponseGeneratorHelper ResponseGeneratorHelper;

        public AnnouncementController(IAnnouncementService announcementService)
        {
            _announcementService = announcementService;
            ResponseGeneratorHelper = new ResponseGeneratorHelper();
        }
        [HttpGet("Getall")]
        public async Task<ActionResult<ServiceResponse<List<Announcement>>>> GetAllAnnouncement()
        {
            return await _announcementService.GetAllAnnouncement();
        }
        [HttpGet("GetbySchollName")]
        public async Task<ActionResult<ServiceResponse<Announcement>>> GetAnnouncementBySchoolId(int schoolId)
        {
            return await _announcementService.GetAnnouncementBySchoolId(schoolId);
        }
        [HttpGet("ReleaseDate")]
        public async Task<ActionResult<ServiceResponse<Announcement>>> FindAnnouncementByReleaseDate(DateTime releaseDate)
        {
            return await _announcementService.FindAnnouncementByReleaseDate(releaseDate);
        }
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<Announcement>>> CreateAnnouncement(Announcement announcement)
        {
            return await _announcementService.CreateAnnouncement(announcement);
        }
        [HttpPut]
        public async Task<ActionResult<ServiceResponse<Announcement>>> UpdateAnnouncement(Announcement announcement)
        {
            return await _announcementService.UpdateAnnouncement(announcement);

        }
        [HttpDelete]
         public async Task<ServiceResponse<Announcement>> DeleteAnnouncement(int id)
         {
             return await _announcementService.DeleteAnnouncement(id);
         }

    }
}