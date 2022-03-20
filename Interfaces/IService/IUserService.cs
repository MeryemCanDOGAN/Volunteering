
using Microsoft.AspNetCore.Mvc;
namespace volunteer
{
    public interface IUserService
    {
        Task<ServiceResponse<List<User>>> GetAllUser();
        Task<ServiceResponse<User>> GetUserById(int id);
        Task<ServiceResponse<User>> GetUserByFirstName(string firstName);
        Task<ServiceResponse<User>> GetUserByLastName(string lastName);
        Task<ServiceResponse<User>> GetUserByUserName(string userName);
        Task<ServiceResponse<User>> GetUserByGender(  Gender gender, int genderId);
        Task<ServiceResponse<User>> GetUserByRole(int id, Role role);
        Task<ServiceResponse<User>> GetUserByAccount(int id, Account account);
        Task<ServiceResponse<User>> GetUserByBirthDate(DateTime birthdate);
        Task<ServiceResponse<User>> CreateNewUserOperation(User user);
        Task<ServiceResponse<User>> UpdateUserOperation(int id, User user);
       

    }

}