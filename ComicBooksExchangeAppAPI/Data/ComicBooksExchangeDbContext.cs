using Microsoft.EntityFrameworkCore;
using ComicBooksExchangeAppAPI.Models;

namespace ComicBooksExchangeAppAPI.Data
{
    /// <summary>
    /// Database context for the Comic Books Exchange application.
    /// Manages all entity relationships and database operations.
    /// </summary>
    public class ComicBooksExchangeDbContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the ComicBooksExchangeDbContext class.
        /// </summary>
        /// <param name="options">The database context options.</param>
        public ComicBooksExchangeDbContext(DbContextOptions<ComicBooksExchangeDbContext> options)
            : base(options)
        {
        }

        /// <summary>
        /// Gets or sets the Users DbSet for database operations on users.
        /// </summary>
        public DbSet<User> Users { get; set; } = null!;

        /// <summary>
        /// Gets or sets the Comics DbSet for database operations on comics.
        /// </summary>
        public DbSet<Comic> Comics { get; set; } = null!;

        /// <summary>
        /// Gets or sets the Exchanges DbSet for database operations on exchanges.
        /// </summary>
        public DbSet<Exchange> Exchanges { get; set; } = null!;

        /// <summary>
        /// Gets or sets the Transactions DbSet for database operations on transactions.
        /// </summary>
        public DbSet<Transaction> Transactions { get; set; } = null!;

        /// <summary>
        /// Gets or sets the Reviews DbSet for database operations on reviews.
        /// </summary>
        public DbSet<Review> Reviews { get; set; } = null!;

        /// <summary>
        /// Configures the database schema and relationships.
        /// </summary>
        /// <param name="modelBuilder">The model builder used to configure entity relationships.</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure User entity
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Username).IsRequired().HasMaxLength(50);
                entity.Property(e => e.FullName).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Email).IsRequired().HasMaxLength(100);
                entity.Property(e => e.CollectingFocus).HasMaxLength(200);
                entity.Property(e => e.PreferredEras).HasMaxLength(500);
                entity.Property(e => e.FavoriteCharacters).HasMaxLength(500);
                entity.Property(e => e.AverageRating).HasPrecision(5, 2);
                entity.HasIndex(e => e.Username).IsUnique();
                entity.HasIndex(e => e.Email).IsUnique();
            });

            // Configure Comic entity
            modelBuilder.Entity<Comic>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Title).IsRequired().HasMaxLength(200);
                entity.Property(e => e.Publisher).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Characters).HasMaxLength(500);
                entity.Property(e => e.ConditionGrade).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Era).IsRequired().HasMaxLength(100);
                entity.Property(e => e.EstimatedValue).HasPrecision(18, 2);
                entity.Property(e => e.OriginalCoverPrice).HasPrecision(18, 2);
                entity.HasOne(e => e.Owner)
                    .WithMany(u => u.Comics)
                    .HasForeignKey(e => e.OwnerId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            // Configure Exchange entity
            modelBuilder.Entity<Exchange>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Status).IsRequired().HasMaxLength(50);
                entity.Property(e => e.AdditionalValue).HasPrecision(18, 2);
                entity.HasOne(e => e.Initiator)
                    .WithMany(u => u.ExchangesInitiated)
                    .HasForeignKey(e => e.InitiatorId)
                    .OnDelete(DeleteBehavior.Restrict);
                entity.HasOne(e => e.Recipient)
                    .WithMany()
                    .HasForeignKey(e => e.RecipientId)
                    .OnDelete(DeleteBehavior.Restrict);
                entity.HasOne(e => e.OfferedComic)
                    .WithMany()
                    .HasForeignKey(e => e.OfferedComicId)
                    .OnDelete(DeleteBehavior.Restrict);
                entity.HasOne(e => e.RequestedComic)
                    .WithMany()
                    .HasForeignKey(e => e.RequestedComicId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            // Configure Transaction entity
            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.ReferenceNumber).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Status).IsRequired().HasMaxLength(50);
                entity.HasOne(e => e.Exchange)
                    .WithOne(ex => ex.Transaction)
                    .HasForeignKey<Transaction>(e => e.ExchangeId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            // Configure Review entity
            modelBuilder.Entity<Review>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Comment).HasMaxLength(1000);
                entity.HasOne(e => e.Reviewer)
                    .WithMany()
                    .HasForeignKey(e => e.ReviewerId)
                    .OnDelete(DeleteBehavior.Restrict);
                entity.HasOne(e => e.ReviewedUser)
                    .WithMany(u => u.ReviewsReceived)
                    .HasForeignKey(e => e.ReviewedUserId)
                    .OnDelete(DeleteBehavior.Cascade);
                entity.HasOne(e => e.Exchange)
                    .WithMany()
                    .HasForeignKey(e => e.ExchangeId)
                    .OnDelete(DeleteBehavior.Restrict);
            });
        }
    }
}
