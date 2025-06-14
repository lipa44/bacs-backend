﻿// <auto-generated />
using System;
using BaCS.Persistence.PostgreSQL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BaCS.Persistence.PostgreSQL.Migrations
{
    [DbContext(typeof(BaCSDbContext))]
    [Migration("20250402203718_User__EnableEmailNotifications_Added")]
    partial class User__EnableEmailNotifications_Added
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BaCS.Domain.Core.Entities.Location", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("Address")
                        .HasColumnType("text")
                        .HasColumnName("address");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("deleted_at");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text")
                        .HasColumnName("image_url");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Id")
                        .HasName("pk_locations");

                    b.ToTable("locations", (string)null);
                });

            modelBuilder.Entity("BaCS.Domain.Core.Entities.LocationAdmin", b =>
                {
                    b.Property<Guid>("LocationId")
                        .HasColumnType("uuid")
                        .HasColumnName("location_id");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid")
                        .HasColumnName("user_id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("deleted_at");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("LocationId", "UserId")
                        .HasName("pk_location_admins");

                    b.HasIndex("UserId")
                        .HasDatabaseName("ix_location_admins_user_id");

                    b.ToTable("location_admins", (string)null);
                });

            modelBuilder.Entity("BaCS.Domain.Core.Entities.Reservation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("deleted_at");

                    b.Property<DateTime>("From")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("from");

                    b.Property<Guid>("LocationId")
                        .HasColumnType("uuid")
                        .HasColumnName("location_id");

                    b.Property<Guid>("ResourceId")
                        .HasColumnType("uuid")
                        .HasColumnName("resource_id");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("status");

                    b.Property<DateTime>("To")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("to");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid")
                        .HasColumnName("user_id");

                    b.HasKey("Id")
                        .HasName("pk_reservations");

                    b.HasIndex("From")
                        .HasDatabaseName("ix_reservations_from");

                    b.HasIndex("LocationId")
                        .HasDatabaseName("ix_reservations_location_id");

                    b.HasIndex("ResourceId")
                        .HasDatabaseName("ix_reservations_resource_id");

                    b.HasIndex("To")
                        .HasDatabaseName("ix_reservations_to");

                    b.HasIndex("UserId")
                        .HasDatabaseName("ix_reservations_user_id");

                    b.HasIndex("From", "To")
                        .HasDatabaseName("ix_reservations_from_to");

                    b.ToTable("reservations", (string)null);
                });

            modelBuilder.Entity("BaCS.Domain.Core.Entities.Resource", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("deleted_at");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.PrimitiveCollection<string[]>("Equipment")
                        .HasColumnType("text[]")
                        .HasColumnName("equipment");

                    b.Property<int>("Floor")
                        .HasColumnType("integer")
                        .HasColumnName("floor");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text")
                        .HasColumnName("image_url");

                    b.Property<Guid>("LocationId")
                        .HasColumnType("uuid")
                        .HasColumnName("location_id");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<int>("Type")
                        .HasColumnType("integer")
                        .HasColumnName("type");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Id")
                        .HasName("pk_resources");

                    b.HasIndex("LocationId")
                        .HasDatabaseName("ix_resources_location_id");

                    b.ToTable("resources", (string)null);
                });

            modelBuilder.Entity("BaCS.Domain.Core.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("deleted_at");

                    b.Property<string>("Email")
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<bool>("EnableEmailNotifications")
                        .HasColumnType("boolean")
                        .HasColumnName("enable_email_notifications");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.Property<string>("Username")
                        .HasColumnType("text")
                        .HasColumnName("username");

                    b.HasKey("Id")
                        .HasName("pk_users");

                    b.HasIndex("Username")
                        .IsUnique()
                        .HasDatabaseName("ix_users_username");

                    b.ToTable("users", (string)null);
                });

            modelBuilder.Entity("BaCS.Domain.Core.Entities.Location", b =>
                {
                    b.OwnsOne("BaCS.Domain.Core.Entities.CalendarSettings", "CalendarSettings", b1 =>
                        {
                            b1.Property<Guid>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("uuid")
                                .HasColumnName("calendar_settings_id");

                            b1.PrimitiveCollection<int[]>("AvailableDaysOfWeek")
                                .HasColumnType("integer[]")
                                .HasColumnName("available_days_of_week");

                            b1.Property<TimeOnly>("AvailableFrom")
                                .HasColumnType("time without time zone")
                                .HasColumnName("available_from");

                            b1.Property<TimeOnly>("AvailableTo")
                                .HasColumnType("time without time zone")
                                .HasColumnName("available_to");

                            b1.Property<DateTime>("CreatedAt")
                                .HasColumnType("timestamp with time zone")
                                .HasColumnName("created_at");

                            b1.Property<DateTime?>("DeletedAt")
                                .HasColumnType("timestamp with time zone")
                                .HasColumnName("deleted_at");

                            b1.Property<Guid>("LocationId")
                                .HasColumnType("uuid")
                                .HasColumnName("location_id");

                            b1.Property<DateTime>("UpdatedAt")
                                .HasColumnType("timestamp with time zone")
                                .HasColumnName("updated_at");

                            b1.HasKey("Id")
                                .HasName("pk_location_calendar_settings");

                            b1.HasIndex("LocationId")
                                .IsUnique()
                                .HasDatabaseName("ix_location_calendar_settings_id");

                            b1.ToTable("location_calendar_settings", (string)null);

                            b1.WithOwner("Location")
                                .HasForeignKey("LocationId")
                                .HasConstraintName("fk_location_calendar_settings_locations_id");

                            b1.Navigation("Location");
                        });

                    b.Navigation("CalendarSettings");
                });

            modelBuilder.Entity("BaCS.Domain.Core.Entities.LocationAdmin", b =>
                {
                    b.HasOne("BaCS.Domain.Core.Entities.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_location_admins_locations_location_id");

                    b.HasOne("BaCS.Domain.Core.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_location_admins_users_user_id");

                    b.Navigation("Location");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BaCS.Domain.Core.Entities.Reservation", b =>
                {
                    b.HasOne("BaCS.Domain.Core.Entities.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_reservations_locations_location_id");

                    b.HasOne("BaCS.Domain.Core.Entities.Resource", "Resource")
                        .WithMany()
                        .HasForeignKey("ResourceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_reservations_resources_resource_id");

                    b.HasOne("BaCS.Domain.Core.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_reservations_users_user_id");

                    b.Navigation("Location");

                    b.Navigation("Resource");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BaCS.Domain.Core.Entities.Resource", b =>
                {
                    b.HasOne("BaCS.Domain.Core.Entities.Location", "Location")
                        .WithMany("Resources")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_resources_locations_location_id");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("BaCS.Domain.Core.Entities.Location", b =>
                {
                    b.Navigation("Resources");
                });
#pragma warning restore 612, 618
        }
    }
}
