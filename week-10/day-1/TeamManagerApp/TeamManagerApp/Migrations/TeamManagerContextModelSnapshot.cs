using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using TeamManagerApp.Entities;
using TeamManagerApp.Models;

namespace TeamManagerApp.Migrations
{
    [DbContext(typeof(TeamManagerContext))]
    partial class TeamManagerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TeamManagerApp.Models.Player", b =>
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
