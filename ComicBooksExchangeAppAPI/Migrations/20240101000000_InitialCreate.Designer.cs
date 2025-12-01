using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ComicBooksExchangeAppAPI.Migrations
{
    [DbContext(typeof(ComicBooksExchangeAppAPI.Data.ComicBooksExchangeDbContext))]
    [Migration("20240101000000_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("ComicBooksExchangeAppAPI.Models.Comic", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<string>("Characters")
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnType("TEXT");

                b.Property<string>("CollectorNotes")
                    .HasColumnType("TEXT");

                b.Property<string>("ConditionDescription")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<string>("ConditionGrade")
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnType("TEXT");

                b.Property<DateTime>("DateListed")
                    .HasColumnType("TEXT");

                b.Property<string>("Era")
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("TEXT");

                b.Property<decimal>("EstimatedValue")
                    .HasColumnType("TEXT");

                b.Property<bool>("IsAvailable")
                    .HasColumnType("INTEGER");

                b.Property<bool>("IsKeyIssue")
                    .HasColumnType("INTEGER");

                b.Property<bool>("IsProfessionallyGraded")
                    .HasColumnType("INTEGER");

                b.Property<int>("IssueNumber")
                    .HasColumnType("INTEGER");

                b.Property<string>("KeyIssueDescription")
                    .HasColumnType("TEXT");

                b.Property<decimal>("OriginalCoverPrice")
                    .HasColumnType("TEXT");

                b.Property<int>("OwnerId")
                    .HasColumnType("INTEGER");

                b.Property<DateTime>("PublicationDate")
                    .HasColumnType("TEXT");

                b.Property<string>("ProfessionalGradeInfo")
                    .HasColumnType("TEXT");

                b.Property<string>("Publisher")
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("TEXT");

                b.Property<string>("Title")
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnType("TEXT");

                b.HasKey("Id");

                b.HasIndex("OwnerId");

                b.ToTable("Comics");
            });

            modelBuilder.Entity("ComicBooksExchangeAppAPI.Models.Exchange", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<decimal?>("AdditionalValue")
                    .HasColumnType("TEXT");

                b.Property<DateTime>("DateCreated")
                    .HasColumnType("TEXT");

                b.Property<DateTime?>("DateCompleted")
                    .HasColumnType("TEXT");

                b.Property<DateTime?>("DateResponded")
                    .HasColumnType("TEXT");

                b.Property<int>("InitiatorId")
                    .HasColumnType("INTEGER");

                b.Property<string>("OfferMessage")
                    .HasColumnType("TEXT");

                b.Property<int>("OfferedComicId")
                    .HasColumnType("INTEGER");

                b.Property<int>("RecipientId")
                    .HasColumnType("INTEGER");

                b.Property<int>("RequestedComicId")
                    .HasColumnType("INTEGER");

                b.Property<string>("Status")
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnType("TEXT");

                b.HasKey("Id");

                b.HasIndex("InitiatorId");

                b.HasIndex("OfferedComicId");

                b.HasIndex("RecipientId");

                b.HasIndex("RequestedComicId");

                b.ToTable("Exchanges");
            });

            modelBuilder.Entity("ComicBooksExchangeAppAPI.Models.Review", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<string>("Comment")
                    .HasMaxLength(1000)
                    .HasColumnType("TEXT");

                b.Property<bool>("CommunicationRating")
                    .HasColumnType("INTEGER");

                b.Property<bool>("ConditionAsDescribed")
                    .HasColumnType("INTEGER");

                b.Property<DateTime>("DateSubmitted")
                    .HasColumnType("TEXT");

                b.Property<int>("ExchangeId")
                    .HasColumnType("INTEGER");

                b.Property<int>("Rating")
                    .HasColumnType("INTEGER");

                b.Property<int>("ReviewedUserId")
                    .HasColumnType("INTEGER");

                b.Property<int>("ReviewerId")
                    .HasColumnType("INTEGER");

                b.Property<bool>("ShippingPackagingRating")
                    .HasColumnType("INTEGER");

                b.HasKey("Id");

                b.HasIndex("ExchangeId");

                b.HasIndex("ReviewedUserId");

                b.HasIndex("ReviewerId");

                b.ToTable("Reviews");
            });

            modelBuilder.Entity("ComicBooksExchangeAppAPI.Models.Transaction", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<DateTime>("DateInitiated")
                    .HasColumnType("TEXT");

                b.Property<DateTime?>("DateReceived")
                    .HasColumnType("TEXT");

                b.Property<DateTime?>("DateShipped")
                    .HasColumnType("TEXT");

                b.Property<string>("DisputeDetails")
                    .HasColumnType("TEXT");

                b.Property<int>("ExchangeId")
                    .HasColumnType("INTEGER");

                b.Property<bool>("HasDispute")
                    .HasColumnType("INTEGER");

                b.Property<string>("ReferenceNumber")
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnType("TEXT");

                b.Property<string>("ReceivedConditionNotes")
                    .HasColumnType("TEXT");

                b.Property<string>("Status")
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnType("TEXT");

                b.Property<string>("TrackingNumber")
                    .HasColumnType("TEXT");

                b.HasKey("Id");

                b.HasIndex("ExchangeId");

                b.ToTable("Transactions");
            });

            modelBuilder.Entity("ComicBooksExchangeAppAPI.Models.User", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<decimal>("AverageRating")
                    .HasColumnType("TEXT");

                b.Property<string>("Biography")
                    .HasColumnType("TEXT");

                b.Property<string>("CollectingFocus")
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnType("TEXT");

                b.Property<string>("Email")
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("TEXT");

                b.Property<string>("FavoriteCharacters")
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnType("TEXT");

                b.Property<string>("FullName")
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("TEXT");

                b.Property<bool>("IsVerified")
                    .HasColumnType("INTEGER");

                b.Property<string>("Location")
                    .HasColumnType("TEXT");

                b.Property<DateTime>("MemberSince")
                    .HasColumnType("TEXT");

                b.Property<string>("PhoneNumber")
                    .HasColumnType("TEXT");

                b.Property<string>("PreferredEras")
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnType("TEXT");

                b.Property<string>("PreferredExchangeMethod")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<int>("SuccessfulExchanges")
                    .HasColumnType("INTEGER");

                b.Property<string>("TradePreferences")
                    .HasColumnType("TEXT");

                b.Property<string>("Username")
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnType("TEXT");

                b.HasKey("Id");

                b.HasIndex("Email")
                    .IsUnique();

                b.HasIndex("Username")
                    .IsUnique();

                b.ToTable("Users");
            });

            modelBuilder.Entity("ComicBooksExchangeAppAPI.Models.Comic", b =>
            {
                b.HasOne("ComicBooksExchangeAppAPI.Models.User", "Owner")
                    .WithMany("Comics")
                    .HasForeignKey("OwnerId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Owner");
            });

            modelBuilder.Entity("ComicBooksExchangeAppAPI.Models.Exchange", b =>
            {
                b.HasOne("ComicBooksExchangeAppAPI.Models.User", "Initiator")
                    .WithMany("ExchangesInitiated")
                    .HasForeignKey("InitiatorId")
                    .OnDelete(DeleteBehavior.Restrict)
                    .IsRequired();

                b.HasOne("ComicBooksExchangeAppAPI.Models.Comic", "OfferedComic")
                    .WithMany()
                    .HasForeignKey("OfferedComicId")
                    .OnDelete(DeleteBehavior.Restrict)
                    .IsRequired();

                b.HasOne("ComicBooksExchangeAppAPI.Models.User", "Recipient")
                    .WithMany()
                    .HasForeignKey("RecipientId")
                    .OnDelete(DeleteBehavior.Restrict)
                    .IsRequired();

                b.HasOne("ComicBooksExchangeAppAPI.Models.Comic", "RequestedComic")
                    .WithMany()
                    .HasForeignKey("RequestedComicId")
                    .OnDelete(DeleteBehavior.Restrict)
                    .IsRequired();

                b.Navigation("Initiator");
                b.Navigation("OfferedComic");
                b.Navigation("Recipient");
                b.Navigation("RequestedComic");
            });

            modelBuilder.Entity("ComicBooksExchangeAppAPI.Models.Review", b =>
            {
                b.HasOne("ComicBooksExchangeAppAPI.Models.Exchange", "Exchange")
                    .WithMany()
                    .HasForeignKey("ExchangeId")
                    .OnDelete(DeleteBehavior.Restrict)
                    .IsRequired();

                b.HasOne("ComicBooksExchangeAppAPI.Models.User", "ReviewedUser")
                    .WithMany("ReviewsReceived")
                    .HasForeignKey("ReviewedUserId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("ComicBooksExchangeAppAPI.Models.User", "Reviewer")
                    .WithMany()
                    .HasForeignKey("ReviewerId")
                    .OnDelete(DeleteBehavior.Restrict)
                    .IsRequired();

                b.Navigation("Exchange");
                b.Navigation("ReviewedUser");
                b.Navigation("Reviewer");
            });

            modelBuilder.Entity("ComicBooksExchangeAppAPI.Models.Transaction", b =>
            {
                b.HasOne("ComicBooksExchangeAppAPI.Models.Exchange", "Exchange")
                    .WithOne("Transaction")
                    .HasForeignKey("ComicBooksExchangeAppAPI.Models.Transaction", "ExchangeId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Exchange");
            });

            modelBuilder.Entity("ComicBooksExchangeAppAPI.Models.Exchange", b =>
            {
                b.Navigation("Transaction");
            });

            modelBuilder.Entity("ComicBooksExchangeAppAPI.Models.User", b =>
            {
                b.Navigation("Comics");
                b.Navigation("ExchangesInitiated");
                b.Navigation("ReviewsReceived");
            });
#pragma warning restore 612, 618
        }
    }
}
