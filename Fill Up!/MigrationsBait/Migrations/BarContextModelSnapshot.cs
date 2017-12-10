using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using FillUpApp.Standart;

namespace MigrationsBait.Migrations
{
    [DbContext(typeof(BarContext))]
    partial class BarContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2");

            modelBuilder.Entity("FillUpApp.Standart.Bar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BarName");

                    b.Property<int>("RatingOfBar");

                    b.HasKey("Id");

                    b.ToTable("Bars");
                });
        }
    }
}
