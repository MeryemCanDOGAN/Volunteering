using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using volunteer;
public class CoatSizeRepository : ICoatSizeRepository
{

    private readonly VolunteerContext _context;
    public CoatSizeRepository(VolunteerContext context)
    {
        _context = context;
    }

    public async Task<CoatSize> CreateCoatSize(CoatSize coatSize)
    {
        await _context.Set<CoatSize>().AddAsync(coatSize);
        await _context.SaveChangesAsync();
        return coatSize;
    }

    public async Task<CoatSize> DeleteCoatSize(CoatSize coatSize)
    {
        _context.CoatSizes.Remove(coatSize);
        await _context.SaveChangesAsync();
        return null;
    }

    public async Task<List<CoatSize>> GetAllCoatSize()
    {
        return await _context.Set<CoatSize>().ToListAsync();
    }

    public async Task<List<CoatSize>> GetCoatSizeByEightandTenYears(int eightandTenYears)

    {
        List<CoatSize> TotalEightandTen = await (from coatsize in _context.CoatSizes
                                                 orderby coatsize.EightandTenYears
                                                 group coatsize by coatsize.EightandTenYears into EightandTenYears


                                                 select new CoatSize()
                                                 { EightandTenYears = EightandTenYears.Key, Counts = EightandTenYears.Count() }).ToListAsync();

        return TotalEightandTen;

    }

    public async Task<CoatSize> GetCoatSizeBySchoolId(int schoolId)
    {
        var acoat = await _context.Set<CoatSize>().SingleOrDefaultAsync(a => a.SchoolId == schoolId);
        if (acoat != null)
        {
            return acoat;
        }
        return null;
    }

    public async Task<List<CoatSize>> GetCoatSizeBySixandEightYears(int sixandEightYears)
    {
        List<CoatSize> TotalSixandEight = await (from coatsize in _context.CoatSizes
                                                 orderby coatsize.SixandEightYears
                                                 group coatsize by coatsize.SixandEightYears into SixandEightYears


                                                 select new CoatSize()
                                                 { SixandEightYears = SixandEightYears.Key, Counts = SixandEightYears.Count() }).ToListAsync();

        return TotalSixandEight;




    }

    public async Task<List<CoatSize>> GetCoatSizeByTenandTwelveYears(int tenandTwelveYears)
    {
        List<CoatSize> TotalTenandTwelve = await (from coatsize in _context.CoatSizes
                                                  orderby coatsize.TenandTwelveYears
                                                  group coatsize by coatsize.TenandTwelveYears into TenandTwelveYears


                                                  select new CoatSize()
                                                  { TenandTwelveYears = TenandTwelveYears.Key, Counts = TenandTwelveYears.Count() }).ToListAsync();

        return TotalTenandTwelve;
    }

    public async Task<List<CoatSize>> GetCoatSizeByTwelveandFourteenYears(int twelveandFourteen)
    {
        List<CoatSize> TotalTwelveandFourteen = await (from coatsize in _context.CoatSizes
                                                       orderby coatsize.TwelveandFourteen
                                                       group coatsize by coatsize.TwelveandFourteen into TwelveandFourteen


                                                       select new CoatSize()
                                                       { TenandTwelveYears = TwelveandFourteen.Key, Counts = TwelveandFourteen.Count() }).ToListAsync();

        return TotalTwelveandFourteen;
    }

    public async Task<CoatSize> UpdateCoatSize(CoatSize coatSize)
    {
        _context.CoatSizes.Update(coatSize);
        await _context.SaveChangesAsync();
        return coatSize;
    }
}
