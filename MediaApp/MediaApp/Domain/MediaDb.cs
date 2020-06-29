using MediaApp.Domain.MediaTypes;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace MediaApp.Domain
{
    public class MediaDb : IdentityDbContext<User>
    {
        public MediaDb(DbContextOptions<MediaDb> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Status>().HasData(
                new Status() { Id = 1, Description = "Experienced" },
                new Status() { Id = 2, Description = "Want to experience" }
                );

            modelBuilder.Entity<MusicGenre>().HasData(
                new MusicGenre() { Id = 1, Description = "Pop" },
                new MusicGenre() { Id = 2, Description = "Rock" },
                new MusicGenre() { Id = 3, Description = "Dance" },
                new MusicGenre() { Id = 4, Description = "Classical" },
                new MusicGenre() { Id = 5, Description = "Elevator music" },
                new MusicGenre() { Id = 6, Description = "Country" },
                new MusicGenre() { Id = 7, Description = "K-pop" }
                );

            modelBuilder.Entity<FilmGenre>().HasData(
                new FilmGenre() { Id = 1, Description = "Drama" },
                new FilmGenre() { Id = 2, Description = "Comedy" },
                new FilmGenre() { Id = 3, Description = "Documentary" },
                new FilmGenre() { Id = 4, Description = "Romantic" },
                new FilmGenre() { Id = 5, Description = "Action" },
                new FilmGenre() { Id = 6, Description = "Science-fiction" }
                );

            modelBuilder.Entity<PodcastGenre>().HasData(
               new PodcastGenre() { Id = 1, Description = "History" },
               new PodcastGenre() { Id = 2, Description = "Religious" },
               new PodcastGenre() { Id = 3, Description = "Drama" },
               new PodcastGenre() { Id = 4, Description = "Sports" },
               new PodcastGenre() { Id = 5, Description = "Comedy" },
               new PodcastGenre() { Id = 6, Description = "Crime" },
               new PodcastGenre() { Id = 7, Description = "Technology" },
               new PodcastGenre() { Id = 8, Description = "Environment/Science" },
               new PodcastGenre() { Id = 9, Description = "Interview" },
               new PodcastGenre() { Id = 10, Description = "News & Politics" }
               );
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole() { Id=1.ToString(), Name = "Admin", NormalizedName= "Admin" },
                new IdentityRole() { Id = 2.ToString(), Name = "User", NormalizedName= "User" }
                );
            modelBuilder.Entity<User>().HasData(
                new User() {
                    PasswordHash = HashPassword("password"),
                    Id = 1.ToString(),
                    UserName = "admin@email.com",
                    NormalizedUserName = "admin@email.com",
                    Email = "admin@email.com",
                    NormalizedEmail = "admin@email.com",
                    EmailConfirmed = true,
                    LockoutEnabled = false,
                    SecurityStamp = Guid.NewGuid().ToString(),
                    PhotoUrl = "/users/" + "admin.png"
                },
                new User()
                {
                    PasswordHash = HashPassword("password"),
                    Id = 2.ToString(),
                    UserName = "user@email.com",
                    NormalizedUserName = "user@email.com",
                    Email = "user@email.com",
                    NormalizedEmail = "user@email.com",
                    EmailConfirmed = true,
                    LockoutEnabled = true,
                    SecurityStamp = Guid.NewGuid().ToString(),
                    PhotoUrl = "/users/" + "user.png"
                });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>()
                {
                    RoleId = 1.ToString(),
                    UserId = 1.ToString(),
                },
                new IdentityUserRole<string>()
                {
                    RoleId = 2.ToString(),
                    UserId = 2.ToString(),
                },
                new IdentityUserRole<string>()
                {
                    RoleId = 2.ToString(),
                    UserId = "eb96f0ca-8373-45af-bffe-d804fd6f4ded"
                }
                
            );

            modelBuilder.Entity<MediaComment>().HasKey(mc => new { mc.MediaId, mc.CommentId });

            modelBuilder.Entity<MediaComment>()
                .HasOne(mc => mc.Comment)
                .WithMany(m => m.MediaComments)
                .HasForeignKey(mc => mc.CommentId);

            modelBuilder.Entity<MediaComment>()
                .HasOne(mc => mc.Media)
                .WithMany(m => m.MediaComments)
                .HasForeignKey(mc => mc.MediaId);

            modelBuilder.Entity<MediaReview>().HasKey(mr => new { mr.MediaId, mr.ReviewId });

            modelBuilder.Entity<MediaReview>()
                .HasOne(mr => mr.Review)
                .WithMany(m => m.MediaReviews)
                .HasForeignKey(mr => mr.ReviewId);

            modelBuilder.Entity<MediaReview>()
                .HasOne(mr => mr.Media)
                .WithMany(m => m.MediaReviews)
                .HasForeignKey(mr => mr.MediaId);

            modelBuilder.Entity<Series>().HasOne(x => x.Genre).WithMany().OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Film>().HasOne(x => x.Genre).WithMany().OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Music>().HasOne(x => x.Genre).WithMany().OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Podcast>().HasOne(x => x.Genre).WithMany().OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Media>().HasOne(x => x.Status).WithMany().OnDelete(DeleteBehavior.NoAction);

        }
        public DbSet<Media> Media { get; set; }
        public DbSet<Film> Films{ get; set; }
        public DbSet<Music> Music { get; set; }
        public DbSet<Podcast> Podcasts { get; set; }
        public DbSet<Series> Series { get; set; }
        public DbSet<MusicGenre> MusicGenres { get; set; }
        public DbSet<PodcastGenre> PodcastGenres { get; set; }
        public DbSet<FilmGenre> FilmGenres { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<MediaComment> MediaComments { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<MediaReview> Mediareviews { get; set; }
        public DbSet<Status> Statuses { get; set; }
        private static string HashPassword(string password)
        {
            byte[] salt;
            byte[] buffer2;
            if (password == null)
            {
                throw new ArgumentNullException("password");
            }
            using (Rfc2898DeriveBytes bytes = new Rfc2898DeriveBytes(password, 0x10, 0x3e8))
            {
                salt = bytes.Salt;
                buffer2 = bytes.GetBytes(0x20);
            }
            byte[] dst = new byte[0x31];
            Buffer.BlockCopy(salt, 0, dst, 1, 0x10);
            Buffer.BlockCopy(buffer2, 0, dst, 0x11, 0x20);
            return Convert.ToBase64String(dst);
        }
    }
}
