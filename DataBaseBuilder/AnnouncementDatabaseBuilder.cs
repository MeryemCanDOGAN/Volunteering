using Microsoft.AspNetCore;
using Microsoft.EntityFrameworkCore;
namespace volunteer
{
    public static class AnnouncementDatabaseBuilder
    {

        static void SetDataToDB(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Announcement>().HasData(
                            new Announcement
                            {
                                Id = 1,
                                SchoolId=2,
                                ADetails="Köy okullarına yardım için kırtasiye ürünleri topluyoruz.",
                                ReleaseDate=DateTime.Today
                            },
                                new Announcement
                            {
                                Id = 2,
                                SchoolId=3,
                                ADetails="Köy okullarındaki öğrenci kardeşlerimizin Mont, Bot, Çanta eksiklerini birlikte tamamlayalım.",
                                ReleaseDate=DateTime.Today
                            },
                                  new Announcement
                            {
                                Id = 3,
                                SchoolId=1,
                                ADetails="Az çok demeyelim , Köy okullarındaki öğrenci kardeşlerimizin Mont, Bot, Çanta eksiklerini birlikte tamamlayalım.",
                                ReleaseDate=DateTime.Today
                            }
                      
            );
        }
        public static void TableBuilder(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Announcement>(entity =>
           {
               entity.HasKey(e => e.Id);
               entity.Property(e => e.SchoolId);
               entity.Property(e=>e.ADetails);
               entity.Property(e=>e.ReleaseDate);
         
              

           });
            SetDataToDB(modelBuilder);
        }

    }
}