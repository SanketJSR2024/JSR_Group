using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAcesss.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

        public DbSet<HotelRoom> HotelRooms { get; set; }

        public DbSet<HotelRoomImage> HotelRoomImages { get; set; }

        public DbSet<HotelAmenity> HotelAmenities { get; set; }

        public DbSet<ApplicationUser> ApplicationUser { get; set; }

        public DbSet<RoomOrderDetails> RoomOrderDetails { get; set; }

        public DbSet<AcceptanceCriteria> AcceptanceCriteria { get; set; }

        public DbSet<Company> Company { get; set; }

        public DbSet<CompanySoftware> CompanySoftware { get; set; }

        public DbSet<CriteriaBasket> CriteriaBasket { get; set; }

        public DbSet<DefectType> DefectType { get; set; }

        public DbSet<FactoryDetails> FactoryDetails { get; set; }

        public DbSet<ImageProcessReq> ImageProcessReq { get; set; }

        public DbSet<Manufacturer> Manufacturer { get; set; }

        public DbSet<ProjectDetails> ProjectDetails { get; set; }

        public DbSet<Site> Site { get; set; }

        public DbSet<TextInImage> TextInImage { get; set; }

        public DbSet<CompanyEmployee> CompanyEmployee { get; set; }

        public DbSet<CompanyAdmin> CompanyAdmin { get; set; }

        public DbSet<CompanyCustomer> CompanyCustomer { get; set; }

        public DbSet<SoftwareVersion> SoftwareVersion { get; set; }

        public DbSet<SoftwareVersionFeatures> SoftwareVersionFeatures { get; set; }

        public DbSet<Feature> Feature { get; set; }

        public DbSet<ImageProcessData> ImageProcessData { get; set; }
    }
}
