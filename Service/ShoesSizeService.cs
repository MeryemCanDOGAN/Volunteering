using Microsoft.EntityFrameworkCore;

using Microsoft.AspNetCore.Mvc;
using volunteer;

public class ShoesSizeService : IShoesSizeService
{

    private readonly IShoesSizeRepository _shoesSizeRepository;

    public ShoesSizeService(IShoesSizeRepository shoesSizeRepository)
    {
        _shoesSizeRepository = shoesSizeRepository;
    }

    public async Task<ServiceResponse<ShoesSize>> CreateShoesSize(ShoesSize shoesSize)
    {
        ServiceResponse<ShoesSize> response = new ServiceResponse<ShoesSize>();
        try
        {
            response.Data = await _shoesSizeRepository.CreateShoesSize(shoesSize);
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

    public async Task<ServiceResponse<ShoesSize>> DeleteShoesSize(ShoesSize shoesSize)
    {
        ServiceResponse<ShoesSize> response = new ServiceResponse<ShoesSize>();

        try
        {
            response.Data = await _shoesSizeRepository.DeleteShoesSize(shoesSize);
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

    public async Task<ServiceResponse<List<ShoesSize>>> GetAllShoesSize()
    {
        ServiceResponse<List<ShoesSize>> response = new ServiceResponse<List<ShoesSize>>();
        var add = await _shoesSizeRepository.GetAllShoesSize();

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

  

    public async Task<ServiceResponse<List<ShoesSize>>> GetShoesSizeByThirtyFive(int thirtyFive)
    {
            ServiceResponse<List<ShoesSize>> response = new ServiceResponse<List<ShoesSize>>();
        var add = await _shoesSizeRepository. GetShoesSizeByThirtyFive( thirtyFive);

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

    public async Task<ServiceResponse<List<ShoesSize>>> GetShoesSizeByThirtyFour(int thirtyFour)
    {
            ServiceResponse<List<ShoesSize>> response = new ServiceResponse<List<ShoesSize>>();
        var add = await _shoesSizeRepository. GetShoesSizeByThirtyFour(thirtyFour);

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

    public async Task<ServiceResponse<List<ShoesSize>>> GetShoesSizeByThirtyThree(int thirtyThree)
    {
         ServiceResponse<List<ShoesSize>> response = new ServiceResponse<List<ShoesSize>>();
        var add = await _shoesSizeRepository. GetShoesSizeByThirtyThree( thirtyThree);

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

    public async Task<ServiceResponse<List<ShoesSize>>> GetShoesSizeByThirtyTwo(int thirtyTwo)
    {
        ServiceResponse<List<ShoesSize>> response = new ServiceResponse<List<ShoesSize>>();
        var add = await _shoesSizeRepository. GetShoesSizeByThirtyTwo(thirtyTwo);

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

    public async Task<ServiceResponse<ShoesSize>> UpdateShoesSize(ShoesSize shoesSize)
    {
        ServiceResponse<ShoesSize> response = new ServiceResponse<ShoesSize>();
        var Coat = await _shoesSizeRepository.UpdateShoesSize(shoesSize);
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

   public async Task<ServiceResponse<ShoesSize>> GetShoesSizeBySchoolId(int schoolId)
    {
       ServiceResponse<ShoesSize> response = new ServiceResponse<ShoesSize>();
        var add = await _shoesSizeRepository.GetShoesSizeBySchoolId(schoolId);

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
}