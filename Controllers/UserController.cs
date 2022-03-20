using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using FluentValidation.Results;
namespace volunteer
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private ResponseGeneratorHelper ResponseGeneratorHelper;

        public UserController(IUserService userService)
        {
            _userService = userService;
            ResponseGeneratorHelper = new ResponseGeneratorHelper();
        }
        [HttpGet("Getall")]
        public async Task<ActionResult<ServiceResponse<List<User>>>> GetAllUser()
        {
            return await _userService.GetAllUser();
        }
        [HttpGet("id")]
        public async Task<ActionResult<ServiceResponse<User>>> GetUserById(int id)
        {
            return await _userService.GetUserById(id);
        }
        [HttpGet("firtsName")]
        public async Task<ActionResult<ServiceResponse<User>>> GetUserByFirstName(string firstName)
        {
            return await _userService.GetUserByFirstName(firstName);
        }
        [HttpGet("lastName")]
        public async Task<ActionResult<ServiceResponse<User>>> GetUserByLastName(string lastName)
        {
            return await _userService.GetUserByLastName(lastName);
        }
        [HttpGet("userName")]
        public async Task<ActionResult<ServiceResponse<User>>> GetUserByUserName(string userName)
        {
            return await _userService.GetUserByUserName(userName);
        }
        [HttpGet("Gender")]
        public async Task<ActionResult<ServiceResponse<User>>> GetUserByGender(Gender gender, int genderId)
        {
            return await _userService.GetUserByGender(gender, genderId);
        }
        [HttpGet("Role")]
        public async Task<ActionResult<ServiceResponse<User>>> GetUserByRole(int RoleId, Role role)
        {
            return await _userService.GetUserByRole(RoleId, role);
        }
        [HttpGet("Account")]
        public async Task<ActionResult<ServiceResponse<User>>> GetUserByAccount(int id, Account account)
        {
            return await _userService.GetUserByAccount(id, account);
        }
        [HttpGet("BirthDate")]
        public async Task<ActionResult<ServiceResponse<User>>> GetUserByBirthDate(DateTime birthdate)
        {
            return await _userService.GetUserByBirthDate(birthdate);
        }
        [HttpPost("User")]
        public async Task<ActionResult<ServiceResponse<User>>> CreateNewUserOperation(User user)
        {
            return await _userService.CreateNewUserOperation(user);
        }
        [HttpPut("UserUpdate")]
        public async Task<ActionResult<ServiceResponse<User>>>UpdateUserOperation(int id, User user)
        {
            return await _userService.UpdateUserOperation(id,user);
        }
    }
}


