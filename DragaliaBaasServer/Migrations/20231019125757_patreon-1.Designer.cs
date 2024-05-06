﻿// <auto-generated />
using System;
using DragaliaBaasServer.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DragaliaBaasServer.Migrations
{
    [DbContext(typeof(BaasDbContext))]
    [Migration("20231019125757_patreon-1")]
    partial class patreon1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DragaliaBaasServer.Models.Backend.DeviceAccount", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserAccountId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserAccountId");

                    b.ToTable("Devices");
                });

            modelBuilder.Entity("DragaliaBaasServer.Models.Backend.UserAccount", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("Birthday")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("CreatedAt")
                        .HasColumnType("numeric(20,0)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("HasUnreadCsComment")
                        .HasColumnType("boolean");

                    b.Property<string>("Nickname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("UpdatedAt")
                        .HasColumnType("numeric(20,0)");

                    b.Property<string>("WebUserAccountId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("WebUserAccountId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DragaliaBaasServer.Models.Backend.UserVcmBalance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Free")
                        .HasColumnType("numeric(20,0)");

                    b.Property<bool>("Remitted")
                        .HasColumnType("boolean");

                    b.Property<decimal>("Total")
                        .HasColumnType("numeric(20,0)");

                    b.Property<int?>("UserVcmInfoId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserVcmInfoId");

                    b.ToTable("UserVcmBalance");
                });

            modelBuilder.Entity("DragaliaBaasServer.Models.Backend.UserVcmInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Market")
                        .HasColumnType("integer");

                    b.Property<string>("UserAccountId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("VirtualCurrencyName")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserAccountId");

                    b.ToTable("UserVcmInfo");
                });

            modelBuilder.Entity("DragaliaBaasServer.Models.Web.WebUserAccount", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("LinkedPatreonUserId")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("character varying(32)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<long>("SavefileUploadedAt")
                        .HasColumnType("bigint");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.HasKey("Id");

                    b.ToTable("WebUsers");
                });

            modelBuilder.Entity("DragaliaBaasServer.Models.Backend.DeviceAccount", b =>
                {
                    b.HasOne("DragaliaBaasServer.Models.Backend.UserAccount", null)
                        .WithMany("AssociatedDeviceAccounts")
                        .HasForeignKey("UserAccountId");
                });

            modelBuilder.Entity("DragaliaBaasServer.Models.Backend.UserAccount", b =>
                {
                    b.HasOne("DragaliaBaasServer.Models.Web.WebUserAccount", "WebUserAccount")
                        .WithMany()
                        .HasForeignKey("WebUserAccountId");

                    b.OwnsOne("DragaliaBaasServer.Models.Backend.ExtendedUserInfo", "ExtendedUserInfo", b1 =>
                        {
                            b1.Property<string>("UserAccountId")
                                .HasColumnType("text");

                            b1.Property<DateTimeOffset?>("BanExpiration")
                                .HasColumnType("timestamp with time zone");

                            b1.Property<string>("BanReason")
                                .HasColumnType("text");

                            b1.Property<bool>("HasUploadedSaveData")
                                .HasColumnType("boolean");

                            b1.Property<string>("SaveDataDownloadUrl")
                                .HasColumnType("text");

                            b1.Property<int>("Status")
                                .HasColumnType("integer");

                            b1.HasKey("UserAccountId");

                            b1.ToTable("Users");

                            b1.WithOwner()
                                .HasForeignKey("UserAccountId");
                        });

                    b.OwnsOne("DragaliaBaasServer.Models.Backend.UserPermissions", "Permissions", b1 =>
                        {
                            b1.Property<string>("UserAccountId")
                                .HasColumnType("text");

                            b1.Property<bool>("PersonalAnalytics")
                                .HasColumnType("boolean");

                            b1.Property<decimal>("PersonalAnalyticsUpdatedAt")
                                .HasColumnType("numeric(20,0)");

                            b1.Property<bool>("PersonalNotification")
                                .HasColumnType("boolean");

                            b1.Property<decimal>("PersonalNotificationUpdatedAt")
                                .HasColumnType("numeric(20,0)");

                            b1.HasKey("UserAccountId");

                            b1.ToTable("Users");

                            b1.WithOwner()
                                .HasForeignKey("UserAccountId");
                        });

                    b.Navigation("ExtendedUserInfo")
                        .IsRequired();

                    b.Navigation("Permissions")
                        .IsRequired();

                    b.Navigation("WebUserAccount");
                });

            modelBuilder.Entity("DragaliaBaasServer.Models.Backend.UserVcmBalance", b =>
                {
                    b.HasOne("DragaliaBaasServer.Models.Backend.UserVcmInfo", null)
                        .WithMany("Balances")
                        .HasForeignKey("UserVcmInfoId");

                    b.OwnsMany("DragaliaBaasServer.Models.Vcm.VcmBalancePaidEntry", "Paid", b1 =>
                        {
                            b1.Property<int>("UserVcmBalanceId")
                                .HasColumnType("integer");

                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("integer");

                            NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b1.Property<int>("Id"));

                            b1.Property<string>("Code")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.Property<int>("Total")
                                .HasColumnType("integer");

                            b1.HasKey("UserVcmBalanceId", "Id");

                            b1.ToTable("VcmBalancePaidEntry");

                            b1.WithOwner()
                                .HasForeignKey("UserVcmBalanceId");
                        });

                    b.Navigation("Paid");
                });

            modelBuilder.Entity("DragaliaBaasServer.Models.Backend.UserVcmInfo", b =>
                {
                    b.HasOne("DragaliaBaasServer.Models.Backend.UserAccount", null)
                        .WithMany("VcmInfo")
                        .HasForeignKey("UserAccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DragaliaBaasServer.Models.Backend.UserAccount", b =>
                {
                    b.Navigation("AssociatedDeviceAccounts");

                    b.Navigation("VcmInfo");
                });

            modelBuilder.Entity("DragaliaBaasServer.Models.Backend.UserVcmInfo", b =>
                {
                    b.Navigation("Balances");
                });
#pragma warning restore 612, 618
        }
    }
}