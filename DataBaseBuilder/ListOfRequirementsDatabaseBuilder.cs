using Microsoft.AspNetCore;
using Microsoft.EntityFrameworkCore;
namespace volunteer
{
    public static class ListOfRequirementsDatabaseBuilder
    {

        static void SetDataToDB(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ListOfRequirements>().HasData(
                            new ListOfRequirements
                            {
                                Id = 1,
                                HatScarfGloveSizeId = 1,
                                ShoesSizeId = 1,
                                CoatSizeId = 1,
                                StationeryEquipmentListId = 1





                            },
                            new ListOfRequirements
                            {
                                Id = 2,
                                HatScarfGloveSizeId = 1,
                                ShoesSizeId = 2,
                                CoatSizeId = 3,
                                StationeryEquipmentListId = 1





                            }
            );
        }
        public static void TableBuilder(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<ListOfRequirements>(entity =>
           {
               entity.HasKey(e => e.Id);
               entity.Property(e => e.CoatSizeId);
               entity.Property(e => e.HatScarfGloveSizeId);
               entity.Property(e => e.ShoesSizeId);
               entity.Property(e => e.StationeryEquipmentListId);



           });
            SetDataToDB(modelBuilder);
        }

    }
}