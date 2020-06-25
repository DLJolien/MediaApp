using MediaApp.Domain.MediaTypes;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaApp.Domain
{
    public class MediaDb : IdentityDbContext<MediaUser>
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
    }
}
