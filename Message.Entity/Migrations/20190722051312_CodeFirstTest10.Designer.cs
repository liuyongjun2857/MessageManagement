﻿// <auto-generated />
using System;
using Message.Entity.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Message.Entity.Migrations
{
    [DbContext(typeof(MessageManagementContext))]
    [Migration("20190722051312_CodeFirstTest10")]
    partial class CodeFirstTest10
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Message.Entity.Mapping.DataBase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Screater")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("SdataBaseName")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Smodifier")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Sremarks")
                        .HasMaxLength(200);

                    b.Property<DateTime?>("TcreateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<DateTime?>("TmodifyTime")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.ToTable("DataBase");
                });

            modelBuilder.Entity("Message.Entity.Mapping.DataTables", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdataBaseId");

                    b.Property<string>("Screater")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Smodifier")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Sremarks")
                        .HasMaxLength(200);

                    b.Property<string>("StableName")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<DateTime?>("TcreateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<DateTime?>("TmodifyTime")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.ToTable("DataTables");
                });

            modelBuilder.Entity("Message.Entity.Mapping.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("Bdelete");

                    b.Property<bool?>("Bdisplay");

                    b.Property<int>("IparentId");

                    b.Property<int>("Isort");

                    b.Property<string>("Screater")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("SiconUrl")
                        .HasMaxLength(128);

                    b.Property<string>("SlinkUrl")
                        .HasMaxLength(128);

                    b.Property<string>("Smodifier")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Sname")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("Sremarks")
                        .HasMaxLength(200);

                    b.Property<DateTime?>("TcreateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<DateTime?>("TmodifyTime")
                        .HasColumnType("datetime");

                    b.HasKey("Id")
                        .HasName("PK_MENU")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.ToTable("Menu");
                });

            modelBuilder.Entity("Message.Entity.Mapping.RoleMenu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ImenuId");

                    b.Property<int>("IroleId");

                    b.Property<string>("Screater")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Smodifier")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime?>("TcreateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<DateTime?>("TmodifyTime")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.ToTable("RoleMenu");
                });

            modelBuilder.Entity("Message.Entity.Mapping.Roles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Screater")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Smodifier")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Sremarks")
                        .HasMaxLength(200);

                    b.Property<string>("SroleName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime?>("TcreateTime");

                    b.Property<DateTime?>("TmodifyTime");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Message.Entity.Mapping.UserInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("BisLock");

                    b.Property<string>("Screater")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("SloginLastIp")
                        .HasMaxLength(64);

                    b.Property<string>("SloginName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("SloginPwd")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Smodifier")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Sremarks")
                        .HasMaxLength(200);

                    b.Property<string>("SuserEmail")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("SuserName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("SuserPhone")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime?>("TcreateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<DateTime?>("TloginLastTime");

                    b.Property<DateTime?>("TmodifyTime")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.ToTable("UserInfo");
                });

            modelBuilder.Entity("Message.Entity.Mapping.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IroleId");

                    b.Property<int>("IuserId");

                    b.Property<string>("Screater")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Smodifier")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Sremarks")
                        .HasMaxLength(200);

                    b.Property<DateTime?>("TcreateTime");

                    b.Property<DateTime?>("TmodifyTime");

                    b.HasKey("Id");

                    b.ToTable("UserRole");
                });
#pragma warning restore 612, 618
        }
    }
}
