using Microsoft.AspNetCore;
using Microsoft.EntityFrameworkCore;
namespace volunteer
{
    public static class AddressDatabaseBuilder
    {

        static void SetDataToDB(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>().HasData(
                            new Address
                            {
                                Id = 1,
                                OpenAddress = "Beylikdüzü/İstanbul",
                                CityId = 1,
                                DistrictId = 1
                            },
                               new Address
                               {
                                   Id = 2,
                                   OpenAddress = "İzmir/Avcılar",
                                   CityId = 2,
                                   DistrictId = 2

                               },
                               new Address
                               {
                                   Id = 3,
                                   OpenAddress = "Ankara/Büyükçekmece",
                                   CityId = 3,
                                   DistrictId = 3
                               }
            );

            modelBuilder.Entity<City>().HasData(
                            new City
                            {
                                Id = 1,
                                Name = "İstanbul"

                            },
                               new City
                               {
                                   Id = 2,
                                   Name = "İzmir"

                               },
                               new City
                               {
                                   Id = 3,
                                   Name = "Ankara"

                               }
            );
            modelBuilder.Entity<District>().HasData(
                            new District
                            {
                                Id = 1,
                                Name = "Beylikdüzü",
                                CityId = 1
                            },
                               new District
                               {
                                   Id = 2,
                                   Name = "Avcılar",
                                   CityId = 2,
                               },
                               new District
                               {
                                   Id = 3,
                                   Name = "Büyükçekmece",
                                   CityId = 3
                               }
            );
        }
        public static void TableBuilder(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Address>(entity =>
           {
               entity.HasKey(e => e.Id);
               entity.Property(e => e.OpenAddress).IsRequired();
               entity.Property(e => e.CityId);
               entity.Property(e => e.DistrictId);



           });
            modelBuilder.Entity<City>(entity =>
          {
              entity.HasKey(e => e.Id);
              entity.Property(e => e.Name).IsRequired();


          });
            modelBuilder.Entity<District>(entity =>
          {
              entity.HasKey(e => e.Id);
              entity.Property(e => e.Name).IsRequired();
              entity.HasOne(e => e.City).WithMany(e => e.District).HasForeignKey(e => e.CityId);



          });

            SetDataToDB(modelBuilder);
        }
    }
}