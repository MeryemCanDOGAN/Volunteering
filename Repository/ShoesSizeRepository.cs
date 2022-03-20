using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using volunteer;
public class ShoesSizeRepository : IShoesSizeRepository
{

    private readonly VolunteerContext _context;
    public ShoesSizeRepository(VolunteerContext context)
    {
        _context = context;
    }

    public async Task<ShoesSize> CreateShoesSize(ShoesSize shoesSize)
    {
        await _context.Set<ShoesSize>().AddAsync(shoesSize);
        await _context.SaveChangesAsync();
        return shoesSize;
    }

    public async Task<ShoesSize> DeleteShoesSize(ShoesSize shoesSize)
    {
        _context.ShoesSizes.Remove(shoesSize);
        await _context.SaveChangesAsync();
        return null;
    }

    public async Task<List<ShoesSize>> GetAllShoesSize()
    {
        return await _context.Set<ShoesSize>().ToListAsync();
    }

    
    public async Task<ShoesSize> GetShoesSizeBySchoolId(int schoolId)
    {
        var acoat = await _context.Set<ShoesSize>().SingleOrDefaultAsync(a => a.SchoolId == schoolId);
        if (acoat != null)
        {
            return acoat;
        }
        return null;
    }


  

    public async Task<List<ShoesSize>> GetShoesSizeByThirtyFive(int thirtyFive)
    {
        List<ShoesSize> TotalThirtyFive = await (from shoesSize in _context.ShoesSizes
                                                  orderby shoesSize.ThirtyFive
                                                  group shoesSize by  shoesSize.ThirtyFive into ThirtyFive


                                                  select new ShoesSize()
                                                  { ThirtyFive =ThirtyFive.Key,  Counts = ThirtyFive.Count() }).ToListAsync();

        return TotalThirtyFive;
    }

    public async Task<List<ShoesSize>> GetShoesSizeByThirtyFour(int thirtyFour)
    {
         List<ShoesSize> TotalThirtyFour = await (from shoesSize in _context.ShoesSizes
                                                  orderby shoesSize.ThirtyFour
                                                  group shoesSize by  shoesSize.ThirtyFour into ThirtyFour


                                                  select new ShoesSize()
                                                  { ThirtyFour =ThirtyFour.Key,  Counts = ThirtyFour.Count() }).ToListAsync();

        return TotalThirtyFour;
    }

    public async Task<List<ShoesSize>> GetShoesSizeByThirtyThree(int thirtyThree)
    {
         List<ShoesSize> TotalThirtyThree = await (from shoesSize in _context.ShoesSizes
                                                  orderby shoesSize.ThirtyThree
                                                  group shoesSize by  shoesSize.ThirtyThree into ThirtyThree


                                                  select new ShoesSize()
                                                  { ThirtyThree =ThirtyThree.Key,  Counts = ThirtyThree.Count() }).ToListAsync();

        return TotalThirtyThree;
    }

    public async Task<List<ShoesSize>> GetShoesSizeByThirtyTwo(int thirtyTwo)
    { List<ShoesSize> TotalThirtyTwo = await (from shoesSize in _context.ShoesSizes
                                                  orderby shoesSize.ThirtyTwo
                                                  group shoesSize by  shoesSize.ThirtyTwo into ThirtyTwo


                                                  select new ShoesSize()
                                                  { ThirtyTwo =ThirtyTwo.Key,  Counts = ThirtyTwo.Count() }).ToListAsync();

        return TotalThirtyTwo;
    }


    public async Task<ShoesSize> UpdateShoesSize(ShoesSize shoesSize)
    {
        _context.ShoesSizes.Update(shoesSize);
        await _context.SaveChangesAsync();
        return shoesSize;
    }
}
