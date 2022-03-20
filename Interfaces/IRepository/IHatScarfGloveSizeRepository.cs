namespace volunteer
{
    public interface IHatScarfGloveSizeRepository
    {
        Task<List<HatScarfGloveSize>> GetAllHatScarfGloveSize();
       Task<List<HatScarfGloveSize>>GetHatScarfGloveSizeBySixandEightYears(int sixandEightYears);
        Task<List<HatScarfGloveSize>> GetHatScarfGloveSizeByEightandTenYears(int eightandTenYears);
        Task<List<HatScarfGloveSize>> GetHatScarfGloveSizeByTenandTwelveYears(int tenandTwelveYears);
        Task<List<HatScarfGloveSize>> GetHatScarfGloveSizeByTwelveandFourteenYears(int twelveandFourteen);
        Task<HatScarfGloveSize> GetHatScarfGloveSizeBySchoolId(int schoolId);
        Task<HatScarfGloveSize> UpdateHatScarfGloveSize(HatScarfGloveSize hatScarfGloveSize);
        Task<HatScarfGloveSize> CreateHatScarfGloveSize(HatScarfGloveSize hatScarfGloveSize);
        Task<HatScarfGloveSize> DeleteHatScarfGloveSize(HatScarfGloveSize hatScarfGloveSize);



    }

}