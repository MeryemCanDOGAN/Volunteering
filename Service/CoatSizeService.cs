using Microsoft.EntityFrameworkCore;

using Microsoft.AspNetCore.Mvc;
using volunteer;

public class CoatSizeService : ICoatSizeService
{

    private readonly ICoatSizeRepository _coatSizeRepository;

    public CoatSizeService(ICoatSizeRepository coatSizeRepository)
    {
        _coatSizeRepository = coatSizeRepository;
    }

    public async Task<ServiceResponse<CoatSize>> CreateCoatSize(CoatSize coatSize)
    {
        ServiceResponse<CoatSize> response = new ServiceResponse<CoatSize>();
        try
        {
            response.Data = await _coatSizeRepository.CreateCoatSize(coatSize);
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

    public async Task<ServiceResponse<CoatSize>> DeleteCoatSize(CoatSize coatSize)
    {
        ServiceResponse<CoatSize> response = new ServiceResponse<CoatSize>();

        try
        {
            response.Data = await _coatSizeRepository.DeleteCoatSize(coatSize);
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

    public async Task<ServiceResponse<List<CoatSize>>> GetAllCoatSize()
    {
        ServiceResponse<List<CoatSize>> response = new ServiceResponse<List<CoatSize>>();
        var add = await _coatSizeRepository.GetAllCoatSize();

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

    public async Task<ServiceResponse<List<CoatSize>>>  GetCoatSizeByEightandTenYears(int eightandTenYears)
    {
        ServiceResponse<List<CoatSize>> response = new ServiceResponse<List<CoatSize>>();
        var add = await _coatSizeRepository.GetCoatSizeByEightandTenYears(eightandTenYears);

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


    public async Task<ServiceResponse<CoatSize>> GetCoatSizeBySchoolId(int schoolId)
    {
        ServiceResponse<CoatSize> response = new ServiceResponse<CoatSize>();
        var add = await _coatSizeRepository.GetCoatSizeBySchoolId(schoolId);

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

    public async Task<ServiceResponse<List<CoatSize>>>  GetCoatSizeBySixandEightYears(int sixandEightYears)
    {
        ServiceResponse<List<CoatSize>> response = new ServiceResponse<List<CoatSize>>();
        var add = await _coatSizeRepository.GetCoatSizeBySixandEightYears(sixandEightYears);

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

    public async Task<ServiceResponse<List<CoatSize>>>  GetCoatSizeByTenandTwelveYears(int tenandTwelveYears)
    {
        ServiceResponse<List<CoatSize>>response = new ServiceResponse<List<CoatSize>>();
        var add = await _coatSizeRepository.GetCoatSizeByTenandTwelveYears(tenandTwelveYears);

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

    public async Task<ServiceResponse<List<CoatSize>>>  GetCoatSizeByTwelveandFourteenYears(int twelveandFourteen)
    {
        ServiceResponse<List<CoatSize>> response = new ServiceResponse<List<CoatSize>>();
        var add = await _coatSizeRepository.GetCoatSizeByTwelveandFourteenYears(twelveandFourteen);

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

    public async Task<ServiceResponse<CoatSize>> UpdateCoatSize(CoatSize coatSize)
    {
        ServiceResponse<CoatSize> response = new ServiceResponse<CoatSize>();
        var Coat = await _coatSizeRepository.UpdateCoatSize(coatSize);
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
