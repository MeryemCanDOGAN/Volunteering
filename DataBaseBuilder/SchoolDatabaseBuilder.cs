using Microsoft.AspNetCore;
using Microsoft.EntityFrameworkCore;
namespace volunteer
{
    public static class SchoolDatabaseBuilder
    {

        static void SetDataToDB(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<School>().HasData(
                            new School
                            {
                                Id = 1,
                                Name = "Büyükşehir İlkÖğretim Okulu",
                                NumberofClass = 6,
                                NumberofStudent = 50,
                                TeacherId = 1,
                                AddressId = 2


                            },
                             new School
                             {
                                 Id = 2,
                                 Name = "Bizimkent İlkÖğretim Okulu",
                                 NumberofClass = 5,
                                 NumberofStudent = 32,
                                 TeacherId = 2,
                                 AddressId = 3


                             },
                               new School
                               {
                                   Id = 3,
                                   Name = "Koç İlkÖğretim Okulu",
                                   NumberofClass = 6,
                                   NumberofStudent = 50,
                                   TeacherId = 1,
                                   AddressId = 2


                               }
            );
        }
        public static void TableBuilder(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<School>(entity =>
           {
               entity.HasKey(e => e.Id);
               entity.Property(e => e.Name);
               entity.Property(e => e.NumberofClass).IsRequired();
               entity.Property(e => e.NumberofStudent).IsRequired();
               entity.Property(e => e.TeacherId).IsRequired();
               entity.Property(e => e.AddressId);
           });
            SetDataToDB(modelBuilder);
        }

    }
}