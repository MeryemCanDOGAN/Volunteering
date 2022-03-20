using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using FluentValidation.Results;
namespace volunteer
{
    [ApiController]
    [Route("[controller]")]
    public class SchoolController : ControllerBase
    {
        private readonly ISchoolService _schoolService;
        private ResponseGeneratorHelper ResponseGeneratorHelper;

        public SchoolController(ISchoolService schoolService)
        {
            _schoolService = schoolService;
            ResponseGeneratorHelper = new ResponseGeneratorHelper();
        }
        [HttpGet("Getall")]
        public async Task<ActionResult<ServiceResponse<List<School>>>> GetAllSchool()
        {
            return await _schoolService.GetAllSchool();
        }
        [HttpGet("name")]
        public async Task<ActionResult<ServiceResponse<School>>> GetSchoolByName(string name)
        {
            return await _schoolService.GetSchoolByName(name);
        }
        [HttpGet("address")]
        public async Task<ActionResult<ServiceResponse<School>>> GetSchoolByAddress(int addressId)
        {
            return await _schoolService.GetSchoolByAddress(addressId);
        }
        [HttpGet("numberofclass")]
        public async Task<ActionResult<ServiceResponse<School>>> GetSchoolByNumberofClass(int numberofClass)
        {
            return await _schoolService.GetSchoolByNumberofClass(numberofClass);

        }
        [HttpGet("numberofstudent")]
        public async Task<ActionResult<ServiceResponse<School>>> GetSchoolByNumberofStudent(int numberofStudent)
        {
            return await _schoolService.GetSchoolByNumberofStudent(numberofStudent);
        }
        [HttpGet("teachername")]
        public async Task<ActionResult<ServiceResponse<School>>> GetSchoolByTeacherName(int teacherId)
        {
            return await _schoolService.GetSchoolByTeacherName(teacherId);
        }
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<School>>> CreateNewSchool(School school)
        {
            return await _schoolService.CreateNewSchool(school);
        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<School>>> UpdateSchool( School school)
        {
            return await _schoolService.UpdateSchool(school);
        }
        [HttpDelete]
         public async Task<ActionResult<ServiceResponse<School>>> DeleteSchool(School school)
         {
             return await _schoolService.DeleteSchool(school);
         }
        

        



    }
}