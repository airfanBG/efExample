﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(MusicStoreDbContext))]
    partial class MusicStoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Models.Entities.Artist", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.HasKey("Id");

                    b.ToTable("Artists");

                    b.HasData(
                        new
                        {
                            Id = "22ecb652-02a4-443d-bda2-b87110b1e6a3",
                            Name = "Iggy pop"
                        },
                        new
                        {
                            Id = "c9edb6ef-a960-4804-9509-009b8afb01e4",
                            Name = "Pink floyd"
                        });
                });

            modelBuilder.Entity("Models.Entities.ArtistSongs", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ArtistId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SongId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ArtistId");

                    b.HasIndex("SongId");

                    b.ToTable("ArtistSongs");

                    b.HasData(
                        new
                        {
                            Id = "82347660-2457-42e4-889a-03eed623499a",
                            ArtistId = "22ecb652-02a4-443d-bda2-b87110b1e6a3",
                            SongId = "804bcc44-2298-4010-91af-d8b98c3aa11d"
                        });
                });

            modelBuilder.Entity("Models.Entities.CommercialStuff", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("CommercialStuffs");
                });

            modelBuilder.Entity("Models.Entities.DiscountKey", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<decimal>("Discount")
                        .HasColumnType("numeric");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("OrderId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("DiscountKeys");
                });

            modelBuilder.Entity("Models.Entities.Employee", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Models.Entities.Genre", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("GenreType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = "4dae8ae7-ab6a-4492-9bbb-c763b4d16f60",
                            GenreType = "Pop"
                        },
                        new
                        {
                            Id = "c4e2e8bd-b4a9-46ce-935e-a32bd978dfca",
                            GenreType = "Rock"
                        });
                });

            modelBuilder.Entity("Models.Entities.GenreSongs", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("GenreId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SongId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.HasIndex("SongId");

                    b.ToTable("GenreSongs");

                    b.HasData(
                        new
                        {
                            Id = "5cb38899-6b77-4a99-9f57-bc2527b3f7cf",
                            GenreId = "4dae8ae7-ab6a-4492-9bbb-c763b4d16f60",
                            SongId = "804bcc44-2298-4010-91af-d8b98c3aa11d"
                        });
                });

            modelBuilder.Entity("Models.Entities.Order", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<decimal>("Total")
                        .HasColumnType("numeric");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Models.Entities.Song", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("Duration")
                        .HasColumnType("integer");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Year")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Songs");

                    b.HasData(
                        new
                        {
                            Id = "804bcc44-2298-4010-91af-d8b98c3aa11d",
                            Duration = 1100,
                            Image = "url",
                            Title = "Hello",
                            Year = 2000
                        },
                        new
                        {
                            Id = "8924356d-f9a5-407e-b3c7-659f3486bf12",
                            Duration = 3451,
                            Image = "url",
                            Title = "Test",
                            Year = 2005
                        });
                });

            modelBuilder.Entity("Models.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = "9bb7691d-8eb7-49c1-bcc4-4d643bdf5c75",
                            Username = "Pesho"
                        },
                        new
                        {
                            Id = "145520a3-281b-4186-8a82-3c1ec51d0fd4",
                            Username = "Gosho"
                        });
                });

            modelBuilder.Entity("Models.Entities.ArtistSongs", b =>
                {
                    b.HasOne("Models.Entities.Artist", "Artist")
                        .WithMany("ArtistSongs")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Entities.Song", "Song")
                        .WithMany("ArtistSongs")
                        .HasForeignKey("SongId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");

                    b.Navigation("Song");
                });

            modelBuilder.Entity("Models.Entities.DiscountKey", b =>
                {
                    b.HasOne("Models.Entities.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Models.Entities.GenreSongs", b =>
                {
                    b.HasOne("Models.Entities.Genre", "Genre")
                        .WithMany("GenreSongs")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Entities.Song", "Song")
                        .WithMany("GenreSongs")
                        .HasForeignKey("SongId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");

                    b.Navigation("Song");
                });

            modelBuilder.Entity("Models.Entities.Order", b =>
                {
                    b.HasOne("Models.Entities.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Models.Entities.Artist", b =>
                {
                    b.Navigation("ArtistSongs");
                });

            modelBuilder.Entity("Models.Entities.Genre", b =>
                {
                    b.Navigation("GenreSongs");
                });

            modelBuilder.Entity("Models.Entities.Song", b =>
                {
                    b.Navigation("ArtistSongs");

                    b.Navigation("GenreSongs");
                });

            modelBuilder.Entity("Models.Entities.User", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
