using Microsoft.EntityFrameworkCore;

using Microsoft.AspNetCore.Mvc;
using volunteer;

public class UserService : IUserService
{

    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }



    public async Task<ServiceResponse<User>> CreateNewUserOperation(User user)
    {

        var idd = await _userRepository.GetUserByFirstName(user.FirstName);
        ServiceResponse<User> response = new ServiceResponse<User>();
        if (idd!= null)
        {
            response.Data=idd;
            response.ResponseCode = ResponseCodeEnum.CreateNewUserOperationSuccess;
            return response;
        }
        response.Data=null;
        response.ResponseCode = ResponseCodeEnum.DuplicateUserError;
        return response;


    }



    public async Task<ServiceResponse<List<User>>> GetAllUser()
    {
 
        ServiceResponse<List<User>> response = new ServiceResponse<List<User>>();

        try
        {
           response.Data= await _userRepository.GetAllUser();
            response.ResponseCode = ResponseCodeEnum.GetAllUserSuccess;
            return response;
        }
        catch (Exception e)
        {
            response.Data = null;
            response.ResponseCode = ResponseCodeEnum.GetAllUserError;
            return response;
        }

    }



    public async Task<ServiceResponse<User>> GetUserById(int id)
    {
        
        ServiceResponse<User> response = new ServiceResponse<User>();
        var idd = await _userRepository.GetUserById(id);
        if (idd != null)
        {
            
            response.ResponseCode = ResponseCodeEnum.GetUserByIdSuccess;;
           response.Data = idd; 
           return response;
        }
        response.Data=null;
        response.ResponseCode = ResponseCodeEnum.GetUserByIdError;
        return response;

    }

    public async Task<ServiceResponse<User>> GetUserByFirstName(string firstName)
    {


       
        ServiceResponse<User> response = new ServiceResponse<User>();
        var idd = await _userRepository.GetUserByFirstName(firstName);
        if (idd != null)
        {
            response.Data = idd;
            response.ResponseCode = ResponseCodeEnum.GetUserByFirstNameSuccess;
            return response;
        }
        response.Data=null;
        response.ResponseCode = ResponseCodeEnum.GetAccountByIdSuccess;
        return response;
    }

    public async Task<ServiceResponse<User>> GetUserByLastName(string lastName)
    {
        
        ServiceResponse<User> response = new ServiceResponse<User>();
        var idd = await _userRepository.GetUserByLastName(lastName);
        if (idd != null)
        {
            response.Data = idd;
            response.ResponseCode = ResponseCodeEnum.GetUserByLastNameSuccess;
            return response;
        }
        response.Data=null;
        response.ResponseCode = ResponseCodeEnum.GetUserByLastNameError;
        return response;
    }


    public async Task<ServiceResponse<User>> UpdateUserOperation(int id, User user)
    {
       
        ServiceResponse<User> response = new ServiceResponse<User>();
        var users = await _userRepository.GetUserById(id);
        if (users != null)
        {
            response.ResponseCode = ResponseCodeEnum.UpdateAccountByEmailSuccess;

            response.Data = users;
            return response;
        }
        response.Data = null;
        response.ResponseCode = ResponseCodeEnum.UpdateAccountByEmailError;
        return response;


    }



    public async Task<ServiceResponse<User>> GetUserByUserName(string userName)
    {
       
        ServiceResponse<User> response = new ServiceResponse<User>();
        var idd = await _userRepository.GetUserByUserName(userName);
        if (idd != null)
        {
            response.Data =idd;
            response.ResponseCode = ResponseCodeEnum.GetUserByUserNameSuccess;
            return response;
        }
        response.Data=null;
        response.ResponseCode = ResponseCodeEnum.GetUserByUserNameError;
        return response;
    }

    public async Task<ServiceResponse<User>> GetUserByGender(  Gender gender, int genderId)
    {
       
        ServiceResponse<User> response = new ServiceResponse<User>();
        var idd = await _userRepository.GetUserByGender(gender,genderId);
        if (idd != null)
        {
            response.Data =idd;
            response.ResponseCode = ResponseCodeEnum.GetUserByGenderSuccess;
            return response;
        }
        response.Data=null;
        response.ResponseCode = ResponseCodeEnum.GetUserByGenderError;
        return response;
    }

    public async Task<ServiceResponse<User>> GetUserByRole(int id, Role role)
    {
       
        ServiceResponse<User> response = new ServiceResponse<User>();
        var idd = await _userRepository.GetUserByRole(id, role);
        if (idd != null)
        {
            response.Data = idd;
            response.ResponseCode = ResponseCodeEnum.GetUserByRoleSuccess;
            return response;
        }
        response.Data=null;
        response.ResponseCode = ResponseCodeEnum.GetUserByRoleError;
        return response;
    }

    public async Task<ServiceResponse<User>> GetUserByAccount(int id, Account account)
    {
      
        ServiceResponse<User> response = new ServiceResponse<User>();
        var idd = await _userRepository.GetUserByAccount(id, account);
        if (idd != null)
        {
            response.Data = idd;
            response.ResponseCode = ResponseCodeEnum.GetUserByAccountSuccess;
            return response;
        }
        response.Data=idd;
        response.ResponseCode = ResponseCodeEnum.GetUserByAccountError;
        return response;
    }

    public async Task<ServiceResponse<User>> GetUserByBirthDate(DateTime birthdate)
    {
       
        ServiceResponse<User> response = new ServiceResponse<User>();
        var idd = await _userRepository.GetUserByBirthDate(birthdate);
        if (idd != null)
        {
            response.Data = idd;
            response.ResponseCode = ResponseCodeEnum.GetUserByBirthDateSuccess;
            return response;
        }
        response.Data=idd;
        response.ResponseCode = ResponseCodeEnum.GetAccountByIdSuccess;
        return response;
    }


}