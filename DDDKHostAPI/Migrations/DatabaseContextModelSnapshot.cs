﻿// <auto-generated />
using System;
using DDDKHostAPI.Models.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DDDKHostAPI.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DDDKHostAPI.Models.Data.BloodType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhFactor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BloodTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "A",
                            PhFactor = "+"
                        },
                        new
                        {
                            Id = 2,
                            Name = "A",
                            PhFactor = "-"
                        },
                        new
                        {
                            Id = 3,
                            Name = "B",
                            PhFactor = "+"
                        },
                        new
                        {
                            Id = 4,
                            Name = "B",
                            PhFactor = "-"
                        },
                        new
                        {
                            Id = 5,
                            Name = "AB",
                            PhFactor = "+"
                        },
                        new
                        {
                            Id = 6,
                            Name = "AB",
                            PhFactor = "-"
                        },
                        new
                        {
                            Id = 7,
                            Name = "0",
                            PhFactor = "+"
                        },
                        new
                        {
                            Id = 8,
                            Name = "0",
                            PhFactor = "-"
                        });
                });

            modelBuilder.Entity("DDDKHostAPI.Models.Data.Donation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DonationEventId")
                        .HasColumnType("int");

                    b.Property<int>("DonatorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DonationEventId");

                    b.HasIndex("DonatorId");

                    b.ToTable("Donations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DonationEventId = 1,
                            DonatorId = 3
                        },
                        new
                        {
                            Id = 2,
                            DonationEventId = 1,
                            DonatorId = 1
                        },
                        new
                        {
                            Id = 3,
                            DonationEventId = 2,
                            DonatorId = 1
                        },
                        new
                        {
                            Id = 4,
                            DonationEventId = 1,
                            DonatorId = 2
                        },
                        new
                        {
                            Id = 5,
                            DonationEventId = 2,
                            DonatorId = 2
                        });
                });

            modelBuilder.Entity("DDDKHostAPI.Models.Data.DonationEvent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EventDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.ToTable("DonationEvents");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Akcija dobrovoljnog darovanja krvi u D. Crnjelovu 2021",
                            EventDate = new DateTime(2021, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LocationId = 2
                        },
                        new
                        {
                            Id = 2,
                            Description = "Akcija dobrovoljnog darovanja krvi u Magnojevicu 2022",
                            EventDate = new DateTime(2022, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LocationId = 3
                        });
                });

            modelBuilder.Entity("DDDKHostAPI.Models.Data.Donator", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("BloodTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PreviousDonations")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("BloodTypeId");

                    b.ToTable("Donators");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Address = "Dusana Baranina 1/C/10, Bijeljina",
                            BirthDate = new DateTime(1986, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BloodTypeId = 7,
                            Email = "aleksbn417@gmail.com",
                            FirstName = "Aleksandar",
                            LastName = "Matic",
                            PhoneNumber = "065/417-302",
                            PreviousDonations = 5
                        },
                        new
                        {
                            ID = 2,
                            Address = "Vrulja bb, Donje Crnjelovo",
                            BirthDate = new DateTime(1958, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BloodTypeId = 5,
                            Email = "pperic@gmail.com",
                            FirstName = "Petar",
                            LastName = "Peric",
                            PhoneNumber = "065/257-417",
                            PreviousDonations = 89
                        },
                        new
                        {
                            ID = 3,
                            Address = "Gavrila Principa 14/22, Bijeljina",
                            BirthDate = new DateTime(2000, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BloodTypeId = 5,
                            Email = "ivanas@gmail.com",
                            FirstName = "Ivana",
                            LastName = "Stevic",
                            PhoneNumber = "065/741-956",
                            PreviousDonations = 1
                        },
                        new
                        {
                            ID = 4,
                            Address = "Mala Obarska BB",
                            BirthDate = new DateTime(2001, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BloodTypeId = 6,
                            Email = "majag@gmail.com",
                            FirstName = "Maja",
                            LastName = "Gobeljic",
                            PhoneNumber = "065/778-332",
                            PreviousDonations = 2
                        });
                });

            modelBuilder.Entity("DDDKHostAPI.Models.Data.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Škola u Donjem Crnjelovu",
                            Name = "Donje Crnjelovo"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Dom omladine",
                            Name = "Magnojević"
                        },
                        new
                        {
                            Id = 3,
                            Description = "OŠ Knez Ivo od Semberije",
                            Name = "Bijeljina - Dašnjica 1"
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
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "53007191-e5ce-4260-8232-1b437cfbca86",
                            ConcurrencyStamp = "335bd86a-532a-4660-88c9-047907ccd273",
                            Name = "Admin",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "b35da6de-94a4-4a7d-95fe-6f7b32293e2d",
                            ConcurrencyStamp = "65ccb399-7c4f-4fce-83c8-33d5337aeaf1",
                            Name = "Mod",
                            NormalizedName = "MODERATOR"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("DDDKHostAPI.Models.Data.Donation", b =>
                {
                    b.HasOne("DDDKHostAPI.Models.Data.DonationEvent", "DonationEvent")
                        .WithMany()
                        .HasForeignKey("DonationEventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DDDKHostAPI.Models.Data.Donator", "Donator")
                        .WithMany("Donations")
                        .HasForeignKey("DonatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DonationEvent");

                    b.Navigation("Donator");
                });

            modelBuilder.Entity("DDDKHostAPI.Models.Data.DonationEvent", b =>
                {
                    b.HasOne("DDDKHostAPI.Models.Data.Location", "Location")
                        .WithMany("DonationEvents")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");
                });

            modelBuilder.Entity("DDDKHostAPI.Models.Data.Donator", b =>
                {
                    b.HasOne("DDDKHostAPI.Models.Data.BloodType", "BloodType")
                        .WithMany("Donators")
                        .HasForeignKey("BloodTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BloodType");
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DDDKHostAPI.Models.Data.BloodType", b =>
                {
                    b.Navigation("Donators");
                });

            modelBuilder.Entity("DDDKHostAPI.Models.Data.Donator", b =>
                {
                    b.Navigation("Donations");
                });

            modelBuilder.Entity("DDDKHostAPI.Models.Data.Location", b =>
                {
                    b.Navigation("DonationEvents");
                });
#pragma warning restore 612, 618
        }
    }
}