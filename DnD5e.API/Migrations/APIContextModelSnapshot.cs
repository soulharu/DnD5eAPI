﻿// <auto-generated />
using DnD5e.API.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DnD5e.API.Migrations
{
    [DbContext(typeof(APIContext))]
    partial class APIContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DnD5e.API.Domain.Models.Spell", b =>
                {
                    b.Property<int>("spellId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("book");

                    b.Property<string>("castingTime");

                    b.Property<string>("components");

                    b.Property<string>("damage");

                    b.Property<string>("damageType");

                    b.Property<string>("description");

                    b.Property<string>("duration");

                    b.Property<bool>("hasHigherLevels");

                    b.Property<string>("higherLevelDescription");

                    b.Property<bool>("isConcentration");

                    b.Property<bool>("isRitual");

                    b.Property<int>("level");

                    b.Property<string>("materialComponentDescription");

                    b.Property<string>("name");

                    b.Property<int>("page");

                    b.Property<string>("range");

                    b.Property<string>("school");

                    b.HasKey("spellId");

                    b.ToTable("Spells");
                });
#pragma warning restore 612, 618
        }
    }
}