using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using FluentValidation.Results;
namespace volunteer
{
    [ApiController]
    [Route("[controller]")]
    public class HatScarfGloveSizeController : ControllerBase
    {
        private readonly IHatScarfGloveSizeService _hatScarfGloveSizeService;
        private ResponseGeneratorHelper ResponseGeneratorHelper;

        public HatScarfGloveSizeController(IHatScarfGloveSizeService hatScarfGloveSizeService)
        {
            _hatScarfGloveSizeService = hatScarfGloveSizeService;
            ResponseGeneratorHelper = new ResponseGeneratorHelper();
        }

        [HttpGet("Getall")]

        public async Task<ActionResult<ServiceResponse<List<HatScarfGloveSize>>>> GetAllHatScarfGloveSize()
        {
            return await _hatScarfGloveSizeService.GetAllHatScarfGloveSize();

        }
        [HttpGet("sixandeight")]
        public async Task<ActionResult<ServiceResponse<List<HatScarfGloveSize>>>> GetHatScarfGloveSizeBySixandEightYears(int sixandEightYears)
        {
            return await _hatScarfGloveSizeService.GetHatScarfGloveSizeBySixandEightYears(sixandEightYears);
        }
        [HttpGet("eightandten")]
        public async Task<ActionResult<ServiceResponse<List<HatScarfGloveSize>>>> GetHatScarfGloveSizeByEightandTenYears(int eightandTenYears)
        {
            return await _hatScarfGloveSizeService.GetHatScarfGloveSizeByEightandTenYears(eightandTenYears);
        }
        [HttpGet("tenandtwelve")]
        public async Task<ActionResult<ServiceResponse<List<HatScarfGloveSize>>>> GetHatScarfGloveSizeByTenandTwelveYears(int tenandTwelveYears)
        {
            return await _hatScarfGloveSizeService.GetHatScarfGloveSizeByTenandTwelveYears(tenandTwelveYears);
        }
        [HttpGet("twelveandten")]
        public async Task<ActionResult<ServiceResponse<List<HatScarfGloveSize>>>> GetHatScarfGloveSizeByTwelveandFourteenYears(int twelveandFourteen)
        {
            return await _hatScarfGloveSizeService.GetHatScarfGloveSizeByTwelveandFourteenYears(twelveandFourteen);
        }

        [HttpPost]
         public async Task<ServiceResponse<HatScarfGloveSize>> CreateHatScarfGloveSize(HatScarfGloveSize hatScarfGloveSize)
         {
             return await _hatScarfGloveSizeService.CreateHatScarfGloveSize(hatScarfGloveSize);
         }
         [HttpPut]
          public async Task<ServiceResponse<HatScarfGloveSize>> UpdateHatScarfGloveSize(HatScarfGloveSize hatScarfGloveSize)
          {
              return await _hatScarfGloveSizeService.UpdateHatScarfGloveSize(hatScarfGloveSize);
          }
          [HttpDelete]
          public async Task<ServiceResponse<HatScarfGloveSize>> DeleteHatScarfGloveSize(HatScarfGloveSize hatScarfGloveSize)
          {
              return await _hatScarfGloveSizeService.DeleteHatScarfGloveSize(hatScarfGloveSize);
          }





    }
}
