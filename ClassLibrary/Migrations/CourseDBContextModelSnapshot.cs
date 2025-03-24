﻿// <auto-generated />
using System;
using ClassLibrary.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ClassLibrary.Migrations
{
    [DbContext(typeof(CourseDBContext))]
    partial class CourseDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.36")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ClassLibrary.Model.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Category_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("ClassLibrary.Model.Document", b =>
                {
                    b.Property<int>("DocumentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Document_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DocumentId"), 1L, 1);

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("FileType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FileUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("FileURL");

                    b.Property<int>("RentalTransactionId")
                        .HasColumnType("int")
                        .HasColumnName("Rental_transaction_ID");

                    b.HasKey("DocumentId");

                    b.HasIndex("RentalTransactionId");

                    b.ToTable("Document");
                });

            modelBuilder.Entity("ClassLibrary.Model.Equipment", b =>
                {
                    b.Property<int>("EquipmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Equipment_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EquipmentId"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("Category_ID");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("EquipmentConditionId")
                        .HasColumnType("int")
                        .HasColumnName("Equipment_Condition_ID");

                    b.Property<int>("EquipmentStatusId")
                        .HasColumnType("int")
                        .HasColumnName("Equipment_Status_ID");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<decimal>("RentalRate")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("EquipmentId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("EquipmentConditionId");

                    b.HasIndex("EquipmentStatusId");

                    b.ToTable("Equipment");
                });

            modelBuilder.Entity("ClassLibrary.Model.EquipmentCondition", b =>
                {
                    b.Property<int>("EquipmentConditionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Equipment_Condition_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EquipmentConditionId"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("EquipmentConditionId");

                    b.ToTable("Equipment_Condition");
                });

            modelBuilder.Entity("ClassLibrary.Model.EquipmentStatus", b =>
                {
                    b.Property<int>("EquipmentStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Equipment_Status_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EquipmentStatusId"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("EquipmentStatusId");

                    b.ToTable("Equipment_Status");
                });

            modelBuilder.Entity("ClassLibrary.Model.Feedback", b =>
                {
                    b.Property<int>("FeedbackId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Feedback_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FeedbackId"), 1L, 1);

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("comment");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<int>("RentalTransactionId")
                        .HasColumnType("int")
                        .HasColumnName("Rental_Transaction_ID");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("User_ID");

                    b.HasKey("FeedbackId");

                    b.HasIndex("RentalTransactionId");

                    b.HasIndex("UserId");

                    b.ToTable("Feedback");
                });

            modelBuilder.Entity("ClassLibrary.Model.Log", b =>
                {
                    b.Property<int>("LogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Log_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LogId"), 1L, 1);

                    b.Property<string>("Action")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("CurrentValue")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("EntityChanged")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("OriginalValue")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<byte[]>("TimeStamp")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("User_ID");

                    b.HasKey("LogId");

                    b.HasIndex("UserId");

                    b.ToTable("Log");
                });

            modelBuilder.Entity("ClassLibrary.Model.Notification", b =>
                {
                    b.Property<int>("NotificationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Notification_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NotificationId"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("date");

                    b.Property<string>("Massege")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("User_ID");

                    b.HasKey("NotificationId");

                    b.HasIndex("UserId");

                    b.ToTable("Notification");
                });

            modelBuilder.Entity("ClassLibrary.Model.RentalRequest", b =>
                {
                    b.Property<int>("RentalRequestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Rental_Request_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RentalRequestId"), 1L, 1);

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("date");

                    b.Property<int>("EquipmentId")
                        .HasColumnType("int")
                        .HasColumnName("Equipment_ID");

                    b.Property<DateTime>("RequestDate")
                        .HasColumnType("date");

                    b.Property<int>("RequestStatusId")
                        .HasColumnType("int")
                        .HasColumnName("Request_Status_ID");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("date");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("User_ID");

                    b.HasKey("RentalRequestId");

                    b.HasIndex("EquipmentId");

                    b.HasIndex("RequestStatusId");

                    b.HasIndex("UserId");

                    b.ToTable("Rental_Request");
                });

            modelBuilder.Entity("ClassLibrary.Model.RentalTransaction", b =>
                {
                    b.Property<int>("RentalTransactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Rental_transaction_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RentalTransactionId"), 1L, 1);

                    b.Property<int>("EquipmentId")
                        .HasColumnType("int")
                        .HasColumnName("Equipment_ID");

                    b.Property<string>("PaymentStatus")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("RentalEndDate")
                        .HasColumnType("date");

                    b.Property<int>("RentalRequestId")
                        .HasColumnType("int")
                        .HasColumnName("Rental_Request_ID");

                    b.Property<DateTime>("RentalStartDate")
                        .HasColumnType("date");

                    b.Property<decimal>("TotalCost")
                        .HasColumnType("money");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("User_ID");

                    b.HasKey("RentalTransactionId");

                    b.HasIndex("EquipmentId");

                    b.HasIndex("RentalRequestId");

                    b.HasIndex("UserId");

                    b.ToTable("Rental_Transaction");
                });

            modelBuilder.Entity("ClassLibrary.Model.RequestStatus", b =>
                {
                    b.Property<int>("RequestStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Request_Status_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RequestStatusId"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("RequestStatusId");

                    b.ToTable("Request_Status");
                });

            modelBuilder.Entity("ClassLibrary.Model.ReturnRecord", b =>
                {
                    b.Property<int>("ReturnRecordId")
                        .HasColumnType("int")
                        .HasColumnName("Return_Record_ID");

                    b.Property<int>("EquipmentConditionId")
                        .HasColumnType("int")
                        .HasColumnName("Equipment_Condition_ID");

                    b.Property<int>("EquipmentId")
                        .HasColumnType("int")
                        .HasColumnName("Equipment_ID");

                    b.Property<int>("RentalTransactionId")
                        .HasColumnType("int")
                        .HasColumnName("Rental_transaction_ID");

                    b.Property<DateTime>("ReturnDate")
                        .HasColumnType("date");

                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("User_ID");

                    b.HasKey("ReturnRecordId");

                    b.HasIndex("EquipmentConditionId");

                    b.HasIndex("EquipmentId");

                    b.HasIndex("RentalTransactionId");

                    b.HasIndex("UserId");

                    b.ToTable("Return_Record");
                });

            modelBuilder.Entity("ClassLibrary.Model.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("User_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("UserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("ClassLibrary.Model.Document", b =>
                {
                    b.HasOne("ClassLibrary.Model.RentalTransaction", "RentalTransaction")
                        .WithMany("Documents")
                        .HasForeignKey("RentalTransactionId")
                        .IsRequired()
                        .HasConstraintName("FK_Document_Rental_Transaction");

                    b.Navigation("RentalTransaction");
                });

            modelBuilder.Entity("ClassLibrary.Model.Equipment", b =>
                {
                    b.HasOne("ClassLibrary.Model.Category", "Category")
                        .WithMany("Equipment")
                        .HasForeignKey("CategoryId")
                        .IsRequired()
                        .HasConstraintName("FK_Equipment_Category");

                    b.HasOne("ClassLibrary.Model.EquipmentCondition", "EquipmentCondition")
                        .WithMany("Equipment")
                        .HasForeignKey("EquipmentConditionId")
                        .IsRequired()
                        .HasConstraintName("FK_Equipment_Equipment_Condition");

                    b.HasOne("ClassLibrary.Model.EquipmentStatus", "EquipmentStatus")
                        .WithMany("Equipment")
                        .HasForeignKey("EquipmentStatusId")
                        .IsRequired()
                        .HasConstraintName("FK_Equipment_Equipment_Status");

                    b.Navigation("Category");

                    b.Navigation("EquipmentCondition");

                    b.Navigation("EquipmentStatus");
                });

            modelBuilder.Entity("ClassLibrary.Model.Feedback", b =>
                {
                    b.HasOne("ClassLibrary.Model.RentalTransaction", "RentalTransaction")
                        .WithMany("Feedbacks")
                        .HasForeignKey("RentalTransactionId")
                        .IsRequired()
                        .HasConstraintName("FK_Feedback_Rental_Transaction");

                    b.HasOne("ClassLibrary.Model.User", "User")
                        .WithMany("Feedbacks")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK_Feedback_User");

                    b.Navigation("RentalTransaction");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ClassLibrary.Model.Log", b =>
                {
                    b.HasOne("ClassLibrary.Model.User", "User")
                        .WithMany("Logs")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK_Log_User");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ClassLibrary.Model.Notification", b =>
                {
                    b.HasOne("ClassLibrary.Model.User", "User")
                        .WithMany("Notifications")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK_Notification_User");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ClassLibrary.Model.RentalRequest", b =>
                {
                    b.HasOne("ClassLibrary.Model.Equipment", "Equipment")
                        .WithMany("RentalRequests")
                        .HasForeignKey("EquipmentId")
                        .IsRequired()
                        .HasConstraintName("FK_Rental_Request_Equipment");

                    b.HasOne("ClassLibrary.Model.RequestStatus", "RequestStatus")
                        .WithMany("RentalRequests")
                        .HasForeignKey("RequestStatusId")
                        .IsRequired()
                        .HasConstraintName("FK_Rental_Request_Request_Status");

                    b.HasOne("ClassLibrary.Model.User", "User")
                        .WithMany("RentalRequests")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK_Rental_Request_User");

                    b.Navigation("Equipment");

                    b.Navigation("RequestStatus");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ClassLibrary.Model.RentalTransaction", b =>
                {
                    b.HasOne("ClassLibrary.Model.Equipment", "Equipment")
                        .WithMany("RentalTransactions")
                        .HasForeignKey("EquipmentId")
                        .IsRequired()
                        .HasConstraintName("FK_Rental_Transaction_Equipment");

                    b.HasOne("ClassLibrary.Model.RentalRequest", "RentalRequest")
                        .WithMany("RentalTransactions")
                        .HasForeignKey("RentalRequestId")
                        .IsRequired()
                        .HasConstraintName("FK_Rental_Transaction_Rental_Request");

                    b.HasOne("ClassLibrary.Model.User", "User")
                        .WithMany("RentalTransactions")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK_Rental_Transaction_User");

                    b.Navigation("Equipment");

                    b.Navigation("RentalRequest");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ClassLibrary.Model.ReturnRecord", b =>
                {
                    b.HasOne("ClassLibrary.Model.EquipmentCondition", "EquipmentCondition")
                        .WithMany("ReturnRecords")
                        .HasForeignKey("EquipmentConditionId")
                        .IsRequired()
                        .HasConstraintName("FK_Return_Record_Equipment_Condition");

                    b.HasOne("ClassLibrary.Model.Equipment", "Equipment")
                        .WithMany("ReturnRecords")
                        .HasForeignKey("EquipmentId")
                        .IsRequired()
                        .HasConstraintName("FK_Return_Record_Equipment");

                    b.HasOne("ClassLibrary.Model.RentalTransaction", "RentalTransaction")
                        .WithMany("ReturnRecords")
                        .HasForeignKey("RentalTransactionId")
                        .IsRequired()
                        .HasConstraintName("FK_Return_Record_Rental_Transaction");

                    b.HasOne("ClassLibrary.Model.User", "User")
                        .WithMany("ReturnRecords")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK_Return_Record_User");

                    b.Navigation("Equipment");

                    b.Navigation("EquipmentCondition");

                    b.Navigation("RentalTransaction");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ClassLibrary.Model.Category", b =>
                {
                    b.Navigation("Equipment");
                });

            modelBuilder.Entity("ClassLibrary.Model.Equipment", b =>
                {
                    b.Navigation("RentalRequests");

                    b.Navigation("RentalTransactions");

                    b.Navigation("ReturnRecords");
                });

            modelBuilder.Entity("ClassLibrary.Model.EquipmentCondition", b =>
                {
                    b.Navigation("Equipment");

                    b.Navigation("ReturnRecords");
                });

            modelBuilder.Entity("ClassLibrary.Model.EquipmentStatus", b =>
                {
                    b.Navigation("Equipment");
                });

            modelBuilder.Entity("ClassLibrary.Model.RentalRequest", b =>
                {
                    b.Navigation("RentalTransactions");
                });

            modelBuilder.Entity("ClassLibrary.Model.RentalTransaction", b =>
                {
                    b.Navigation("Documents");

                    b.Navigation("Feedbacks");

                    b.Navigation("ReturnRecords");
                });

            modelBuilder.Entity("ClassLibrary.Model.RequestStatus", b =>
                {
                    b.Navigation("RentalRequests");
                });

            modelBuilder.Entity("ClassLibrary.Model.User", b =>
                {
                    b.Navigation("Feedbacks");

                    b.Navigation("Logs");

                    b.Navigation("Notifications");

                    b.Navigation("RentalRequests");

                    b.Navigation("RentalTransactions");

                    b.Navigation("ReturnRecords");
                });
#pragma warning restore 612, 618
        }
    }
}
