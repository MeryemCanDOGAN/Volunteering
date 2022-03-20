
namespace volunteer
{
    public interface IAccountRepository
    {
        Task<List<Account>> GetAllAccounts();
        Task<Account> GetAccountById(int id);
        Task<Account> GetAccountByEmail(string email);
        Task<Account> CreateNewAccount(Account account);
        Task<Account> UpdateAccountByEmail(Account account);
        Task<Account> UpdateAccountPassword(Account account);
        Task<Account> UpdateAccount(Account account);
        Task<Account> ChangeVisibilityOfAccount(Account account);
        Task<Account> BlockAccount(Account account);
        Account FindAccountByEmailAndPassword(LoginDTO loginDTO);
        Task<Account> findAccountById(int id);
        Account findAccountByIdAsync(int id);
        Task<Account> DeleteAccount(int id);
    }
}