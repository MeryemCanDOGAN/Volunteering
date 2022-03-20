using Microsoft.AspNetCore;
using Microsoft.EntityFrameworkCore;
namespace volunteer
{
    public static class HatScarfGloveSizeDatabaseBuilder
    {

        static void SetDataToDB(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HatScarfGloveSize>().HasData(
                            new HatScarfGloveSize
                            {
                                Id = 1,
                                SixandEightYears = 10,
                                EightandTenYears = 12,
                                TenandTwelveYears = 23,
                                TwelveandFourteen = 18,
                                SchoolId = 1,
                                Counts = null
                            },
                            new HatScarfGloveSize
                            {
                                Id = 2,
                                SixandEightYears = 11,
                                EightandTenYears = 33,
                                TenandTwelveYears = 28,
                                TwelveandFourteen = 55,
                                SchoolId = 2,
                                Counts = null
                            },
                              new HatScarfGloveSize
                              {
                                  Id = 3,
                                  SixandEightYears = 32,
                                  EightandTenYears = 26,
                                  TenandTwelveYears = 45,
                                  TwelveandFourteen = 29,
                                  SchoolId = 3,
                                  Counts = null
                              }
            );
        }
        public static void TableBuilder(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<HatScarfGloveSize>(entity =>
           {
               entity.HasKey(e => e.Id);
               entity.Property(e => e.SixandEightYears);
               entity.Property(e => e.EightandTenYears);
               entity.Property(e => e.TenandTwelveYears);
               entity.Property(e => e.TwelveandFourteen);
               entity.Property(e => e.SchoolId);
               entity.Property(e => e.Counts);


           });
            SetDataToDB(modelBuilder);
        }

    }
}