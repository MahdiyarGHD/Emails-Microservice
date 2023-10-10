﻿// <auto-generated />
using System;
using EasyMicroservices.EmailsMicroservice.Database.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EasyMicroservices.EmailsMicroservice.Migrations
{
    [DbContext(typeof(EmailContext))]
    [Migration("20230904143049_test")]
    partial class test
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EasyMicroservices.EmailsMicroservice.Database.Entities.EmailEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModificationDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("UniqueIdentity")
                        .HasColumnType("nvarchar(450)")
                        .UseCollation("SQL_Latin1_General_CP1_CS_AS");

                    b.HasKey("Id");

                    b.HasIndex("CreationDateTime");

                    b.HasIndex("DeletedDateTime");

                    b.HasIndex("IsDeleted");

                    b.HasIndex("ModificationDateTime");

                    b.HasIndex("UniqueIdentity");

                    b.ToTable("Emails");
                });

            modelBuilder.Entity("EasyMicroservices.EmailsMicroservice.Database.Entities.EmailServerEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSSL")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModificationDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Port")
                        .HasColumnType("int");

                    b.Property<string>("UniqueIdentity")
                        .HasColumnType("nvarchar(450)")
                        .UseCollation("SQL_Latin1_General_CP1_CS_AS");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CreationDateTime");

                    b.HasIndex("DeletedDateTime");

                    b.HasIndex("IsDeleted");

                    b.HasIndex("ModificationDateTime");

                    b.HasIndex("UniqueIdentity");

                    b.ToTable("EmailServers");
                });

            modelBuilder.Entity("EasyMicroservices.EmailsMicroservice.Database.Entities.QueueEmailEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreationDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<long>("EmailServerId")
                        .HasColumnType("bigint");

                    b.Property<long>("FromEmailId")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModificationDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("UniqueIdentity")
                        .HasColumnType("nvarchar(450)")
                        .UseCollation("SQL_Latin1_General_CP1_CS_AS");

                    b.HasKey("Id");

                    b.HasIndex("CreationDateTime");

                    b.HasIndex("DeletedDateTime");

                    b.HasIndex("EmailServerId");

                    b.HasIndex("FromEmailId");

                    b.HasIndex("IsDeleted");

                    b.HasIndex("ModificationDateTime");

                    b.HasIndex("UniqueIdentity");

                    b.ToTable("QueueEmails");
                });

            modelBuilder.Entity("EasyMicroservices.EmailsMicroservice.Database.Entities.SendEmailEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreationDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("EmailEntityId")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModificationDateTime")
                        .HasColumnType("datetime2");

                    b.Property<long>("QueueEmailId")
                        .HasColumnType("bigint");

                    b.Property<string>("UniqueIdentity")
                        .HasColumnType("nvarchar(450)")
                        .UseCollation("SQL_Latin1_General_CP1_CS_AS");

                    b.HasKey("Id");

                    b.HasIndex("CreationDateTime");

                    b.HasIndex("DeletedDateTime");

                    b.HasIndex("EmailEntityId");

                    b.HasIndex("IsDeleted");

                    b.HasIndex("ModificationDateTime");

                    b.HasIndex("QueueEmailId");

                    b.HasIndex("UniqueIdentity");

                    b.ToTable("SendEmails");
                });

            modelBuilder.Entity("EasyMicroservices.EmailsMicroservice.Database.Entities.QueueEmailEntity", b =>
                {
                    b.HasOne("EasyMicroservices.EmailsMicroservice.Database.Entities.EmailServerEntity", "EmailServers")
                        .WithMany("QueueEmails")
                        .HasForeignKey("EmailServerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EasyMicroservices.EmailsMicroservice.Database.Entities.EmailEntity", "Emails")
                        .WithMany("QueueEmails")
                        .HasForeignKey("FromEmailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EmailServers");

                    b.Navigation("Emails");
                });

            modelBuilder.Entity("EasyMicroservices.EmailsMicroservice.Database.Entities.SendEmailEntity", b =>
                {
                    b.HasOne("EasyMicroservices.EmailsMicroservice.Database.Entities.EmailEntity", null)
                        .WithMany("SendEmails")
                        .HasForeignKey("EmailEntityId");

                    b.HasOne("EasyMicroservices.EmailsMicroservice.Database.Entities.QueueEmailEntity", "QueueEmails")
                        .WithMany("SendEmails")
                        .HasForeignKey("QueueEmailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("QueueEmails");
                });

            modelBuilder.Entity("EasyMicroservices.EmailsMicroservice.Database.Entities.EmailEntity", b =>
                {
                    b.Navigation("QueueEmails");

                    b.Navigation("SendEmails");
                });

            modelBuilder.Entity("EasyMicroservices.EmailsMicroservice.Database.Entities.EmailServerEntity", b =>
                {
                    b.Navigation("QueueEmails");
                });

            modelBuilder.Entity("EasyMicroservices.EmailsMicroservice.Database.Entities.QueueEmailEntity", b =>
                {
                    b.Navigation("SendEmails");
                });
#pragma warning restore 612, 618
        }
    }
}
