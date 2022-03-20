using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using FluentValidation.Results;
namespace volunteer
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;
        private ResponseGeneratorHelper ResponseGeneratorHelper;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
            ResponseGeneratorHelper = new ResponseGeneratorHelper();
        }
        [HttpGet("Getall")]
        public   async Task<ActionResult<ServiceResponse<List<Account>>>> GetAllAccounts()
        {
            return  await _accountService.GetAllAccounts();
        }
       [HttpGet("id")]
        public async Task<ServiceResponse<Account>> GetAccountById(int id)
        {
            return await _accountService.GetAccountById(id);
        }
         
        [HttpGet("email")]
        public async Task<ActionResult<ServiceResponse<Account>>>GetAccountByEmail(string email)
        {
            return await _accountService.GetAccountByEmail(email);
        }
        [HttpPost("new")]
        public async Task<ActionResult<ServiceResponse<Account>>>CreateNewAccount(Account account)
        {
            return await _accountService.CreateNewAccount(account);
        }

        [HttpPut("email")]

        public async Task<ActionResult<ServiceResponse<Account>>> UpdateAccountByEmail(Account account)
        {
             return await _accountService.UpdateAccountByEmail(account);

        }
        [HttpDelete]
        public async Task<ActionResult<ServiceResponse<Account>>> DeleteAccountById(int id)
        {
            return await _accountService.DeleteAccountById(id);
        }
        [HttpPut("visibility")]
        public async Task<ActionResult<ServiceResponse<Account>>> ChangeVisibilityofAccount(int id)
        {
            return await _accountService.ChangeVisibilityofAccount(id);
        }
         [HttpPut("block")]
          public async Task<ActionResult<ServiceResponse<Account>>> BlockAccountById(int id)
        {
            return await _accountService.BlockAccountById(id);
        }
          [HttpPut("password")]
          public async Task<ActionResult<ServiceResponse<Account>>>UpdateAccountPassword(Account account)
        {
            return await _accountService.UpdateAccountPassword(account);
        }
      
      

    }
}