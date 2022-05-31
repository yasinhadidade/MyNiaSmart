﻿// <auto-generated />
using System;
using AccountManagement.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AccountManagement.Infrastructure.EFCore.Migrations
{
    [DbContext(typeof(AccountContext))]
    partial class AccountContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AccountManagement.Domain.CooperationRequestAgg.UserCooperationRequest", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("PersonalityId")
                        .HasColumnType("bigint");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("PersonalityId");

                    b.HasIndex("UserId");

                    b.ToTable("UserCooperationRequests");
                });

            modelBuilder.Entity("AccountManagement.Domain.PersonalityAgg.Personality", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("PersonalityTypeId")
                        .HasColumnType("bigint");

                    b.Property<string>("Title")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("PersonalityTypeId");

                    b.ToTable("Personalities");
                });

            modelBuilder.Entity("AccountManagement.Domain.PersonalityTypeAgg.PersonalityType", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.ToTable("PersonalityTypes");
                });

            modelBuilder.Entity("AccountManagement.Domain.RejectionReasonAgg.RejectionReason", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.HasKey("Id");

                    b.ToTable("RejectionReasons");
                });

            modelBuilder.Entity("AccountManagement.Domain.RoleAgg.Role", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsRemoved")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<long?>("RoleTypeId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("RoleTypeId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("AccountManagement.Domain.RoleTypeAgg.RoleType", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsRemoved")
                        .HasColumnType("bit");

                    b.Property<string>("RoleTypeName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("RoleTypes");
                });

            modelBuilder.Entity("AccountManagement.Domain.UPAccountRequestsAgg.UpAccountRequest", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BD_CreditCardBackSide")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("BD_CreditCardFrontSide")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("BD_ShabaPrint")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("BI_BankAccountNumber")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("BI_BankName")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("BI_CreditCardNumber")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<bool>("BI_IsCreditCardWithFullInfo")
                        .HasColumnType("bit");

                    b.Property<string>("BI_ShabaNumber")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Capital")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("City")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("GD_ChequeBackSide")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("GD_ChequeFrontSide")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("GD_SafteBackSide")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("GD_SafteFrontSide")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("GI_ChequeBankBranch")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("GI_ChequeNumber")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<bool>("GI_IsChequeGuarantyType")
                        .HasColumnType("bit");

                    b.Property<string>("GI_SafteNumber")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("GI_ShenaseSayadiCheque")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<bool>("IsRequestConfirmedByAdmin")
                        .HasColumnType("bit");

                    b.Property<bool>("IsRequestConfirmedByClient")
                        .HasColumnType("bit");

                    b.Property<string>("PD_IdentityCard")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("PD_NationalCardBackSide")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("PD_NationalCardFrontSide")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("PD_NationalCodeTrackingPaper")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<DateTime>("PI_BirthdayDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PI_FUllName")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("PI_FatherName")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("PI_IdentityNumber")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<bool>("PI_IsMale")
                        .HasColumnType("bit");

                    b.Property<bool>("PI_IsNewIdentity")
                        .HasColumnType("bit");

                    b.Property<bool>("PI_IsNewNationalCard")
                        .HasColumnType("bit");

                    b.Property<string>("PI_NationalCode")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<DateTime>("PI_RegistrationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RejectionReason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("UpAccountRequests");
                });

            modelBuilder.Entity("AccountManagement.Domain.UpAccountRequestRejectionReasonAgg.UpAccountRequestRejectionReason", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("RejectionReasonId")
                        .HasColumnType("bigint");

                    b.Property<long>("UpAccountRequestId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("RejectionReasonId");

                    b.HasIndex("UpAccountRequestId");

                    b.ToTable("UpAccountRequestRejectionReasons");
                });

            modelBuilder.Entity("AccountManagement.Domain.UserAgg.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActiveCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("Capital")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("City")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("Experience")
                        .HasColumnType("bigint");

                    b.Property<string>("FullName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.Property<string>("IntroductorFullname")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("IntroductorMobileNumber")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<bool>("IsClient")
                        .HasColumnType("bit");

                    b.Property<string>("MobileNumber")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("NationalCode")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ProfilePhoto")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AccountManagement.Domain.UserPersonalityAgg.UserPersonality", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("PersonalityId")
                        .HasColumnType("bigint");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("PersonalityId");

                    b.HasIndex("UserId");

                    b.ToTable("UserPersonalities");
                });

            modelBuilder.Entity("AccountManagement.Domain.UserRoleAgg.UserRole", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("AccountManagement.Domain.WalletAgg.BusinessWalletAgg.BusinessWallet", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CardNumber")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.Property<string>("OwnerFullName")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("OwnerRegistrationDate")
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("BusinessWallets");
                });

            modelBuilder.Entity("AccountManagement.Domain.WalletAgg.OperationTypeAgg.WalletOperationType", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("OperationTypeTitle")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.ToTable("WalletOperationTypes");
                });

            modelBuilder.Entity("AccountManagement.Domain.WalletAgg.PersonalWalletChartAgg.PersonalWalletChart", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("Balance")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("BalanceUpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("PersonalwalletId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("PersonalwalletId");

                    b.ToTable("PersonalWalletCharts");
                });

            modelBuilder.Entity("AccountManagement.Domain.WalletAgg.PersonalWalletOperationAgg.Personalwalletoperation", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("Amount")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DepositeType")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsPay")
                        .HasColumnType("bit");

                    b.Property<long>("PersonalWalletId")
                        .HasColumnType("bigint");

                    b.Property<string>("ReceiverFullName")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("SenderFullName")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("VerifyCode")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<long>("WalletOperationTypeId")
                        .HasColumnType("bigint");

                    b.Property<int>("WithdrawStatus")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonalWalletId");

                    b.HasIndex("WalletOperationTypeId");

                    b.ToTable("PersonalWalletOperations");
                });

            modelBuilder.Entity("AccountManagement.Domain.WalletAgg.PersonalwalletAgg.PersonalWallet", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BalanceUpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CardNumber")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.Property<string>("OwnerFullName")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("OwnerRegistrationDate")
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.Property<long>("WalletBalance")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("PersonalWallets");
                });

            modelBuilder.Entity("AccountManagement.Domain.CooperationRequestAgg.UserCooperationRequest", b =>
                {
                    b.HasOne("AccountManagement.Domain.PersonalityAgg.Personality", "Personality")
                        .WithMany("UserCooperationRequests")
                        .HasForeignKey("PersonalityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AccountManagement.Domain.UserAgg.User", "User")
                        .WithMany("UserCooperationRequests")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personality");

                    b.Navigation("User");
                });

            modelBuilder.Entity("AccountManagement.Domain.PersonalityAgg.Personality", b =>
                {
                    b.HasOne("AccountManagement.Domain.PersonalityTypeAgg.PersonalityType", "PersonalityType")
                        .WithMany("Personalities")
                        .HasForeignKey("PersonalityTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PersonalityType");
                });

            modelBuilder.Entity("AccountManagement.Domain.RoleAgg.Role", b =>
                {
                    b.HasOne("AccountManagement.Domain.RoleTypeAgg.RoleType", "RoleType")
                        .WithMany("Roles")
                        .HasForeignKey("RoleTypeId");

                    b.Navigation("RoleType");
                });

            modelBuilder.Entity("AccountManagement.Domain.UPAccountRequestsAgg.UpAccountRequest", b =>
                {
                    b.HasOne("AccountManagement.Domain.UserAgg.User", "User")
                        .WithOne("UpAccountRequest")
                        .HasForeignKey("AccountManagement.Domain.UPAccountRequestsAgg.UpAccountRequest", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("AccountManagement.Domain.UpAccountRequestRejectionReasonAgg.UpAccountRequestRejectionReason", b =>
                {
                    b.HasOne("AccountManagement.Domain.RejectionReasonAgg.RejectionReason", "RejectionReason")
                        .WithMany("UpAccountRequestRejectionReasons")
                        .HasForeignKey("RejectionReasonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AccountManagement.Domain.UPAccountRequestsAgg.UpAccountRequest", "UpAccountRequest")
                        .WithMany("UpAccountRequestRejectionReasons")
                        .HasForeignKey("UpAccountRequestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RejectionReason");

                    b.Navigation("UpAccountRequest");
                });

            modelBuilder.Entity("AccountManagement.Domain.UserPersonalityAgg.UserPersonality", b =>
                {
                    b.HasOne("AccountManagement.Domain.PersonalityAgg.Personality", "Personality")
                        .WithMany("UserPersonalities")
                        .HasForeignKey("PersonalityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AccountManagement.Domain.UserAgg.User", "User")
                        .WithMany("UserPersonalities")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personality");

                    b.Navigation("User");
                });

            modelBuilder.Entity("AccountManagement.Domain.UserRoleAgg.UserRole", b =>
                {
                    b.HasOne("AccountManagement.Domain.RoleAgg.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AccountManagement.Domain.UserAgg.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("AccountManagement.Domain.WalletAgg.BusinessWalletAgg.BusinessWallet", b =>
                {
                    b.HasOne("AccountManagement.Domain.UserAgg.User", "User")
                        .WithOne("BusinessWallet")
                        .HasForeignKey("AccountManagement.Domain.WalletAgg.BusinessWalletAgg.BusinessWallet", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("AccountManagement.Domain.WalletAgg.PersonalWalletChartAgg.PersonalWalletChart", b =>
                {
                    b.HasOne("AccountManagement.Domain.WalletAgg.PersonalwalletAgg.PersonalWallet", "PersonalWallet")
                        .WithMany("PersonalWalletCharts")
                        .HasForeignKey("PersonalwalletId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PersonalWallet");
                });

            modelBuilder.Entity("AccountManagement.Domain.WalletAgg.PersonalWalletOperationAgg.Personalwalletoperation", b =>
                {
                    b.HasOne("AccountManagement.Domain.WalletAgg.PersonalwalletAgg.PersonalWallet", "PersonalWallet")
                        .WithMany("PersonalWalletOperations")
                        .HasForeignKey("PersonalWalletId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AccountManagement.Domain.WalletAgg.OperationTypeAgg.WalletOperationType", "WalletOperationType")
                        .WithMany("PersonalWalletOperations")
                        .HasForeignKey("WalletOperationTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PersonalWallet");

                    b.Navigation("WalletOperationType");
                });

            modelBuilder.Entity("AccountManagement.Domain.WalletAgg.PersonalwalletAgg.PersonalWallet", b =>
                {
                    b.HasOne("AccountManagement.Domain.UserAgg.User", "User")
                        .WithOne("PersonalWallet")
                        .HasForeignKey("AccountManagement.Domain.WalletAgg.PersonalwalletAgg.PersonalWallet", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("AccountManagement.Domain.PersonalityAgg.Personality", b =>
                {
                    b.Navigation("UserCooperationRequests");

                    b.Navigation("UserPersonalities");
                });

            modelBuilder.Entity("AccountManagement.Domain.PersonalityTypeAgg.PersonalityType", b =>
                {
                    b.Navigation("Personalities");
                });

            modelBuilder.Entity("AccountManagement.Domain.RejectionReasonAgg.RejectionReason", b =>
                {
                    b.Navigation("UpAccountRequestRejectionReasons");
                });

            modelBuilder.Entity("AccountManagement.Domain.RoleAgg.Role", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("AccountManagement.Domain.RoleTypeAgg.RoleType", b =>
                {
                    b.Navigation("Roles");
                });

            modelBuilder.Entity("AccountManagement.Domain.UPAccountRequestsAgg.UpAccountRequest", b =>
                {
                    b.Navigation("UpAccountRequestRejectionReasons");
                });

            modelBuilder.Entity("AccountManagement.Domain.UserAgg.User", b =>
                {
                    b.Navigation("BusinessWallet");

                    b.Navigation("PersonalWallet");

                    b.Navigation("UpAccountRequest");

                    b.Navigation("UserCooperationRequests");

                    b.Navigation("UserPersonalities");

                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("AccountManagement.Domain.WalletAgg.OperationTypeAgg.WalletOperationType", b =>
                {
                    b.Navigation("PersonalWalletOperations");
                });

            modelBuilder.Entity("AccountManagement.Domain.WalletAgg.PersonalwalletAgg.PersonalWallet", b =>
                {
                    b.Navigation("PersonalWalletCharts");

                    b.Navigation("PersonalWalletOperations");
                });
#pragma warning restore 612, 618
        }
    }
}
