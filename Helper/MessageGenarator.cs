public static class MessageGenarator
{
    public static readonly Dictionary<ResponseCodeEnum, string> TrResponseMessages
        = new Dictionary<ResponseCodeEnum, string>
    {
    { ResponseCodeEnum.Success, "Ok" },
    {ResponseCodeEnum.Error,"Error"},
    { ResponseCodeEnum.GetAllAccountsSuccess,"Ok" },
    { ResponseCodeEnum.GetAllAccountsError,"fail" },
    { ResponseCodeEnum.GetAccountByIdSuccess ,"Ok" },
    { ResponseCodeEnum.GetAccountByIdError,"Fail" },
    { ResponseCodeEnum.GetAccountByEmailSuccess,"Ok" },
    { ResponseCodeEnum.GetAccountByEmailError,"Fail" },
    { ResponseCodeEnum.DuplicateAccountError, "Aynı maile sahip başka hesap var yeniden deneyin"},
    { ResponseCodeEnum.CreateNewAccountSuccess,"Yeni Account başarılı şekilde oluşturuldu."},
    { ResponseCodeEnum.DeleteAccountByEmailSuccess,"Account başarılı şekilde silindi."},
    { ResponseCodeEnum.DeleteAccountByEmailError,"Account silme işlemi başarısız."},
    { ResponseCodeEnum.UpdateAccountByEmailSuccess,"Account update başarılı"},
    { ResponseCodeEnum.UpdateAccountByEmailError,"Account update başarısız"},
    { ResponseCodeEnum.UpdateAccountByIdSuccess,"Account update başarılı"},
    { ResponseCodeEnum.UpdateAccountByIdError,"Account update başarısız"},
    { ResponseCodeEnum.BlockAccountByEmailSuccess,"Account blocklama başarılı"},
    { ResponseCodeEnum.BlockAccountByEmailError,"Account blocklama başarılı"},
   //User
   
    { ResponseCodeEnum.GetAllUserSuccess,"Ok" },
    { ResponseCodeEnum.GetAllUserError,"fail" },
    { ResponseCodeEnum.GetUserByIdSuccess ,"Ok" },
    { ResponseCodeEnum.GetUserByIdError,"Fail" },
    { ResponseCodeEnum.GetUserByFirstNameSuccess,"Ok" },
    { ResponseCodeEnum.GetUserByFirstNameError,"Fail" },
    { ResponseCodeEnum.GetUserByLastNameSuccess,"Ok" },
    { ResponseCodeEnum.GetUserByLastNameError,"Fail" },
    { ResponseCodeEnum.GetUserByUserNameSuccess,"Ok" },
    { ResponseCodeEnum.GetUserByUserNameError,"Fail" },
    { ResponseCodeEnum.GetUserByGenderSuccess,"Ok" },
    { ResponseCodeEnum.GetUserByGenderError,"Fail" },
    { ResponseCodeEnum.GetUserByRoleSuccess,"Ok" },
    { ResponseCodeEnum.GetUserByRoleError,"Fail" },
    { ResponseCodeEnum.GetUserByAccountSuccess,"Ok" },
    { ResponseCodeEnum.GetUserByAccountError,"Fail" },
    { ResponseCodeEnum.GetUserByBirthDateSuccess,"Ok" },
    { ResponseCodeEnum.GetUserByBirthDateError,"Fail" },
    { ResponseCodeEnum.DuplicateUserError, "Aynı maile sahip başka hesap var yeniden deneyin"},
    { ResponseCodeEnum.CreateNewUserOperationSuccess,"Yeni User başarılı şekilde oluşturuldu."},
 




    };


    public static string ResponseMessageGenarator(ResponseCodeEnum ResponseCode)
    {
        return TrResponseMessages[ResponseCode];
    }

}