﻿// <auto-generated />
using System;
using MediaApp.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MediaApp.Data.Migrations
{
    [DbContext(typeof(MediaDb))]
    [Migration("20200706111952_AddedMediaSeenTable2")]
    partial class AddedMediaSeenTable2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MediaApp.Domain.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MediaId")
                        .HasColumnType("int");

                    b.Property<string>("PhotoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PublishedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("MediaId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("MediaApp.Domain.FilmGenre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FilmGenres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Drama"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Comedy"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Documentary"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Romantic"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Action"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Science-fiction"
                        });
                });

            modelBuilder.Entity("MediaApp.Domain.MediaTypes.Media", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContentUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("Duration")
                        .HasColumnType("time");

                    b.Property<string>("PhotoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Public")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Media");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Media");
                });

            modelBuilder.Entity("MediaApp.Domain.MediaTypes.MediaSeen", b =>
                {
                    b.Property<int>("MediaId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("MediaId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("MediaSeens");
                });

            modelBuilder.Entity("MediaApp.Domain.MediaTypes.PlaylistMedia", b =>
                {
                    b.Property<int>("MediaId")
                        .HasColumnType("int");

                    b.Property<int>("PlaylistId")
                        .HasColumnType("int");

                    b.HasKey("MediaId", "PlaylistId");

                    b.HasIndex("PlaylistId");

                    b.ToTable("PlaylistMedias");
                });

            modelBuilder.Entity("MediaApp.Domain.MusicGenre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MusicGenres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Pop"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Rock"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Dance"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Classical"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Elevator music"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Country"
                        },
                        new
                        {
                            Id = 7,
                            Description = "K-pop"
                        });
                });

            modelBuilder.Entity("MediaApp.Domain.Playlist<MediaApp.Domain.MediaTypes.Media>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<TimeSpan>("Duration")
                        .HasColumnType("time");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Public")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Playlists");
                });

            modelBuilder.Entity("MediaApp.Domain.PodcastGenre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PodcastGenres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "History"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Religious"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Drama"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Sports"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Comedy"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Crime"
                        },
                        new
                        {
                            Id = 7,
                            Description = "Technology"
                        },
                        new
                        {
                            Id = 8,
                            Description = "Environment/Science"
                        },
                        new
                        {
                            Id = 9,
                            Description = "Interview"
                        },
                        new
                        {
                            Id = 10,
                            Description = "News & Politics"
                        });
                });

            modelBuilder.Entity("MediaApp.Domain.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MediaId")
                        .HasColumnType("int");

                    b.Property<string>("PhotoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PublishedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ReviewId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MediaId");

                    b.HasIndex("ReviewId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("MediaApp.Domain.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<int>("BookmarkedFilmsId")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("PhotoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            AccessFailedCount = 0,
                            BookmarkedFilmsId = 0,
                            ConcurrencyStamp = "53b314cd-91ff-4f37-aba3-4e6305a7f114",
                            Email = "admin@email.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "admin@email.com",
                            NormalizedUserName = "admin@email.com",
                            PasswordHash = "AP+8Ll2uLLWr67Bd62cfEYkrUgiVP4ZKpeO/1daeN54O03igLMfDUjtPwhgklFJT/w==",
                            PhoneNumberConfirmed = false,
                            PhotoUrl = "/users/admin.png",
                            SecurityStamp = "e661d002-ef45-4721-9875-c5d6d6a6da9f",
                            TwoFactorEnabled = false,
                            UserName = "admin@email.com"
                        },
                        new
                        {
                            Id = "2",
                            AccessFailedCount = 0,
                            BookmarkedFilmsId = 0,
                            ConcurrencyStamp = "9560d4c2-275f-41d8-b4b3-1e0ed65706fe",
                            Email = "user@email.com",
                            EmailConfirmed = true,
                            LockoutEnabled = true,
                            NormalizedEmail = "user@email.com",
                            NormalizedUserName = "user@email.com",
                            PasswordHash = "AFlet1MC04wYzS2u0ymWa/CEK7zRklnJS+pzTr91PcSEQy4PkHgpSh0anpwhR9Hvxw==",
                            PhoneNumberConfirmed = false,
                            PhotoUrl = "/users/user.png",
                            SecurityStamp = "df026fd5-2fe9-441e-b865-1a2ee1cc4443",
                            TwoFactorEnabled = false,
                            UserName = "user@email.com"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            ConcurrencyStamp = "387bb216-768b-450d-97a5-e9b2dccdda9e",
                            Name = "Admin",
                            NormalizedName = "Admin"
                        },
                        new
                        {
                            Id = "2",
                            ConcurrencyStamp = "a8da3d34-8e77-464a-be77-68d5ee63977f",
                            Name = "User",
                            NormalizedName = "User"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "1",
                            RoleId = "1"
                        },
                        new
                        {
                            UserId = "2",
                            RoleId = "2"
                        },
                        new
                        {
                            UserId = "eb96f0ca-8373-45af-bffe-d804fd6f4ded",
                            RoleId = "2"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("MediaApp.Domain.MediaTypes.Film", b =>
                {
                    b.HasBaseType("MediaApp.Domain.MediaTypes.Media");

                    b.Property<string>("Director")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.HasIndex("GenreId");

                    b.HasDiscriminator().HasValue("Film");
                });

            modelBuilder.Entity("MediaApp.Domain.MediaTypes.Music", b =>
                {
                    b.HasBaseType("MediaApp.Domain.MediaTypes.Media");

                    b.Property<int>("GenreId")
                        .HasColumnName("Music_GenreId")
                        .HasColumnType("int");

                    b.Property<string>("Singer")
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("GenreId");

                    b.HasDiscriminator().HasValue("Music");
                });

            modelBuilder.Entity("MediaApp.Domain.MediaTypes.Podcast", b =>
                {
                    b.HasBaseType("MediaApp.Domain.MediaTypes.Media");

                    b.Property<int>("GenreId")
                        .HasColumnName("Podcast_GenreId")
                        .HasColumnType("int");

                    b.Property<string>("Organisation")
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("GenreId");

                    b.HasDiscriminator().HasValue("Podcast");
                });

            modelBuilder.Entity("MediaApp.Domain.MediaTypes.Series", b =>
                {
                    b.HasBaseType("MediaApp.Domain.MediaTypes.Media");

                    b.Property<string>("Broadcaster")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenreId")
                        .HasColumnName("Series_GenreId")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfEpisodes")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfSeasons")
                        .HasColumnType("int");

                    b.HasIndex("GenreId");

                    b.HasDiscriminator().HasValue("Series");
                });

            modelBuilder.Entity("MediaApp.Domain.Comment", b =>
                {
                    b.HasOne("MediaApp.Domain.MediaTypes.Media", "Media")
                        .WithMany("Comments")
                        .HasForeignKey("MediaId");
                });

            modelBuilder.Entity("MediaApp.Domain.MediaTypes.Media", b =>
                {
                    b.HasOne("MediaApp.Domain.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("MediaApp.Domain.MediaTypes.MediaSeen", b =>
                {
                    b.HasOne("MediaApp.Domain.MediaTypes.Media", "Media")
                        .WithMany()
                        .HasForeignKey("MediaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MediaApp.Domain.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MediaApp.Domain.MediaTypes.PlaylistMedia", b =>
                {
                    b.HasOne("MediaApp.Domain.MediaTypes.Media", "Media")
                        .WithMany("PlaylistMedias")
                        .HasForeignKey("MediaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MediaApp.Domain.Playlist<MediaApp.Domain.MediaTypes.Media>", "Playlist")
                        .WithMany("PlaylistMedias")
                        .HasForeignKey("PlaylistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MediaApp.Domain.Playlist<MediaApp.Domain.MediaTypes.Media>", b =>
                {
                    b.HasOne("MediaApp.Domain.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("MediaApp.Domain.Review", b =>
                {
                    b.HasOne("MediaApp.Domain.MediaTypes.Media", null)
                        .WithMany("Reviews")
                        .HasForeignKey("MediaId");

                    b.HasOne("MediaApp.Domain.Review", null)
                        .WithMany("Reviews")
                        .HasForeignKey("ReviewId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("MediaApp.Domain.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("MediaApp.Domain.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MediaApp.Domain.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("MediaApp.Domain.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MediaApp.Domain.MediaTypes.Film", b =>
                {
                    b.HasOne("MediaApp.Domain.FilmGenre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("MediaApp.Domain.MediaTypes.Music", b =>
                {
                    b.HasOne("MediaApp.Domain.MusicGenre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("MediaApp.Domain.MediaTypes.Podcast", b =>
                {
                    b.HasOne("MediaApp.Domain.PodcastGenre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("MediaApp.Domain.MediaTypes.Series", b =>
                {
                    b.HasOne("MediaApp.Domain.FilmGenre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
