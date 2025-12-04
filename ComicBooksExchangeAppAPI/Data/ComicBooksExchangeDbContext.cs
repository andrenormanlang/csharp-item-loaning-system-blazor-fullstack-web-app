using Microsoft.EntityFrameworkCore;
using ComicBooksExchangeAppAPI.Models;

namespace ComicBooksExchangeAppAPI.Data
{
    /// <summary>
    /// Database context for the Comic Books Lending Library application.
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
        /// Configures the database connection and behavior.
        /// </summary>
        /// <param name="optionsBuilder">The options builder for configuring database behavior.</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.ConfigureWarnings(w =>
                w.Ignore(Microsoft.EntityFrameworkCore.Diagnostics.RelationalEventId.PendingModelChangesWarning));
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
        /// Gets or sets the Reviews DbSet for database operations on reviews.
        /// </summary>
        public DbSet<Review> Reviews { get; set; } = null!;

        /// <summary>
        /// Gets or sets the LoanRequests DbSet for database operations on loan requests.
        /// </summary>
        public DbSet<LoanRequest> LoanRequests { get; set; } = null!;

        /// <summary>
        /// Gets or sets the Loans DbSet for database operations on active loans.
        /// </summary>
        public DbSet<Loan> Loans { get; set; } = null!;

        /// <summary>
        /// Gets or sets the Messages DbSet for database operations on private messages.
        /// </summary>
        public DbSet<Message> Messages { get; set; } = null!;

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
                entity.Property(e => e.PreferredEras).HasMaxLength(500);
                entity.Property(e => e.FavoriteCharacters).HasMaxLength(500);
                entity.Property(e => e.AverageRating).HasPrecision(5, 2);
                entity.Property(e => e.ImageUrl).HasMaxLength(500);
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
                entity.Property(e => e.Genre).HasMaxLength(100);
                entity.Property(e => e.CoverImageUrl).HasMaxLength(500);
                entity.HasOne(e => e.Owner)
                    .WithMany(u => u.Comics)
                    .HasForeignKey(e => e.OwnerId)
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
                entity.HasOne(e => e.Loan)
                    .WithMany(l => l.Reviews)
                    .HasForeignKey(e => e.LoanId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .IsRequired(false);
            });

            // Configure LoanRequest entity
            modelBuilder.Entity<LoanRequest>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Status).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Message).HasMaxLength(1000);
                entity.Property(e => e.ResponseMessage).HasMaxLength(1000);
                entity.Property(e => e.ShippingMethod).HasMaxLength(50);
                entity.HasOne(e => e.Requester)
                    .WithMany(u => u.LoanRequestsInitiated)
                    .HasForeignKey(e => e.RequesterId)
                    .OnDelete(DeleteBehavior.Restrict);
                entity.HasOne(e => e.Owner)
                    .WithMany()
                    .HasForeignKey(e => e.OwnerId)
                    .OnDelete(DeleteBehavior.Restrict);
                entity.HasOne(e => e.RequestedComic)
                    .WithMany()
                    .HasForeignKey(e => e.RequestedComicId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            // Configure Loan entity
            modelBuilder.Entity<Loan>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Status).IsRequired().HasMaxLength(50);
                entity.Property(e => e.BorrowerNotes).HasMaxLength(1000);
                entity.Property(e => e.LenderNotes).HasMaxLength(1000);
                entity.Property(e => e.ShippingMethod).HasMaxLength(50);
                entity.Property(e => e.OutboundTrackingNumber).HasMaxLength(100);
                entity.Property(e => e.ReturnTrackingNumber).HasMaxLength(100);
                entity.HasOne(e => e.Borrower)
                    .WithMany(u => u.LoansAsBorrower)
                    .HasForeignKey(e => e.BorrowerId)
                    .OnDelete(DeleteBehavior.Restrict);
                entity.HasOne(e => e.Lender)
                    .WithMany(u => u.LoansAsLender)
                    .HasForeignKey(e => e.LenderId)
                    .OnDelete(DeleteBehavior.Restrict);
                entity.HasOne(e => e.Comic)
                    .WithMany()
                    .HasForeignKey(e => e.ComicId)
                    .OnDelete(DeleteBehavior.Restrict);
                entity.HasOne(e => e.LoanRequest)
                    .WithOne(lr => lr.Loan)
                    .HasForeignKey<Loan>(e => e.LoanRequestId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .IsRequired(false);
            });

            // Configure Message entity
            modelBuilder.Entity<Message>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Content).IsRequired().HasMaxLength(2000);
                entity.Property(e => e.Subject).HasMaxLength(200);
                entity.Property(e => e.SentDate).IsRequired();
                entity.Property(e => e.IsRead).IsRequired().HasDefaultValue(false);
                entity.HasOne(e => e.Sender)
                    .WithMany()
                    .HasForeignKey(e => e.SenderId)
                    .OnDelete(DeleteBehavior.Restrict);
                entity.HasOne(e => e.Receiver)
                    .WithMany()
                    .HasForeignKey(e => e.ReceiverId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            // Seed the database
            DatabaseSeeder.SeedDatabase(modelBuilder);
        }
    }
}
