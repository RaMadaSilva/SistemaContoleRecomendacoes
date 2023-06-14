﻿// <auto-generated />
using System;
using ControleRecomands.Infra.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ControleRecomands.Infra.Migrations
{
    [DbContext(typeof(RecommendationDbContext))]
    partial class RecommendationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ControleRecommads.Domain.Entities.Recommendation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id");

                    b.Property<Guid>("ChurchId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ChurchId1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DevolutionDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("DevolutionDate");

                    b.Property<DateTime>("EntryDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("EntryDate");

                    b.Property<Guid>("MemberId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MemberId1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("RecommendationDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("RecommendationDate");

                    b.Property<int>("State")
                        .HasColumnType("int")
                        .HasColumnName("StateRecommendation");

                    b.Property<DateTime>("ValidateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("ValidateDate");

                    b.HasKey("Id");

                    b.HasIndex("ChurchId");

                    b.HasIndex("ChurchId1");

                    b.HasIndex("MemberId");

                    b.HasIndex("MemberId1");

                    b.ToTable("Recommendation");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("ControleRecommads.Domain.Entities.ValueObject.Church", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id");

                    b.HasKey("Id");

                    b.ToTable("Church", (string)null);
                });

            modelBuilder.Entity("ControleRecommads.Domain.Entities.ValueObject.Member", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id");

                    b.Property<int>("Phone")
                        .HasColumnType("INT")
                        .HasColumnName("PhoneNumber");

                    b.HasKey("Id");

                    b.ToTable("Member", (string)null);
                });

            modelBuilder.Entity("ControleRecommads.Domain.Entities.IssuedRecommendation", b =>
                {
                    b.HasBaseType("ControleRecommads.Domain.Entities.Recommendation");

                    b.Property<string>("RecommendationGeneratedUrl")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)")
                        .HasColumnName("RecommendationGenerateUrl");

                    b.ToTable("IssuedRecommendation", (string)null);
                });

            modelBuilder.Entity("ControleRecommads.Domain.Entities.ReceivedRecommendation", b =>
                {
                    b.HasBaseType("ControleRecommads.Domain.Entities.Recommendation");

                    b.Property<string>("AttachmentRecommendationUrl")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)")
                        .HasColumnName("AttachmentRecommendationUrl");

                    b.ToTable("ReceivedRecommendation", (string)null);
                });

            modelBuilder.Entity("ControleRecommads.Domain.Entities.Recommendation", b =>
                {
                    b.HasOne("ControleRecommads.Domain.Entities.ValueObject.Member", "Member")
                        .WithMany()
                        .HasForeignKey("ChurchId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ControleRecommads.Domain.Entities.ValueObject.Church", null)
                        .WithMany("Recommendations")
                        .HasForeignKey("ChurchId1");

                    b.HasOne("ControleRecommads.Domain.Entities.ValueObject.Church", "Church")
                        .WithMany()
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ControleRecommads.Domain.Entities.ValueObject.Member", null)
                        .WithMany("Recommendations")
                        .HasForeignKey("MemberId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Church");

                    b.Navigation("Member");
                });

            modelBuilder.Entity("ControleRecommads.Domain.Entities.ValueObject.Church", b =>
                {
                    b.OwnsOne("ControleRecommads.Domain.Entities.ValueObject.Adress", "Adress", b1 =>
                        {
                            b1.Property<Guid>("ChurchId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasMaxLength(200)
                                .HasColumnType("NVARCHAR")
                                .HasColumnName("City");

                            b1.Property<string>("Reference")
                                .IsRequired()
                                .HasMaxLength(200)
                                .HasColumnType("NVARCHAR")
                                .HasColumnName("Reference");

                            b1.HasKey("ChurchId");

                            b1.ToTable("Church");

                            b1.WithOwner()
                                .HasForeignKey("ChurchId");
                        });

                    b.OwnsOne("ControleRecommads.Domain.Entities.ValueObject.Name", "Name", b1 =>
                        {
                            b1.Property<Guid>("ChurchId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("NameComplete")
                                .IsRequired()
                                .HasMaxLength(80)
                                .HasColumnType("NVARCHAR")
                                .HasColumnName("Name");

                            b1.HasKey("ChurchId");

                            b1.ToTable("Church");

                            b1.WithOwner()
                                .HasForeignKey("ChurchId");
                        });

                    b.Navigation("Adress")
                        .IsRequired();

                    b.Navigation("Name")
                        .IsRequired();
                });

            modelBuilder.Entity("ControleRecommads.Domain.Entities.ValueObject.Member", b =>
                {
                    b.OwnsOne("ControleRecommads.Domain.Entities.ValueObject.Adress", "Adress", b1 =>
                        {
                            b1.Property<Guid>("MemberId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("NVARCHAR")
                                .HasColumnName("City");

                            b1.Property<string>("Reference")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("NVARCHAR")
                                .HasColumnName("Reference");

                            b1.HasKey("MemberId");

                            b1.ToTable("Member");

                            b1.WithOwner()
                                .HasForeignKey("MemberId");
                        });

                    b.OwnsOne("ControleRecommads.Domain.Entities.ValueObject.Name", "Name", b1 =>
                        {
                            b1.Property<Guid>("MemberId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("NameComplete")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("NVARCHAR")
                                .HasColumnName("NameComplete");

                            b1.HasKey("MemberId");

                            b1.ToTable("Member");

                            b1.WithOwner()
                                .HasForeignKey("MemberId");
                        });

                    b.Navigation("Adress")
                        .IsRequired();

                    b.Navigation("Name")
                        .IsRequired();
                });

            modelBuilder.Entity("ControleRecommads.Domain.Entities.IssuedRecommendation", b =>
                {
                    b.HasOne("ControleRecommads.Domain.Entities.Recommendation", null)
                        .WithOne()
                        .HasForeignKey("ControleRecommads.Domain.Entities.IssuedRecommendation", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ControleRecommads.Domain.Entities.ReceivedRecommendation", b =>
                {
                    b.HasOne("ControleRecommads.Domain.Entities.Recommendation", null)
                        .WithOne()
                        .HasForeignKey("ControleRecommads.Domain.Entities.ReceivedRecommendation", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ControleRecommads.Domain.Entities.ValueObject.Church", b =>
                {
                    b.Navigation("Recommendations");
                });

            modelBuilder.Entity("ControleRecommads.Domain.Entities.ValueObject.Member", b =>
                {
                    b.Navigation("Recommendations");
                });
#pragma warning restore 612, 618
        }
    }
}
