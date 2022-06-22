﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShopManagement.Infrastructure.EFCore;

namespace ShopManagement.Infrastructure.EFCore.Migrations
{
    [DbContext(typeof(ShopContext))]
    [Migration("20220622071742_initOrderAndOrderItems")]
    partial class initOrderAndOrderItems
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ShopManagement.Domain.OrderAgg.Order", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsCanceled")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPaid")
                        .HasColumnType("bit");

                    b.Property<string>("IssueTrackingNo")
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<int>("PaymentMethod")
                        .HasColumnType("int");

                    b.Property<long>("RefId")
                        .HasColumnType("bigint");

                    b.Property<long>("TotalAmount")
                        .HasColumnType("bigint");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ShopManagement.Domain.OrderItemAgg.OrderItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("OrderId")
                        .HasColumnType("bigint");

                    b.Property<long>("SellerProductId")
                        .HasColumnType("bigint");

                    b.Property<long>("UnitPrice")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("ShopManagement.Domain.ProductAgg.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CountryMadeIn")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descriotion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dimensions")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("EngTitle")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("FarsiTitle")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("PartNumber")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Picture")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<long>("ProductBrandId")
                        .HasColumnType("bigint");

                    b.Property<long>("ProductModelId")
                        .HasColumnType("bigint");

                    b.Property<long>("ProductStatusId")
                        .HasColumnType("bigint");

                    b.Property<long>("ProductTypeId")
                        .HasColumnType("bigint");

                    b.Property<long>("ProductUsageTypeId")
                        .HasColumnType("bigint");

                    b.Property<int>("ProductWeight")
                        .HasColumnType("int");

                    b.Property<string>("Slug")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.HasIndex("ProductBrandId");

                    b.HasIndex("ProductModelId");

                    b.HasIndex("ProductStatusId");

                    b.HasIndex("ProductTypeId");

                    b.HasIndex("ProductUsageTypeId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ShopManagement.Domain.ProductCategoryAgg.ProductBrandAgg.ProductBrand", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EngTitle")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("FarsiTitle")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.ToTable("ProductBrands");
                });

            modelBuilder.Entity("ShopManagement.Domain.ProductCategoryAgg.ProductModelAgg.ProductModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EngTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FarsiTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("ProductBrandId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("ProductBrandId");

                    b.ToTable("ProductModels");
                });

            modelBuilder.Entity("ShopManagement.Domain.ProductCategoryAgg.ProductStatusAgg.ProductStatus", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EngTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FarsiTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductStatuses");
                });

            modelBuilder.Entity("ShopManagement.Domain.ProductCategoryAgg.ProductTypeAgg.ProductType", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EngTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FarsiTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductTypes");
                });

            modelBuilder.Entity("ShopManagement.Domain.ProductCategoryAgg.ProductUsageTypeAgg.ProductUsageType", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EngTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FarsiTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductUsageTypes");
                });

            modelBuilder.Entity("ShopManagement.Domain.SellerPanelAgg.SellerPanel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("BuyersCategory")
                        .HasColumnType("int");

                    b.Property<bool>("CanMarketerSee")
                        .HasColumnType("bit");

                    b.Property<string>("Capital")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("City")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("CompanyEconomicCode")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("CompanyName")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("CompanyRegistrationCode")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DeliveryDurationForCapital")
                        .HasColumnType("int");

                    b.Property<int>("DeliveryDurationForCity")
                        .HasColumnType("int");

                    b.Property<int>("DeliveryDurationForOther")
                        .HasColumnType("int");

                    b.Property<bool>("IsConfirmedByAdmin")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSpecial")
                        .HasColumnType("bit");

                    b.Property<bool>("IsUserLegal")
                        .HasColumnType("bit");

                    b.Property<string>("SellerMobileNumber")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("StoreName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.Property<int>("WarrantyAmount")
                        .HasColumnType("int");

                    b.Property<int>("WarrantyTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("SellerPanels");
                });

            modelBuilder.Entity("ShopManagement.Domain.SellerProductAgg.SellerProduct", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BuyersCategory")
                        .HasColumnType("int");

                    b.Property<bool>("CanMarketerSee")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DeliveryDurationForCapital")
                        .HasColumnType("int");

                    b.Property<int>("DeliveryDurationForCity")
                        .HasColumnType("int");

                    b.Property<int>("DeliveryDurationForOther")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsConfirmedBySeller")
                        .HasColumnType("bit");

                    b.Property<long>("MarketerShareAmount")
                        .HasColumnType("bigint");

                    b.Property<int>("MarketerSharePercent")
                        .HasColumnType("int");

                    b.Property<long>("Price")
                        .HasColumnType("bigint");

                    b.Property<long>("ProductId")
                        .HasColumnType("bigint");

                    b.Property<long>("SellerPanelId")
                        .HasColumnType("bigint");

                    b.Property<int>("WarrantyAmount")
                        .HasColumnType("int");

                    b.Property<int>("WarrantyTypeId")
                        .HasColumnType("int");

                    b.Property<bool>("isConfirmedByAdmin")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("SellerPanelId");

                    b.ToTable("SellerProducts");
                });

            modelBuilder.Entity("ShopManagement.Domain.SellerProductMediaAgg.SellerProductMedia", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsMediaImage")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSelectedBySeller")
                        .HasColumnType("bit");

                    b.Property<string>("MediaAlt")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("MediaTitle")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("MediaURL")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<long>("SellerProductId")
                        .HasColumnType("bigint");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("SellerProductMedias");
                });

            modelBuilder.Entity("ShopManagement.Domain.OrderItemAgg.OrderItem", b =>
                {
                    b.HasOne("ShopManagement.Domain.OrderAgg.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("ShopManagement.Domain.ProductAgg.Product", b =>
                {
                    b.HasOne("ShopManagement.Domain.ProductCategoryAgg.ProductBrandAgg.ProductBrand", "ProductBrand")
                        .WithMany("Products")
                        .HasForeignKey("ProductBrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShopManagement.Domain.ProductCategoryAgg.ProductModelAgg.ProductModel", "ProductModel")
                        .WithMany("Products")
                        .HasForeignKey("ProductModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShopManagement.Domain.ProductCategoryAgg.ProductStatusAgg.ProductStatus", "ProductStatus")
                        .WithMany("Products")
                        .HasForeignKey("ProductStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShopManagement.Domain.ProductCategoryAgg.ProductTypeAgg.ProductType", "ProductType")
                        .WithMany("Products")
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShopManagement.Domain.ProductCategoryAgg.ProductUsageTypeAgg.ProductUsageType", "ProductUsageType")
                        .WithMany("Products")
                        .HasForeignKey("ProductUsageTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductBrand");

                    b.Navigation("ProductModel");

                    b.Navigation("ProductStatus");

                    b.Navigation("ProductType");

                    b.Navigation("ProductUsageType");
                });

            modelBuilder.Entity("ShopManagement.Domain.ProductCategoryAgg.ProductModelAgg.ProductModel", b =>
                {
                    b.HasOne("ShopManagement.Domain.ProductCategoryAgg.ProductBrandAgg.ProductBrand", "ProductBrand")
                        .WithMany("ProductModels")
                        .HasForeignKey("ProductBrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductBrand");
                });

            modelBuilder.Entity("ShopManagement.Domain.SellerProductAgg.SellerProduct", b =>
                {
                    b.HasOne("ShopManagement.Domain.ProductAgg.Product", "Product")
                        .WithMany("SellerProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShopManagement.Domain.SellerPanelAgg.SellerPanel", "SellerPanel")
                        .WithMany("SellerProducts")
                        .HasForeignKey("SellerPanelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("SellerPanel");
                });

            modelBuilder.Entity("ShopManagement.Domain.OrderAgg.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("ShopManagement.Domain.ProductAgg.Product", b =>
                {
                    b.Navigation("SellerProducts");
                });

            modelBuilder.Entity("ShopManagement.Domain.ProductCategoryAgg.ProductBrandAgg.ProductBrand", b =>
                {
                    b.Navigation("ProductModels");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("ShopManagement.Domain.ProductCategoryAgg.ProductModelAgg.ProductModel", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("ShopManagement.Domain.ProductCategoryAgg.ProductStatusAgg.ProductStatus", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("ShopManagement.Domain.ProductCategoryAgg.ProductTypeAgg.ProductType", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("ShopManagement.Domain.ProductCategoryAgg.ProductUsageTypeAgg.ProductUsageType", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("ShopManagement.Domain.SellerPanelAgg.SellerPanel", b =>
                {
                    b.Navigation("SellerProducts");
                });
#pragma warning restore 612, 618
        }
    }
}
