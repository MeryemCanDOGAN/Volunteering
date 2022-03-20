using Microsoft.AspNetCore.Mvc;
namespace volunteer
{
    public interface IAccountService
    {
        Task<ServiceResponse<Account>> CreateNewAccount(Account account);
        Task<ServiceResponse<Account>> DeleteAccountById(int id);
        Task<ServiceResponse<List<Account>>> GetAllAccounts();
        Task<ServiceResponse<Account>> UpdateAccountByEmail(Account account);
        Task<ServiceResponse<Account>> GetAccountById(int id);
        Task<ServiceResponse<Account>> GetAccountByEmail(string email);
        Task<ServiceResponse<Account>> ChangeVisibilityofAccount(int id);
        Task<ServiceResponse<Account>> BlockAccountById(int id);
        Task<ServiceResponse<Account>> UpdateAccountPassword(Account account);
        Task<ServiceResponse<Account>> UpdateAccount(Account account);




    }
}