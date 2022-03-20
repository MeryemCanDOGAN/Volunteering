namespace volunteer
{
    public interface IAddressService
    {
     
        Task<ServiceResponse<List<Address>>> GetAllAddress();
        Task<ServiceResponse<Address>> GetAddressById(int id);
        Task<ServiceResponse<List<City>>> GetAllCity();
        Task<ServiceResponse<List<District>>> GetAllDistrictsByCityId(int id);
        Task<ServiceResponse<Address>> UpdateAddress(Address address);
        Task<ServiceResponse<Address>> RegisterAddress(Address address);
        Task<ServiceResponse<City>> CreateCity(City city);
        Task<ServiceResponse<District>> CreateDistrict(District district);
        Task<ServiceResponse<Address>> DeleteAddress(int id);
        Task<ServiceResponse<City>> DeleteCity(City city);
        Task<ServiceResponse<District>> DeleteDistrict(District district);
    }
}