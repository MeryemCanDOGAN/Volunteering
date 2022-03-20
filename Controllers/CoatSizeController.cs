using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using FluentValidation.Results;
namespace volunteer
{
    [ApiController]
    [Route("[controller]")]
    public class CoatSizeController : ControllerBase
    {
        private readonly ICoatSizeService _coatSizeService;
        private ResponseGeneratorHelper ResponseGeneratorHelper;

        public CoatSizeController(ICoatSizeService coatSizeService)
        {
            _coatSizeService = coatSizeService;
            ResponseGeneratorHelper = new ResponseGeneratorHelper();
        }

        [HttpGet("Getall")]

        public async Task<ActionResult<ServiceResponse<List<CoatSize>>>> GetAllCoatSize()
        {
            return await _coatSizeService.GetAllCoatSize();

        }
        [HttpGet("sixandeight")]
        public async Task<ActionResult<ServiceResponse<List<CoatSize>>>> GetCoatSizeBySixandEightYears(int sixandEightYears)
        {
            return await _coatSizeService.GetCoatSizeBySixandEightYears(sixandEightYears);
        }
        [HttpGet("eightandten")]
        public async Task<ActionResult<ServiceResponse<List<CoatSize>>>> GetCoatSizeByEightandTenYears(int eightandTenYears)
        {
            return await _coatSizeService.GetCoatSizeByEightandTenYears(eightandTenYears);
        }
        [HttpGet("tenandtwelve")]
        public async Task<ActionResult<ServiceResponse<List<CoatSize>>>> GetCoatSizeByTenandTwelveYears(int tenandTwelveYears)
        {
            return await _coatSizeService.GetCoatSizeByTenandTwelveYears(tenandTwelveYears);
        }
        [HttpGet("twelveandten")]
        public async Task<ActionResult<ServiceResponse<List<CoatSize>>>> GetCoatSizeByTwelveandFourteenYears(int twelveandFourteen)
        {
            return await _coatSizeService.GetCoatSizeByTwelveandFourteenYears(twelveandFourteen);
        }

        [HttpPost]
         public async Task<ServiceResponse<CoatSize>> CreateCoatSize(CoatSize coatSize)
         {
             return await _coatSizeService.CreateCoatSize(coatSize);
         }
         [HttpPut]
          public async Task<ServiceResponse<CoatSize>> UpdateCoatSize(CoatSize coatSize)
          {
              return await _coatSizeService.UpdateCoatSize(coatSize);
          }
          [HttpDelete]
          public async Task<ServiceResponse<CoatSize>> DeleteCoatSize(CoatSize coatSize)
          {
              return await _coatSizeService.DeleteCoatSize(coatSize);
          }





    }
}
