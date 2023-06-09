﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SwiftOrder_Server.Data;

#nullable disable

namespace SwiftOrder_Server.Migrations
{
    [DbContext(typeof(SwiftOrderDbContext))]
    partial class SwiftOrderDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.4");

            modelBuilder.Entity("SwiftOrder_Server.Model.Kiosk", b =>
                {
                    b.Property<int>("KioskID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsKitchen")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsPaid")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RestaurantID")
                        .HasColumnType("INTEGER");

                    b.HasKey("KioskID");

                    b.ToTable("Kiosk");
                });

            modelBuilder.Entity("SwiftOrder_Server.Model.Menu", b =>
                {
                    b.Property<int>("MenuID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("MenuAvailability")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MenuDescription")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MenuImage")
                        .HasColumnType("TEXT");

                    b.Property<string>("MenuName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("MenuPrice")
                        .HasColumnType("REAL");

                    b.Property<int>("RestaurantID")
                        .HasColumnType("INTEGER");

                    b.HasKey("MenuID");

                    b.ToTable("Menu");
                });

            modelBuilder.Entity("SwiftOrder_Server.Model.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("INTEGER");

                    b.Property<int>("KioskID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MenuID")
                        .HasColumnType("INTEGER");

                    b.HasKey("OrderID");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("SwiftOrder_Server.Model.Restaurant", b =>
                {
                    b.Property<int>("RestaurantID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("RestaurantName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("numTables")
                        .HasColumnType("INTEGER");

                    b.HasKey("RestaurantID");

                    b.ToTable("Restaurant");
                });

            modelBuilder.Entity("SwiftOrder_Server.Model.Table", b =>
                {
                    b.Property<int>("TableID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("RestaurantID")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("TableAvailability")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TableNumber")
                        .HasColumnType("INTEGER");

                    b.HasKey("TableID");

                    b.ToTable("Table");
                });
#pragma warning restore 612, 618
        }
    }
}
