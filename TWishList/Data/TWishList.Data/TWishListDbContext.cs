namespace TWishList.Data
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using TWishList.Data.Models;
    using TWishList.Data.Models.Identity;

    public class TWishListDbContext : IdentityDbContext<ApplicationUser, IdentityRole, string>
    {
        public TWishListDbContext()
        {
        }

        public TWishListDbContext(DbContextOptions<TWishListDbContext> options)
            : base(options)
        {
        }

        public DbSet<Country> Countries { get; set; }

        public DbSet<DesirableDestination> DesirableDestinations { get; set; }

        public DbSet<Destination> Destinations { get; set; }

        public DbSet<Hotel> Hotels { get; set; }

        public DbSet<Offer> Offers { get; set; }

        public DbSet<OfferCategory> OfferCategories { get; set; }

        public DbSet<TravelCompany> TravelCompanies { get; set; }

        public DbSet<CompanyRequest> CompanyRequests { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<DesirableDestination>()
                .HasOne(x => x.User)
                .WithMany(x => x.DesirableDestinations)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Offer>()
                .HasOne(x => x.Destination)
                .WithMany(x => x.Offers)
                .HasForeignKey(x => x.DestinationId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<TravelCompany>()
                .HasMany(x => x.Offers)
                .WithOne(x => x.Company)
                .HasForeignKey(x => x.CompanyId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Destination>()
                .HasOne(x => x.Country)
                .WithMany(x => x.Destinations)
                .HasForeignKey(x => x.CountryId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Hotel>()
                .HasOne(x => x.Destination)
                .WithMany(x => x.Hotels)
                .HasForeignKey(x => x.DestinationId);

            base.OnModelCreating(builder);
        }
    }
}
