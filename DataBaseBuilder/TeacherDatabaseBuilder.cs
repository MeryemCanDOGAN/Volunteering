using Microsoft.AspNetCore;
using Microsoft.EntityFrameworkCore;
namespace volunteer
{
    public static class TeacherDatabaseBuilder
    {

        static void SetDataToDB(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teacher>().HasData(
                            new Teacher
                            {
                                Id = 1,
                                Name = "Ayşe",
                                Surname = "Demir",
                                PhoneNumber = 5555222,
                                Branch = "Sınıf Ogretmeni"




                            },
                             new Teacher
                             {
                                 Id = 2,
                                 Name = "Mehmet",
                                 Surname = "Demir",
                                 PhoneNumber = 5555222,
                                 Branch = "Sınıf Ogretmeni"



                             },
                               new Teacher
                               {
                                   Id = 3,
                                   Name = "Fatma",
                                   Surname = "Demir",
                                   PhoneNumber = 5555222,
                                   Branch = "Sınıf Ogretmeni"


                               }
            );
        }
        public static void TableBuilder(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Teacher>(entity =>
           {
               entity.HasKey(e => e.Id);
               entity.Property(e => e.Name);
               entity.Property(e => e.Surname ).IsRequired();
               entity.Property(e => e.PhoneNumber).IsRequired();
               entity.Property(e => e.Branch).IsRequired();
               
           });
            SetDataToDB(modelBuilder);
        }

    }
}