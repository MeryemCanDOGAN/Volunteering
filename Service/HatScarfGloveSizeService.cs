using Microsoft.EntityFrameworkCore;

using Microsoft.AspNetCore.Mvc;
using volunteer;

public class HatScarfGloveSizeService : IHatScarfGloveSizeService
{

    private readonly IHatScarfGloveSizeRepository _hatScarfGloveSizeRepository;

    public HatScarfGloveSizeService(IHatScarfGloveSizeRepository hatScarfGloveSizeRepository)
    {
        _hatScarfGloveSizeRepository = hatScarfGloveSizeRepository;
    }

    public async Task<ServiceResponse<HatScarfGloveSize>> CreateHatScarfGloveSize(HatScarfGloveSize hatScarfGloveSize)
    {
        ServiceResponse<HatScarfGloveSize> response = new ServiceResponse<HatScarfGloveSize>();
        try
        {
            response.Data = await _hatScarfGloveSizeRepository.CreateHatScarfGloveSize(hatScarfGloveSize);
            response.ResponseCode = ResponseCodeEnum.Success;
            return response;
        }
        catch (Exception e)
        {
            response.Data = null;
            response.ResponseCode = ResponseCodeEnum.Error;
            return response;
        }
    }

    public async   Task<ServiceResponse<HatScarfGloveSize>> DeleteHatScarfGloveSize(HatScarfGloveSize hatScarfGloveSize)
    {
        ServiceResponse<HatScarfGloveSize> response = new ServiceResponse<HatScarfGloveSize>();

        try
        {
            response.Data = await _hatScarfGloveSizeRepository.DeleteHatScarfGloveSize(hatScarfGloveSize);
            response.ResponseCode = ResponseCodeEnum.Success;
            return response;
        }
        catch (Exception e)
        {
            response.Data = null;
            response.ResponseCode = ResponseCodeEnum.Error;
            return response;
        }
    }

    public async Task<ServiceResponse<List<HatScarfGloveSize>>> GetAllHatScarfGloveSize()
    {
        ServiceResponse<List<HatScarfGloveSize>> response = new ServiceResponse<List<HatScarfGloveSize>>();
        var add = await _hatScarfGloveSizeRepository.GetAllHatScarfGloveSize();

        if (add != null)
        {

            response.Data = add;
            response.ResponseCode = ResponseCodeEnum.Success;
            return response;
        }
        response.Data = null;
        response.ResponseCode = ResponseCodeEnum.Error;
        return response;

    }

    public async Task<ServiceResponse<List<HatScarfGloveSize>>>  GetHatScarfGloveSizeByEightandTenYears(int eightandTenYears)
    {
        ServiceResponse<List<HatScarfGloveSize>> response = new ServiceResponse<List<HatScarfGloveSize>>();
        var add = await _hatScarfGloveSizeRepository.GetHatScarfGloveSizeByEightandTenYears(eightandTenYears);

        if (add != null)
        {

            response.Data = add;
            response.ResponseCode = ResponseCodeEnum.Success;
            return response;
        }
        response.Data = null;
        response.ResponseCode = ResponseCodeEnum.Error;
        return response;
    }


    public async Task<ServiceResponse<HatScarfGloveSize>> GetHatScarfGloveSizeBySchoolId(int schoolId)
    {
        ServiceResponse<HatScarfGloveSize> response = new ServiceResponse<HatScarfGloveSize>();
        var add = await _hatScarfGloveSizeRepository.GetHatScarfGloveSizeBySchoolId(schoolId);

        if (add != null)
        {

            response.Data = add;
            response.ResponseCode = ResponseCodeEnum.Success;
            return response;
        }
        response.Data = null;
        response.ResponseCode = ResponseCodeEnum.Error;
        return response;
    }

    public async Task<ServiceResponse<List<HatScarfGloveSize>>>  GetHatScarfGloveSizeBySixandEightYears(int sixandEightYears)
    {
        ServiceResponse<List<HatScarfGloveSize>> response = new ServiceResponse<List<HatScarfGloveSize>>();
        var add = await _hatScarfGloveSizeRepository.GetHatScarfGloveSizeBySixandEightYears(sixandEightYears);

        if (add != null)
        {

            response.Data = add;
            response.ResponseCode = ResponseCodeEnum.Success;
            return response;
        }
        response.Data = null;
        response.ResponseCode = ResponseCodeEnum.Error;
        return response;
    }

    public async Task<ServiceResponse<List<HatScarfGloveSize>>>  GetHatScarfGloveSizeByTenandTwelveYears(int tenandTwelveYears)
    {
        ServiceResponse<List<HatScarfGloveSize>>response = new ServiceResponse<List<HatScarfGloveSize>>();
        var add = await _hatScarfGloveSizeRepository.GetHatScarfGloveSizeByTenandTwelveYears(tenandTwelveYears);

        if (add != null)
        {

            response.Data = add;
            response.ResponseCode = ResponseCodeEnum.Success;
            return response;
        }
        response.Data = null;
        response.ResponseCode = ResponseCodeEnum.Error;
        return response;
    }

    public async Task<ServiceResponse<List<HatScarfGloveSize>>>  GetHatScarfGloveSizeByTwelveandFourteenYears(int twelveandFourteen)
    {
        ServiceResponse<List<HatScarfGloveSize>> response = new ServiceResponse<List<HatScarfGloveSize>>();
        var add = await _hatScarfGloveSizeRepository.GetHatScarfGloveSizeByTwelveandFourteenYears(twelveandFourteen);

        if (add != null)
        {

            response.Data = add;
            response.ResponseCode = ResponseCodeEnum.Success;
            return response;
        }
        response.Data = null;
        response.ResponseCode = ResponseCodeEnum.Error;
        return response;
    }

    public async Task<ServiceResponse<HatScarfGloveSize>> UpdateHatScarfGloveSize(HatScarfGloveSize hatScarfGloveSize)
    {
        ServiceResponse<HatScarfGloveSize> response = new ServiceResponse<HatScarfGloveSize>();
        var Coat = await _hatScarfGloveSizeRepository.UpdateHatScarfGloveSize(hatScarfGloveSize);
        if (Coat != null)
        {
            response.Data = Coat;
            response.ResponseCode = ResponseCodeEnum.Success;
            return response;
        }
        response.Data = null;
        response.ResponseCode = ResponseCodeEnum.Error;
        return response;
    }
}
