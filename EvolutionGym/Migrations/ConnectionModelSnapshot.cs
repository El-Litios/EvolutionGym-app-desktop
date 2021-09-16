﻿// <auto-generated />
using System;
using EvolutionGym.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EvolutionGym.Migrations
{
    [DbContext(typeof(Connection))]
    partial class ConnectionModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EvolutionGym.Model.Client", b =>
                {
                    b.Property<int>("ClientID")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(4)
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClientEmail")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ClientFatherLastName")
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("ClientMotherLastName")
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("ClientName")
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("ClientPhone")
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("ClientRut")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("ClientID");

                    b.ToTable("tblClient");
                });

            modelBuilder.Entity("EvolutionGym.Model.Members", b =>
                {
                    b.Property<int>("MembershipID")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(4)
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientID")
                        .HasColumnType("int");

                    b.Property<int>("MembershipCost")
                        .HasColumnType("int");

                    b.Property<DateTime>("MembershipDateBegin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("MembershipDateEnd")
                        .HasColumnType("datetime2");

                    b.Property<int>("PaymentMethodID")
                        .HasColumnType("int");

                    b.Property<int>("TypeID")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("MembershipID");

                    b.HasIndex("ClientID");

                    b.HasIndex("PaymentMethodID");

                    b.HasIndex("TypeID");

                    b.HasIndex("UserID");

                    b.ToTable("tblMembership");
                });

            modelBuilder.Entity("EvolutionGym.Model.PaymentMethod", b =>
                {
                    b.Property<int>("PaymentMethodID")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(1)
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MethodDesc")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("PaymentMethodID");

                    b.ToTable("tblPaymentMethod");
                });

            modelBuilder.Entity("EvolutionGym.Model.Role", b =>
                {
                    b.Property<int>("RoleID")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(1)
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RoleDesc")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("RoleID");

                    b.ToTable("tblRole");
                });

            modelBuilder.Entity("EvolutionGym.Model.TypeMembership", b =>
                {
                    b.Property<int>("TypeID")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(1)
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TypeDesc")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("TypeID");

                    b.ToTable("tblTypeMembership");
                });

            modelBuilder.Entity("EvolutionGym.Model.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(2)
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RoleID")
                        .HasColumnType("int");

                    b.Property<string>("UserFatherLastName")
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("UserMotherLastName")
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("UserName")
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("UserPass")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("UserRut")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("UserUser")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("UserID");

                    b.HasIndex("RoleID");

                    b.ToTable("tblUser");
                });

            modelBuilder.Entity("EvolutionGym.Model.Members", b =>
                {
                    b.HasOne("EvolutionGym.Model.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EvolutionGym.Model.PaymentMethod", "Payment")
                        .WithMany()
                        .HasForeignKey("PaymentMethodID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EvolutionGym.Model.TypeMembership", "Type")
                        .WithMany()
                        .HasForeignKey("TypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EvolutionGym.Model.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Payment");

                    b.Navigation("Type");

                    b.Navigation("User");
                });

            modelBuilder.Entity("EvolutionGym.Model.User", b =>
                {
                    b.HasOne("EvolutionGym.Model.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });
#pragma warning restore 612, 618
        }
    }
}
