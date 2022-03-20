using Microsoft.AspNetCore;
using Microsoft.EntityFrameworkCore;
namespace volunteer
{
    public class VolunteerContext : DbContext
    {
        public DbSet<Account>? Accounts { get; set; }
        public DbSet<Role>? Roles { get; set; }
        public DbSet<User>? User { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<StationeryEquipmentList> StationeryEquipmentLists { get; set; }
        public DbSet<ShoesSize> ShoesSizes { get; set; }
        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<HatScarfGloveSize> HatScarfGloveSizes { get; set; }
        public DbSet<CoatSize> CoatSizes{get; set;}
        public DbSet<ListOfRequirements> ListOfRequirements { get; set; }

        







        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 28));
            optionsBuilder.UseMySql("server=localhost;database=voll;user=root;port=3306;password=toortoor", serverVersion);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            AccountDatabaseBuilder.TableBuilder(modelBuilder);
            UserDatabaseBuilder.TableBuilder(modelBuilder);
            AddressDatabaseBuilder.TableBuilder(modelBuilder);
            SchoolDatabaseBuilder.TableBuilder(modelBuilder);
            TeacherDatabaseBuilder.TableBuilder(modelBuilder);
            StationeryEquipmentListDatabaseBuilder.TableBuilder(modelBuilder);
            ShoesSizeDatabaseBuilder.TableBuilder(modelBuilder);
            AnnouncementDatabaseBuilder.TableBuilder(modelBuilder);
            CoatSizeDatabaseBuilder.TableBuilder(modelBuilder);
            HatScarfGloveSizeDatabaseBuilder.TableBuilder(modelBuilder);
            ListOfRequirementsDatabaseBuilder.TableBuilder(modelBuilder);
        }
    }
}