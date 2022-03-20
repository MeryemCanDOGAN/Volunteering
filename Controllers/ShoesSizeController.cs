using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using FluentValidation.Results;
namespace volunteer
{
    [ApiController]
    [Route("[controller]")]
    public class ShoesSizeController : ControllerBase
    {
        private readonly IShoesSizeService _shoesSizeService;
        private ResponseGeneratorHelper ResponseGeneratorHelper;

        public ShoesSizeController(IShoesSizeService shoesSizeService)
        {
            _shoesSizeService = shoesSizeService;
            ResponseGeneratorHelper = new ResponseGeneratorHelper();
        }
           [HttpGet("Getall")]

        public async Task<ActionResult<ServiceResponse<List<ShoesSize>>>> GetAllShoesSize()
        {
            return await _shoesSizeService.GetAllShoesSize();

        }
        [HttpGet("thirtytwo")]
         public async Task<ActionResult<ServiceResponse<List<ShoesSize>>>> GetShoesSizeByThirtyTwo(int thirtyTwo)
         {
             return await _shoesSizeService.GetShoesSizeByThirtyTwo(thirtyTwo);
         }
         [HttpGet("thirtythree")]
         public async Task<ActionResult<ServiceResponse<List<ShoesSize>>>> GetShoesSizeByThirtytThree(int thirtyThree)
         {
             return await _shoesSizeService.GetShoesSizeByThirtyThree(thirtyThree);
         }
         [HttpGet("thirtyfour")]
         public async Task<ActionResult<ServiceResponse<List<ShoesSize>>>> GetShoesSizeByThirtyFour(int thirtyFour)
         {
             return await _shoesSizeService.GetShoesSizeByThirtyFour(thirtyFour);
         }
         [HttpGet("thirtyfive")]
         public async Task<ActionResult<ServiceResponse<List<ShoesSize>>>> GetShoesSizeByThirtyFive(int thirtyFive)
         {
             return await _shoesSizeService.GetShoesSizeByThirtyFive(thirtyFive);
         }
           [HttpPost]
         public async Task<ActionResult<ServiceResponse<ShoesSize>>> CreateShoesSize(ShoesSize shoesSize)
         {
             return await _shoesSizeService.CreateShoesSize(shoesSize);
         }
         [HttpPut]
          public async Task<ActionResult<ServiceResponse<ShoesSize>>>  UpdateShoesSize(ShoesSize shoesSize)
          {
              return await _shoesSizeService.UpdateShoesSize(shoesSize);
          }
          [HttpDelete]
          public async Task<ActionResult<ServiceResponse<ShoesSize>>>  DeleteShoesSize(ShoesSize shoesSize)
          {
              return await _shoesSizeService.DeleteShoesSize(shoesSize);
          }


    }
}
