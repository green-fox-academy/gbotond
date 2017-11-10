using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using NBAapp.Entities;
using NBAapp.Models;

namespace NBAapp.Migrations
{
    [DbContext(typeof(NBAContext))]
    [Migration("20171109164705_Initialmigration")]
    partial class Initialmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NBAapp.Models.Player", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<double>("Height");

                    b.Property<bool>("IsHealthy");

                    b.Property<string>("Name");

                    b.Property<string>("Position");

                    b.Property<int>("Practice");

                    b.Property<int>("Weakness");

                    b.Property<double>("Weight");

                    b.HasKey("ID");

                    b.ToTable("Players");
                });
        }
    }
}
