using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using FluentValidation.Results;
namespace volunteer
{
    [ApiController]
    [Route("[controller]")]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherService _teacherService;
        private ResponseGeneratorHelper ResponseGeneratorHelper;

        public TeacherController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
            ResponseGeneratorHelper = new ResponseGeneratorHelper();
        }
        [HttpGet("Getall")]
        public async Task<ServiceResponse<List<Teacher>>> GetAllTeachers()
        {
            return await _teacherService.GetAllTeachers();
        }
        [HttpGet("branch")]
        public async Task<ServiceResponse<Teacher>> GetTeacherByBranch(string branch)
        {
            return await _teacherService.GetTeacherByBranch(branch);
        }
        [HttpGet("id")]
        public  async Task<ServiceResponse<Teacher>> GetTeacherById(int id)
        {
            return await _teacherService.GetTeacherById(id);
        }
        [HttpGet("name")]
        public async Task<ServiceResponse<Teacher>> GetTeacherByName(string name)
        {
            return await _teacherService.GetTeacherByName(name);
        }
        [HttpGet("phoneNumber")]
        public async Task<ServiceResponse<Teacher>> GetTeacherByPhoneNumber(int phoneNumber)
        {
            return await _teacherService.GetTeacherByPhoneNumber(phoneNumber);
        }

        [HttpGet("school")]
        public async Task<ServiceResponse<Teacher>> GetTeacherBySchool(School school)
        {
            return await _teacherService.GetTeacherBySchool(school);
        }
        [HttpGet("Surname")]
         public async Task<ServiceResponse<Teacher>> GetTeacherBySurname(string surname)
         {
             return await _teacherService.GetTeacherBySurname(surname);
         }
         [HttpPost]
         public async Task<ServiceResponse<Teacher>> CreateTeacher(Teacher teacher)
         {
             return await _teacherService.CreateTeacher(teacher);
         }

         [HttpPut]
         public async Task<ServiceResponse<Teacher>> UpdateTeacher(Teacher teacher)
         {
             return await _teacherService.UpdateTeacher(teacher);
         }
         [HttpDelete]
         public async Task<ServiceResponse<Teacher>> DeleteTeacher(Teacher teacher)
         {
             return await _teacherService.DeleteTeacher(teacher);
         }

    }
}