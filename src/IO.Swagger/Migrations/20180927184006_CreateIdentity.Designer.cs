﻿// <auto-generated />
using IO.Swagger.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace IO.Swagger.Migrations
{
    [DbContext(typeof(PrevalenceContext))]
    [Migration("20180927184006_CreateIdentity")]
    partial class CreateIdentity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IO.Swagger.Models.Prevalence", b =>
                {
                    b.Property<Guid>("prevalanceId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CountryName");

                    b.Property<string>("DiseaseName")
                        .IsRequired();

                    b.Property<int?>("Population");

                    b.Property<int?>("PrevalanceFactor");

                    b.HasKey("prevalanceId");

                    b.ToTable("Prevalence");
                });
#pragma warning restore 612, 618
        }
    }
}
