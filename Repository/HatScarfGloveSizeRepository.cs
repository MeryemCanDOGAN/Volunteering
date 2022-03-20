using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using volunteer;
public class HatScarfGloveSizeRepository : IHatScarfGloveSizeRepository
{

    private readonly VolunteerContext _context;
    public HatScarfGloveSizeRepository(VolunteerContext context)
    {
        _context = context;
    }

    public async Task<HatScarfGloveSize> CreateHatScarfGloveSize(HatScarfGloveSize hatScarfGloveSize)
    {
         await _context.Set<HatScarfGloveSize>().AddAsync(hatScarfGloveSize);
        await _context.SaveChangesAsync();
        return hatScarfGloveSize;
    }

    public async Task<HatScarfGloveSize> DeleteHatScarfGloveSize(HatScarfGloveSize hatScarfGloveSize)
    {
         _context.HatScarfGloveSizes.Remove(hatScarfGloveSize);
        await _context.SaveChangesAsync();
        return null;
    }

    public async Task<List<HatScarfGloveSize>> GetAllHatScarfGloveSize()
    {
         return await _context.Set<HatScarfGloveSize>().ToListAsync();
    }

    public async Task<List<HatScarfGloveSize>> GetHatScarfGloveSizeByEightandTenYears(int eightandTenYears)
    {
             List<HatScarfGloveSize> TotalEightandTen = await (from coatsize in _context.HatScarfGloveSizes
                                                 orderby coatsize.EightandTenYears
                                                 group coatsize by coatsize.EightandTenYears into EightandTenYears


                                                 select new HatScarfGloveSize()
                                                 { EightandTenYears = EightandTenYears.Key, Counts = EightandTenYears.Count() }).ToListAsync();

        return TotalEightandTen;
    }

    public async Task<HatScarfGloveSize> GetHatScarfGloveSizeBySchoolId(int schoolId)
    {
         var acoat = await _context.Set<HatScarfGloveSize>().SingleOrDefaultAsync(a => a.SchoolId == schoolId);
        if (acoat != null)
        {
            return acoat;
        }
        return null;
    }

    public async Task<List<HatScarfGloveSize>> GetHatScarfGloveSizeBySixandEightYears(int sixandEightYears)
    {
              List<HatScarfGloveSize> TotalSixandEight = await (from coatsize in _context.HatScarfGloveSizes
                                                 orderby coatsize.SixandEightYears
                                                 group coatsize by coatsize.SixandEightYears into SixandEightYears


                                                 select new HatScarfGloveSize()
                                                 { SixandEightYears = SixandEightYears.Key, Counts = SixandEightYears.Count() }).ToListAsync();

        return TotalSixandEight;
    }

    public async Task<List<HatScarfGloveSize>> GetHatScarfGloveSizeByTenandTwelveYears(int tenandTwelveYears)
    {
         List<HatScarfGloveSize> TotalTenandTwelve = await (from coatsize in _context.HatScarfGloveSizes
                                                  orderby coatsize.TenandTwelveYears
                                                  group coatsize by coatsize.TenandTwelveYears into TenandTwelveYears


                                                  select new HatScarfGloveSize()
                                                  { TenandTwelveYears = TenandTwelveYears.Key, Counts = TenandTwelveYears.Count() }).ToListAsync();

        return TotalTenandTwelve;
    }

    public async Task<List<HatScarfGloveSize>> GetHatScarfGloveSizeByTwelveandFourteenYears(int twelveandFourteen)
    {
           List<HatScarfGloveSize> TotalTwelveandFourteen = await (from coatsize in _context.HatScarfGloveSizes
                                                       orderby coatsize.TwelveandFourteen
                                                       group coatsize by coatsize.TwelveandFourteen into TwelveandFourteen


                                                       select new HatScarfGloveSize()
                                                       { TenandTwelveYears = TwelveandFourteen.Key, Counts = TwelveandFourteen.Count() }).ToListAsync();

        return TotalTwelveandFourteen;
    }

    public async Task<HatScarfGloveSize> UpdateHatScarfGloveSize( HatScarfGloveSize hatScarfGloveSize)
    {
        _context.HatScarfGloveSizes.Update(hatScarfGloveSize);
        await _context.SaveChangesAsync();
        return hatScarfGloveSize;
    }
}

