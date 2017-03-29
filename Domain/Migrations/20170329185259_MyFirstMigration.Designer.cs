using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Domain.Models;

namespace Domain.Migrations
{
    [DbContext(typeof(TimeSheetContext))]
    [Migration("20170329185259_MyFirstMigration")]
    partial class MyFirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Models.TimeSheetEntry", b =>
                {
                    b.Property<int>("TimeSheetEntryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Company");

                    b.Property<string>("User");

                    b.Property<float>("WorkTime");

                    b.HasKey("TimeSheetEntryId");

                    b.ToTable("Entries");
                });
        }
    }
}
