using Microsoft.AspNetCore;
using Microsoft.EntityFrameworkCore;
namespace volunteer
{
    public static class StationeryEquipmentListDatabaseBuilder
    {

        static void SetDataToDB(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StationeryEquipmentList>().HasData(
                            new StationeryEquipmentList
                            {
                                Id = 1,
                                Book = 25,
                                Notebook = 100,
                                Pencil = 180,
                                Eraser = 190,
                                Backpack = 120,
                                Lunchbox = 120,
                                SchoolId = 1,
                                Counts = null




                            },
                             new StationeryEquipmentList
                             {
                                 Id = 2,
                                 Book = 90,
                                 Notebook = 200,
                                 Pencil = 250,
                                 Eraser = 300,
                                 Backpack = 155,
                                 Lunchbox = 155,
                                 SchoolId = 2,
                                 Counts = null






                             },
                              new StationeryEquipmentList
                              {
                                  Id = 3,
                                  Book = 25,
                                  Notebook = 100,
                                  Pencil = 180,
                                  Eraser = 165,
                                  Backpack = 80,
                                  Lunchbox = 80,
                                  SchoolId = 3,
                                  Counts = null




                              }
            );
        }
        public static void TableBuilder(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<StationeryEquipmentList>(entity =>
           {
               entity.HasKey(e => e.Id);
               entity.Property(e => e.Book);
               entity.Property(e => e.Notebook);
               entity.Property(e => e.Pencil);
               entity.Property(e => e.Eraser);
               entity.Property(e => e.Backpack);
               entity.Property(e => e.Lunchbox);
               entity.Property(e => e.SchoolId);
               entity.Property(e => e.Counts);



           });
            SetDataToDB(modelBuilder);
        }

    }
}