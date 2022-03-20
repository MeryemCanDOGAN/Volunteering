namespace volunteer
{
    public interface IShoesSizeService
    {
        Task<ServiceResponse<List<ShoesSize>>> GetAllShoesSize();
   
        Task<ServiceResponse<List<ShoesSize>>> GetShoesSizeByThirtyTwo(int thirtyTwo);
        Task<ServiceResponse<List<ShoesSize>>> GetShoesSizeByThirtyThree(int thirtyThree);
        Task<ServiceResponse<List<ShoesSize>>> GetShoesSizeByThirtyFour(int thirtyFour);
        Task<ServiceResponse<List<ShoesSize>>> GetShoesSizeByThirtyFive(int thirtyFive);
        Task<ServiceResponse<ShoesSize>> GetShoesSizeBySchoolId(int schoolId);
        Task<ServiceResponse<ShoesSize>> UpdateShoesSize(ShoesSize shoesSize);
        Task<ServiceResponse<ShoesSize>> CreateShoesSize(ShoesSize shoesSize);
        Task<ServiceResponse<ShoesSize>> DeleteShoesSize(ShoesSize shoesSize);



    }

}