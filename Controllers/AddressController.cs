using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using FluentValidation.Results;
namespace volunteer
{
    [ApiController]
    [Route("[controller]")]
    public class AddressController : ControllerBase
    {
        private readonly IAddressService _addressService;
        private ResponseGeneratorHelper ResponseGeneratorHelper;

        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
            ResponseGeneratorHelper = new ResponseGeneratorHelper();
        }
        [HttpGet("Getall")]
        public async Task<ActionResult<ServiceResponse<List<Address>>>> GetAllAddress()
        {
            return await _addressService.GetAllAddress();

        }
        [HttpGet("id")]
        public async Task<ActionResult<ServiceResponse<Address>>> GetAddressById(int id)
        {
            return await _addressService.GetAddressById(id);
        }

        [HttpGet("AllCity")]
        public async Task<ActionResult<ServiceResponse<List<City>>>> GetAllCity()
        {
            return await _addressService.GetAllCity();
        }
        [HttpGet("AllDistrict")]
        public async Task<ActionResult<ServiceResponse<List<District>>>> GetAllDistrictsByCityId(int id)
        {
            return await _addressService.GetAllDistrictsByCityId(id);
        }
        [HttpPost("Register")]
        public async Task<ActionResult<ServiceResponse<Address>>> RegisterAddress(Address address)
        {
            return await _addressService.RegisterAddress(address);
        }
        [HttpPut]
        public async Task<ActionResult<ServiceResponse<Address>>> UpdateAddress(Address address)
        {
            return await _addressService.UpdateAddress(address);

        }
        [HttpPost("City")]
        public async Task<ActionResult<ServiceResponse<City>>>CreateCity(City city)
        {
            return await _addressService.CreateCity(city);
        }
         [HttpPost("District")]
        public async Task<ActionResult<ServiceResponse<District>>> CreateDistrict(District district)
        {
            return await _addressService.CreateDistrict(district);
        }
        [HttpDelete("Address")]
        public async Task<ActionResult<ServiceResponse<Address>>> DeleteAddress(int id)
        {
            return await _addressService.DeleteAddress(id);
        }



    }
}