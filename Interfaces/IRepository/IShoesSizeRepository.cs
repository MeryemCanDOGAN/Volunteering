namespace volunteer
{
    public interface IShoesSizeRepository
    {
        Task<List<ShoesSize>> GetAllShoesSize();
        Task<List<ShoesSize>>GetShoesSizeByThirtyTwo(int thirtyTwo);
        Task<List<ShoesSize>> GetShoesSizeByThirtyThree(int thirtyThree);
        Task<List<ShoesSize>> GetShoesSizeByThirtyFour(int thirtyFour);
        Task<List<ShoesSize>> GetShoesSizeByThirtyFive(int thirtyFive);
        Task<ShoesSize> GetShoesSizeBySchoolId(int schoolId);
        Task<ShoesSize> UpdateShoesSize(ShoesSize shoesSize);
        Task<ShoesSize> CreateShoesSize(ShoesSize shoesSize);
        Task<ShoesSize> DeleteShoesSize(ShoesSize shoesSize);



    }

}