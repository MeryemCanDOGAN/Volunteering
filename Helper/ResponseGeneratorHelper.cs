using Microsoft.AspNetCore.Mvc;
using volunteer;

public class ResponseGeneratorHelper : ControllerBase
{
    public ActionResult ResponseGenerator<T>(ServiceResponse<T> incomingResponse)
    {
        switch (incomingResponse.ResponseCode)
        {
            case ResponseCodeEnum.Success:
            case ResponseCodeEnum.GetAllAccountsSuccess:
            case ResponseCodeEnum.GetAccountByIdSuccess:
            case ResponseCodeEnum.GetAccountByEmailSuccess:
            case ResponseCodeEnum.UpdateAccountByEmailSuccess:
            case ResponseCodeEnum.CreateNewAccountSuccess:
            case ResponseCodeEnum.DeleteAccountByEmailSuccess:
            case ResponseCodeEnum.UpdateAccountByIdSuccess:
            case ResponseCodeEnum.BlockAccountByEmailSuccess:
            case ResponseCodeEnum.GetAllUserSuccess:
            case ResponseCodeEnum.GetUserByIdSuccess:
            case ResponseCodeEnum.GetUserByFirstNameSuccess:
            case ResponseCodeEnum.GetUserByLastNameSuccess:
            case ResponseCodeEnum.GetUserByUserNameSuccess:
            case ResponseCodeEnum.GetUserByGenderSuccess:
            case ResponseCodeEnum.GetUserByRoleSuccess:
            case ResponseCodeEnum.GetUserByAccountSuccess:
            case ResponseCodeEnum.GetUserByBirthDateSuccess:
            case ResponseCodeEnum.CreateNewUserOperationSuccess:


            


                {
                    return Ok(incomingResponse);
                }

            case ResponseCodeEnum.GetAllAccountsError:
            case ResponseCodeEnum.GetAccountByIdError:
            case ResponseCodeEnum.GetAccountByEmailError:
            case ResponseCodeEnum.UpdateAccountByEmailError:
            case ResponseCodeEnum.DeleteAccountByEmailError:
            case ResponseCodeEnum.UpdateAccountByIdError:
            case ResponseCodeEnum.BlockAccountByEmailError:
            case ResponseCodeEnum.GetAllUserError:
            case ResponseCodeEnum.GetUserByIdError:
            case ResponseCodeEnum.GetUserByFirstNameError:
            case ResponseCodeEnum.GetUserByLastNameError:
            case ResponseCodeEnum.GetUserByUserNameError:
            case ResponseCodeEnum.GetUserByGenderError:
            case ResponseCodeEnum.GetUserByRoleError:
            case ResponseCodeEnum.GetUserByAccountError:
            case ResponseCodeEnum.GetUserByBirthDateError:

           

                {
                    return NotFound(incomingResponse);
                }
          
           case ResponseCodeEnum.DuplicateAccountError:
           case ResponseCodeEnum.DuplicateUserError:
                {
                    return NoContent();
                }
            default:
                {
                    return BadRequest(incomingResponse);
                }
        }
    }
}

  
    
    

   
    
  
   
    
  