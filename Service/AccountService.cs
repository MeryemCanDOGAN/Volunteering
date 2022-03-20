using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
namespace volunteer
{
    public class AccountService : IAccountService
    {

        private readonly IAccountRepository _accountRepository;


        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public async Task<ServiceResponse<Account>> BlockAccountById(int id)
        {
            ServiceResponse<Account> response = new ServiceResponse<Account>();
            Account block = await _accountRepository.findAccountById(id);
            try
            {
                if (block != null)
                {
                    block.IsBlocked = !block.IsBlocked;
                    response.ResponseCode = ResponseCodeEnum.Success;
                    response.Data = await _accountRepository.BlockAccount(block);
                    return response;

                }
                response.ResponseCode = ResponseCodeEnum.Error;
                return response;
            }
            catch (Exception ex)
            {
                response.ResponseCode = ResponseCodeEnum.Error;
                return response;
            }
        }

        public async Task<ServiceResponse<Account>> ChangeVisibilityofAccount(int id)
        {
            ServiceResponse<Account> response = new ServiceResponse<Account>();
            Account visi = await _accountRepository.findAccountById(id);
            try
            {
                if (visi != null)
                {
                    visi.IsVisibility = !visi.IsVisibility;
                    response.ResponseCode = ResponseCodeEnum.Success;
                    response.Data = await _accountRepository.ChangeVisibilityOfAccount(visi);
                    return response;
                }
                response.ResponseCode = ResponseCodeEnum.Error;
                return response;
            }
            catch (Exception ex)
            {
                response.ResponseCode = ResponseCodeEnum.Error;
                return response;
            }
        }

        public async Task<ServiceResponse<Account>> CreateNewAccount(Account account)
        {
            ServiceResponse<Account> response = new ServiceResponse<Account>();
            var account1 = await _accountRepository.GetAccountById(account.Id);
            if (account1 == null)
            {
                await _accountRepository.CreateNewAccount(account);
                response.ResponseCode = ResponseCodeEnum.Success;
                response.Data = account;
                return response;
            }

            response.ResponseCode = ResponseCodeEnum.DuplicateAccountError;
            return response;
        }

        public async Task<ServiceResponse<Account>> DeleteAccountById(int id)
        {
            ServiceResponse<Account> response = new ServiceResponse<Account>();
            var idd = await _accountRepository.GetAccountById(id);
            if (idd != null)
            {
                await _accountRepository.DeleteAccount(id);
                response.ResponseCode = ResponseCodeEnum.GetAccountByIdSuccess;
                response.Data = idd;
                return response;
            }
            response.Data = null;
            response.ResponseCode = ResponseCodeEnum.GetAccountByIdError;
            return response;

        }


        public async Task<ServiceResponse<Account>> GetAccountByEmail(string email)
        {
            ServiceResponse<Account> response = new ServiceResponse<Account>();
            var idd = await _accountRepository.GetAccountByEmail(email);
            if (idd != null)
            {
                response.ResponseCode = ResponseCodeEnum.GetAccountByEmailSuccess;

                response.Data = idd;
                return response;
            }
            response.Data = null;
            response.ResponseCode = ResponseCodeEnum.GetAccountByEmailError;
            return response;

        }

        public async Task<ServiceResponse<Account>> GetAccountById(int id)
        {
            ServiceResponse<Account> response = new ServiceResponse<Account>();
            var idd = await _accountRepository.GetAccountById(id);
            if (idd != null)
            {
                response.ResponseCode = ResponseCodeEnum.GetAccountByIdSuccess;

                response.Data = idd;
                return response;
            }
            response.Data = null;
            response.ResponseCode = ResponseCodeEnum.GetAccountByIdError;
            return response;


        }

        public async Task<ServiceResponse<List<Account>>> GetAllAccounts()
        {
            ServiceResponse<List<Account>> response = new ServiceResponse<List<Account>>();

            try
            {
                response.Data = await _accountRepository.GetAllAccounts();
                response.ResponseCode = ResponseCodeEnum.GetAllAccountsSuccess;
                return response;
            }
            catch (Exception e)
            {
                response.Data = null;
                response.ResponseCode = ResponseCodeEnum.GetAllAccountsError;
                return response;
            }
        }

        public async Task<ServiceResponse<Account>> UpdateAccount(Account account)
        {
            ServiceResponse<Account> response = new ServiceResponse<Account>();
            var uppacc = _accountRepository.UpdateAccount(account);
            if (uppacc != null)
            {
                response.ResponseCode = ResponseCodeEnum.Success;
                response.Data = await uppacc;
                return response;
            }
            response.ResponseCode = ResponseCodeEnum.Error;
            return response;
        }

        public async Task<ServiceResponse<Account>> UpdateAccountByEmail(Account account)
        {
            ServiceResponse<Account> response = new ServiceResponse<Account>();
            Account account1 = new Account(await _accountRepository.UpdateAccountByEmail(account));

            if (account1 != null)
            {
                response.ResponseCode = ResponseCodeEnum.UpdateAccountByEmailSuccess;

                response.Data = account1;
                return response;
            }
            response.Data = null;
            response.ResponseCode = ResponseCodeEnum.UpdateAccountByEmailError;
            return response;
        }

        public async Task<ServiceResponse<Account>> UpdateAccountPassword(Account account)
        {
            ServiceResponse<Account> response = new ServiceResponse<Account>();
            Account upp = await _accountRepository.GetAccountByEmail(account.Email);
            if (upp != null)
            {
                upp.Password = account.Password;
                response.ResponseCode = ResponseCodeEnum.Success;
                response.Data = await _accountRepository.UpdateAccountPassword(upp);
                return response;
            }
            response.ResponseCode = ResponseCodeEnum.Error;
            return response;
        }
    }
}