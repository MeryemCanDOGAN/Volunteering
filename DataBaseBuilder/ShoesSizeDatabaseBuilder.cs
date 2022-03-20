using Microsoft.AspNetCore;
using Microsoft.EntityFrameworkCore;
namespace volunteer
{
    public static class ShoesSizeDatabaseBuilder
    {

        static void SetDataToDB(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ShoesSize>().HasData(
                            new ShoesSize
                            {
                                Id = 1,
                                ThirtyTwo=12,
                                ThirtyThree=16,
                                ThirtyFour=11,
                                ThirtyFive=14,
                                SchoolId=1,
                                Counts=null
                            




                            },
                            new ShoesSize
                            {
                                Id = 2,
                                ThirtyTwo=12,
                                ThirtyThree=13,
                                ThirtyFour=11,
                                ThirtyFive=14,
                                SchoolId=2,
                                Counts=null
                            




                            },
                              new ShoesSize
                            {
                                Id = 3,
                                ThirtyTwo=12,
                                ThirtyThree=6,
                                ThirtyFour=11,
                                ThirtyFive=9,
                                SchoolId=3,
                                Counts=null
                            




                            }
            );
        }
        public static void TableBuilder(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<ShoesSize>(entity =>
           {
               entity.HasKey(e => e.Id);
               entity.Property(e => e.ThirtyTwo);
               entity.Property(e => e.ThirtyThree);
               entity.Property(e => e.ThirtyFour);
               entity.Property(e => e.ThirtyFive);
               entity.Property(e => e.Counts);
              

           });
            SetDataToDB(modelBuilder);
        }

    }
}