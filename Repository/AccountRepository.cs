using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace volunteer
{
    public class AccountRepository : IAccountRepository
    {

        private readonly VolunteerContext _context;
        public AccountRepository(VolunteerContext context)
        {
            _context = context;
        }

        public async Task<Account> BlockAccount(Account account)
        {
            _context.Set<Account>().Update(account);
            await _context.SaveChangesAsync();
            return account;
        }




        public async Task<Account> ChangeVisibilityOfAccount(Account account)
        {
           
            _context.Set<Account>().Update(account);
           await  _context.SaveChangesAsync();
            return account;
        }

        public async Task<Account> CreateNewAccount(Account account)
        {
            try
            {
                await _context.Set<Account>().AddAsync(account);
                await _context.SaveChangesAsync();
                return account;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Account FindAccountByEmailAndPassword(LoginDTO loginDTO)
        {
            Account accountFinded = (from x in _context.Accounts
                                     where x.Email == loginDTO.Email && x.Password == loginDTO.Password
                                     select x).FirstOrDefault();
            return accountFinded;
        }




        public async Task<Account> GetAccountByEmail(string email)
        {

            return await _context.Set<Account>().FirstOrDefaultAsync(a => a.Email == email);

        }

        public async Task<Account> GetAccountById(int id)
        {

            return await _context.Set<Account>().FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task<List<Account>> GetAllAccounts()
        {

            return await _context.Set<Account>().ToListAsync();


        }

        public async Task<Account> UpdateAccountByEmail(Account account)
        {

            _context.Set<Account>().Update(account);
            _context.SaveChangesAsync();
            return account;


        }



        public async Task<Account> UpdateAccountPassword(Account account)
        {
            _context.Set<Account>().Update(account);
            _context.SaveChangesAsync();
            return account;
        }

        public async Task<Account> findAccountById(int id)
        {
            try
            {
                return await _context.Set<Account>().FirstOrDefaultAsync(a => a.Id == id);

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Account findAccountByIdAsync(int id)
        {
            var accountId = (from a in _context.Accounts
                             where a.Id == id
                             select a).FirstOrDefault();


            return accountId;
        }

        public async Task<Account> DeleteAccount(int id)
        {
            var deleteacc = await _context.Set<Account>().FirstOrDefaultAsync(a => a.Id == id);
            _context.Set<Account>().Remove(deleteacc);
            _context.SaveChangesAsync();
            return deleteacc;
        }

        public async Task<Account> UpdateAccount(Account account)
        {
            _context.Set<Account>().Update(account);
            _context.SaveChangesAsync();
            return account;
        }
    }

}
