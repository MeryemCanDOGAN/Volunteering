using Microsoft.AspNetCore;
using Microsoft.EntityFrameworkCore;
namespace volunteer
{
    public static class CoatSizeDatabaseBuilder
    {

        static void SetDataToDB(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CoatSize>().HasData(
                            new CoatSize
                            {
                                Id = 1,
                                SixandEightYears=10,
                                EightandTenYears=14,
                                TenandTwelveYears=22,
                                TwelveandFourteen=32,
                                SchoolId=2,
                                Counts=null
                                
                               
                            




                            },
                          
                           new CoatSize
                            {
                                Id = 2,
                                SixandEightYears=14,
                                EightandTenYears=15,
                                TenandTwelveYears=11,
                                TwelveandFourteen=12,
                                SchoolId=1,
                                Counts=null
                               
                            




                            },
                           new CoatSize
                            {
                                Id = 3,
                                SixandEightYears=15,
                                EightandTenYears=18,
                                TenandTwelveYears=12,
                                TwelveandFourteen=25,
                                SchoolId=3,
                                Counts=null
                            }
            );
        }
        public static void TableBuilder(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<CoatSize>(entity =>
           {
               entity.HasKey(e => e.Id);
               entity.Property(e => e.SixandEightYears);
               entity.Property(e => e.EightandTenYears);
               entity.Property(e => e.TenandTwelveYears);
               entity.Property(e => e.TwelveandFourteen);
               entity.Property(e => e.SchoolId);
               entity.Property(e=>e.Counts);
            
              

           });
            SetDataToDB(modelBuilder);
        }

    }
}