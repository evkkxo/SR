﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SR.Data;

namespace SR.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("SR.Data.Entities.DiscordGuild", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<string>("EmbedColor")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("embed_color");

                    b.Property<byte>("LanguageType")
                        .HasColumnType("smallint")
                        .HasColumnName("language_type");

                    b.HasKey("Id")
                        .HasName("pk_discord_guilds");

                    b.HasIndex("Id")
                        .IsUnique()
                        .HasDatabaseName("ix_discord_guilds_id");

                    b.ToTable("discord_guilds");
                });

            modelBuilder.Entity("SR.Data.Entities.Reaction", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<byte>("Type")
                        .HasColumnType("smallint")
                        .HasColumnName("type");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("url");

                    b.HasKey("Id")
                        .HasName("pk_reactions");

                    b.HasIndex("Type", "Url")
                        .IsUnique()
                        .HasDatabaseName("ix_reactions_type_url");

                    b.ToTable("reactions");
                });
#pragma warning restore 612, 618
        }
    }
}
