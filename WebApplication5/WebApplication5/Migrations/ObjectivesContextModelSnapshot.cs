﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication5;

namespace WebApplication5.Migrations
{
    [DbContext(typeof(ObjectivesContext))]
    partial class ObjectivesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication5.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("WebApplication5.Entities.Objective", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryID");

                    b.Property<string>("Description");

                    b.Property<bool>("IsCompleted");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<DateTime>("timeOfRealizing");

                    b.HasKey("Id");

                    b.HasIndex("CategoryID");

                    b.ToTable("Objectives");
                });

            modelBuilder.Entity("WebApplication5.Entities.ObjectiveTag", b =>
                {
                    b.Property<int>("ObjectiveId");

                    b.Property<int>("TagID");

                    b.HasKey("ObjectiveId", "TagID");

                    b.HasIndex("TagID");

                    b.ToTable("ObjectiveTags");
                });

            modelBuilder.Entity("WebApplication5.Entities.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("WebApplication5.Entities.Objective", b =>
                {
                    b.HasOne("WebApplication5.Entities.Category", "Category")
                        .WithMany("Objectives")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplication5.Entities.ObjectiveTag", b =>
                {
                    b.HasOne("WebApplication5.Entities.Objective", "Objective")
                        .WithMany("ObjectiveTags")
                        .HasForeignKey("ObjectiveId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebApplication5.Entities.Tag", "Tag")
                        .WithMany("ObjectiveTags")
                        .HasForeignKey("TagID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
