namespace volunteer
{
    public interface ICoatSizeRepository
    {
        Task<List<CoatSize>> GetAllCoatSize();
        Task<List<CoatSize>> GetCoatSizeBySixandEightYears(int sixandEightYears);
        Task<List<CoatSize>> GetCoatSizeByEightandTenYears(int eightandTenYears);
        Task<List<CoatSize>> GetCoatSizeByTenandTwelveYears(int tenandTwelveYears);
        Task<List<CoatSize>> GetCoatSizeByTwelveandFourteenYears(int twelveandFourteen);
        Task<CoatSize> GetCoatSizeBySchoolId(int schoolId);
        Task<CoatSize> UpdateCoatSize(CoatSize coatSize);
        Task<CoatSize> CreateCoatSize(CoatSize coatSize);
        Task<CoatSize> DeleteCoatSize(CoatSize coatSize);



    }

}