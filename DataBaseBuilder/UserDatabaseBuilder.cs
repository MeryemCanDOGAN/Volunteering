using Microsoft.AspNetCore;
using Microsoft.EntityFrameworkCore;
namespace volunteer
{
    public static class UserDatabaseBuilder
    {

        static void SetDataToDB(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Gender>().HasData(
                            new Gender
                            {
                                Id = 1,
                                Name = "Woman"
                            },
                               new Gender
                               {
                                   Id = 2,
                                   Name = "Man"
                               },
                               new Gender
                               {
                                   Id = 3,
                                   Name = "Other"
                               }
            );
            modelBuilder.Entity<Role>().HasData(
                            new Role
                            {
                                Id = 1,
                                Name = "Admin"
                            },
                               new Role
                               {
                                   Id = 2,
                                   Name = "Volunteer"
                               },
                               new Role
                               {
                                   Id = 3,
                                   Name = "Teacher"
                               }
                            
            );

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    FirstName = "Meryem Can",
                    LastName = "Dogan",
                    Username = "mcan",
                    PhoneNumber = 1231231,
                    GenderId = 1,
                    RoleId = 1,
                    AccountId = 1,
                    BirthDate = DateTime.Today,
                    AddressId=1


                },
                new User
                {
                    Id = 2,
                    FirstName = "Fatih Sultan Mehmet",
                    LastName = "Dogan",
                    Username = "fsm",
                    PhoneNumber = 12312312,
                    GenderId = 2,
                    RoleId = 2,
                    AccountId = 2,
                    BirthDate = DateTime.Today,
                    AddressId=2

                },
                 new User
                 {
                     Id = 3,
                     FirstName = "Gökhan",
                     LastName = "Dogan",
                     Username = "gkhn",
                     PhoneNumber = 123123123,
                     GenderId = 2,
                     RoleId = 3,
                     AccountId = 3,
                     BirthDate = DateTime.Today,
                     AddressId=3

                 },
                  new User
                  {
                      Id = 4,
                      FirstName = "Bilge Kagan",
                      LastName = "Dogan",
                      Username = "bkgn",
                      PhoneNumber = 123123123,
                      GenderId = 2,
                      RoleId = 2,
                      AccountId = 4,
                      BirthDate = DateTime.Today,
                      AddressId=2

                  }


            );

        }

        public static void TableBuilder(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>(entity =>
           {
               entity.HasKey(e => e.Id);
               entity.Property(e => e.FirstName).IsRequired();
               entity.Property(e => e.LastName).IsRequired();
               entity.Property(e => e.Username).IsRequired();
               entity.Property(e => e.BirthDate);
               entity.Property(e => e.PhoneNumber);
               entity.Property(e => e.GenderId);
               entity.Property(e => e.RoleId);
               entity.Property(e => e.AccountId);
               entity.Property(e=>e.AddressId);

               entity.HasOne(e => e.Account);


               entity.HasOne(e => e.Role).WithMany(e => e.User).HasForeignKey(e => e.RoleId);



              
           });

            SetDataToDB(modelBuilder);
        }
    }
}