using Microsoft.AspNetCore;
using Microsoft.EntityFrameworkCore;
namespace volunteer
{
    public static class AccountDatabaseBuilder
    {

        static void SetDataToDB(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>().HasData(
             new Account
             {
                 Id = 1,
                 Email = "meryem.dogan@sahabt.com",
                 Password = "123123",
                 IsBlocked = true,
                 IsVisibility = true,
               

             },
             new Account
             {
                 Id = 2,
                 Email = "fsm@gmail.com",
                 Password = "555555",
                 IsBlocked = true,
                 IsVisibility = true,
               
             },
              new Account
             {
                 Id = 3,
                 Email = "gokhan@gmail.com",
                 Password = "1111111",
                 IsBlocked = true,
                 IsVisibility = true,
                
             },
              new Account
             {
                 Id = 4,
                 Email = "bkagan@gmail.com",
                 Password = "1111111",
                 IsBlocked = true,
                 IsVisibility = true,
                
             }
         );
            
          
        }

        public static void TableBuilder(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
             {
                 entity.HasKey(e => e.Id);
                 entity.Property(e => e.Email).IsRequired();
                 entity.Property(e => e.Password).IsRequired();
                 entity.Property(e => e.IsBlocked);
                 entity.Property(e => e.IsVisibility);
                
                 
                 
                
              

             });
             

           

            SetDataToDB(modelBuilder);
        }
    }
}