﻿// <auto-generated />
using System;
using ATM;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Atm.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ATM.Cdl_Movement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Typ")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cdl_Movements");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Typ = "Vklad"
                        },
                        new
                        {
                            Id = 2,
                            Typ = "Výběr"
                        },
                        new
                        {
                            Id = 3,
                            Typ = "Odchozí platba"
                        },
                        new
                        {
                            Id = 4,
                            Typ = "Příchozí platba"
                        });
                });

            modelBuilder.Entity("ATM.Client", b =>
                {
                    b.Property<int>("IdClient")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CurrentAccountIdAccount")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PinCodeHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SavingsAccountIdAccount")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdClient");

                    b.HasIndex("CurrentAccountIdAccount");

                    b.HasIndex("SavingsAccountIdAccount");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("ATM.CurrentAccount", b =>
                {
                    b.Property<int>("IdAccount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Balance")
                        .HasColumnType("decimal(18,4)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdAccount");

                    b.ToTable("Accounts");

                    b.HasDiscriminator<string>("Discriminator").HasValue("CurrentAccount");
                });

            modelBuilder.Entity("ATM.Transaction", b =>
                {
                    b.Property<int>("IdTranHis")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,4)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("FromAccId")
                        .HasColumnType("int");

                    b.Property<int>("IdAccount")
                        .HasColumnType("int");

                    b.Property<int>("Movement")
                        .HasColumnType("int");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NoteForRecipient")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ToAccId")
                        .HasColumnType("int");

                    b.Property<int?>("VariableNumber")
                        .HasColumnType("int");

                    b.HasKey("IdTranHis");

                    b.ToTable("TransactionHistory");
                });

            modelBuilder.Entity("ATM.SavingsAccount", b =>
                {
                    b.HasBaseType("ATM.CurrentAccount");

                    b.Property<float>("InterestPerMensem")
                        .HasColumnType("real");

                    b.HasDiscriminator().HasValue("SavingsAccount");
                });

            modelBuilder.Entity("ATM.Client", b =>
                {
                    b.HasOne("ATM.CurrentAccount", "CurrentAccount")
                        .WithMany()
                        .HasForeignKey("CurrentAccountIdAccount");

                    b.HasOne("ATM.SavingsAccount", "SavingsAccount")
                        .WithMany()
                        .HasForeignKey("SavingsAccountIdAccount");

                    b.Navigation("CurrentAccount");

                    b.Navigation("SavingsAccount");
                });
#pragma warning restore 612, 618
        }
    }
}
