using System.Collections.Generic;
namespace volunteer
{
    public interface IAddressRepository
    {

        Task<City> FindCityByName(string CityName);
        Task<District> FindDistrictByName(string DistirctName);
        Task<List<Address>> GetAllAddress();
        Task<Address> GetAddressById(int id);
        Task<List<City>> GetAllCity();
        Task<List<District>> GetAllDistrictsByCityId(int id);
        Task<Address> UpdateAddress(Address address);
        Task<Address> RegisterAddress(Address address);
        Task<City> CreateCity(City city);
        Task<District> CreateDistrict(District district);
        Task<Address> DeleteAddress(int id);
        Task<City> DeleteCity(City city);
        Task<District> DeleteDistrict(District district);
    }
}