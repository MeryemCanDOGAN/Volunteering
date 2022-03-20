namespace volunteer
{
    public interface IHatScarfGloveSizeService
    {
        Task<ServiceResponse<List<HatScarfGloveSize>>> GetAllHatScarfGloveSize();
        Task<ServiceResponse<List<HatScarfGloveSize>>> GetHatScarfGloveSizeBySixandEightYears(int sixandEightYears);
        Task<ServiceResponse<List<HatScarfGloveSize>>> GetHatScarfGloveSizeByEightandTenYears(int eightandTenYears);
        Task<ServiceResponse<List<HatScarfGloveSize>>> GetHatScarfGloveSizeByTenandTwelveYears(int tenandTwelveYears);
        Task<ServiceResponse<List<HatScarfGloveSize>>> GetHatScarfGloveSizeByTwelveandFourteenYears(int twelveandFourteen);
        Task<ServiceResponse<HatScarfGloveSize>> GetHatScarfGloveSizeBySchoolId(int schoolId);
        Task<ServiceResponse<HatScarfGloveSize>> UpdateHatScarfGloveSize(HatScarfGloveSize hatScarfGloveSize);
        Task<ServiceResponse<HatScarfGloveSize>> CreateHatScarfGloveSize(HatScarfGloveSize hatScarfGloveSize);
        Task<ServiceResponse<HatScarfGloveSize>> DeleteHatScarfGloveSize(HatScarfGloveSize hatScarfGloveSize);



    }

}