using Microsoft.EntityFrameworkCore;

using Microsoft.AspNetCore.Mvc;
using volunteer;

public class AddressService : IAddressService
{

    private readonly IAddressRepository _addressRepository;

    public AddressService(IAddressRepository addressRepository)
    {
        _addressRepository = addressRepository;
    }

    public async Task<ServiceResponse<City>> CreateCity(City city)
    {
        ServiceResponse<City> response = new ServiceResponse<City>();
        var ExistCity = await _addressRepository.FindCityByName(city.Name);
        if (ExistCity == null)
        {
            response.Data = await _addressRepository.CreateCity(city);
            response.ResponseCode = ResponseCodeEnum.Success;
            return response;
        }
        response.Data = null;
        response.ResponseCode = ResponseCodeEnum.Error;
        return response;
    }

    public async Task<ServiceResponse<District>> CreateDistrict(District district)
    {
        ServiceResponse<District> response = new ServiceResponse<District>();
        var ExistCity = await _addressRepository.FindDistrictByName(district.Name);
        if (ExistCity == null)
        {
            response.Data = await _addressRepository.CreateDistrict(district);
            response.ResponseCode = ResponseCodeEnum.Success;
            return response;
        }
        response.Data = null;
        response.ResponseCode = ResponseCodeEnum.Error;
        return response;
    }

    public async Task<ServiceResponse<Address>> DeleteAddress(int id)
    {
        ServiceResponse<Address> response = new ServiceResponse<Address>();
        var ExistCity = await _addressRepository.DeleteAddress(id);
       try 
        {
            response.Data = ExistCity;
            response.ResponseCode = ResponseCodeEnum.Success;
            return response;
        }
        catch(Exception e)
        {
        response.Data = null;
        response.ResponseCode = ResponseCodeEnum.Error;
        return response;
        }
    }

    public async Task<ServiceResponse<City>> DeleteCity(City city)
    {
        ServiceResponse<City> response = new ServiceResponse<City>();
        var ExistCity = await _addressRepository.FindCityByName(city.Name);
        if (ExistCity != null)
        {
            response.Data = await _addressRepository.DeleteCity(city);
            response.ResponseCode = ResponseCodeEnum.Success;
            return response;
        }
        response.Data = null;
        response.ResponseCode = ResponseCodeEnum.Error;
        return response;
    }

    public async Task<ServiceResponse<District>> DeleteDistrict(District district)
    {
        ServiceResponse<District> response = new ServiceResponse<District>();
        var ExistCity = await _addressRepository.FindDistrictByName(district.Name);
        if (ExistCity != null)
        {
            response.Data = await _addressRepository.DeleteDistrict(district);
            response.ResponseCode = ResponseCodeEnum.Success;
            return response;
        }
        response.Data = null;
        response.ResponseCode = ResponseCodeEnum.Error;
        return response;
    }


    public async Task<ServiceResponse<Address>> GetAddressById(int id)
    {
        ServiceResponse<Address> response = new ServiceResponse<Address>();
        var add = await _addressRepository.GetAddressById(id);

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

    public async Task<ServiceResponse<List<Address>>> GetAllAddress()
    {
        ServiceResponse<List<Address>> response = new ServiceResponse<List<Address>>();
        var add = await _addressRepository.GetAllAddress();

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

    public async Task<ServiceResponse<List<City>>> GetAllCity()
    {
        ServiceResponse<List<City>> response = new ServiceResponse<List<City>>();
        var add = await _addressRepository.GetAllCity();

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

    public async Task<ServiceResponse<List<District>>> GetAllDistrictsByCityId(int id)
    {
        ServiceResponse<List<District>> response = new ServiceResponse<List<District>>();
        var add = await _addressRepository.GetAllDistrictsByCityId(id);

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

    public async Task<ServiceResponse<Address>> RegisterAddress(Address address)
    {
        ServiceResponse<Address> response = new ServiceResponse<Address>();
        try
        {
            response.Data = await _addressRepository.RegisterAddress(address);
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

    public async Task<ServiceResponse<Address>> UpdateAddress(Address address)
    {
        ServiceResponse<Address> response = new ServiceResponse<Address>();
        var ExistCity = await _addressRepository.UpdateAddress(address);
        if (ExistCity != null)
        {
            response.Data = ExistCity;
            response.ResponseCode = ResponseCodeEnum.Success;
            return response;
        }
        response.Data = null;
        response.ResponseCode = ResponseCodeEnum.Error;
        return response;
    }
}


