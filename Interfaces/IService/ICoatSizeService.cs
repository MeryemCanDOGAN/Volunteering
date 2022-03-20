namespace volunteer
{
    public interface ICoatSizeService
    {
        Task<ServiceResponse<List<CoatSize>>> GetAllCoatSize();
        Task<ServiceResponse<List<CoatSize>>>  GetCoatSizeBySixandEightYears(int sixandEightYears);
        Task<ServiceResponse<List<CoatSize>>>  GetCoatSizeByEightandTenYears(int eightandTenYears);
        Task<ServiceResponse<List<CoatSize>>>  GetCoatSizeByTenandTwelveYears(int tenandTwelveYears);
       Task<ServiceResponse<List<CoatSize>>>  GetCoatSizeByTwelveandFourteenYears(int twelveandFourteen);
        Task<ServiceResponse<CoatSize>> GetCoatSizeBySchoolId(int schoolId);
        Task<ServiceResponse<CoatSize>> UpdateCoatSize(CoatSize coatSize);
        Task<ServiceResponse<CoatSize>> CreateCoatSize(CoatSize coatSize);
        Task<ServiceResponse<CoatSize>> DeleteCoatSize(CoatSize coatSize);



    }

}