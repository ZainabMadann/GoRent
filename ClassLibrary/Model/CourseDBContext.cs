using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ClassLibrary.Model
{
    public partial class CourseDBContext : DbContext
    {
        public CourseDBContext()
        {
        }

        public CourseDBContext(DbContextOptions<CourseDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Document> Documents { get; set; } = null!;
        public virtual DbSet<Equipment> Equipment { get; set; } = null!;
        public virtual DbSet<EquipmentCondition> EquipmentConditions { get; set; } = null!;
        public virtual DbSet<EquipmentStatus> EquipmentStatuses { get; set; } = null!;
        public virtual DbSet<Feedback> Feedbacks { get; set; } = null!;
        public virtual DbSet<Log> Logs { get; set; } = null!;
        public virtual DbSet<Notification> Notifications { get; set; } = null!;
        public virtual DbSet<RentalRequest> RentalRequests { get; set; } = null!;
        public virtual DbSet<RentalTransaction> RentalTransactions { get; set; } = null!;
        public virtual DbSet<RequestStatus> RequestStatuses { get; set; } = null!;
        public virtual DbSet<ReturnRecord> ReturnRecords { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=GoRentDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Document>(entity =>
            {
                entity.HasOne(d => d.RentalTransaction)
                    .WithMany(p => p.Documents)
                    .HasForeignKey(d => d.RentalTransactionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Document_Rental_Transaction");
            });

            modelBuilder.Entity<Equipment>(entity =>
            {
                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Equipment)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Equipment_Category");

                entity.HasOne(d => d.EquipmentCondition)
                    .WithMany(p => p.Equipment)
                    .HasForeignKey(d => d.EquipmentConditionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Equipment_Equipment_Condition");

                entity.HasOne(d => d.EquipmentStatus)
                    .WithMany(p => p.Equipment)
                    .HasForeignKey(d => d.EquipmentStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Equipment_Equipment_Status");
            });

            modelBuilder.Entity<Feedback>(entity =>
            {
                entity.HasOne(d => d.RentalTransaction)
                    .WithMany(p => p.Feedbacks)
                    .HasForeignKey(d => d.RentalTransactionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Feedback_Rental_Transaction");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Feedbacks)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Feedback_User");
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.Property(e => e.TimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Logs)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Log_User");
            });

            modelBuilder.Entity<Notification>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.Notifications)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Notification_User");
            });

            modelBuilder.Entity<RentalRequest>(entity =>
            {
                entity.HasOne(d => d.Equipment)
                    .WithMany(p => p.RentalRequests)
                    .HasForeignKey(d => d.EquipmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rental_Request_Equipment");

                entity.HasOne(d => d.RequestStatus)
                    .WithMany(p => p.RentalRequests)
                    .HasForeignKey(d => d.RequestStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rental_Request_Request_Status");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RentalRequests)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rental_Request_User");
            });

            modelBuilder.Entity<RentalTransaction>(entity =>
            {
                entity.HasOne(d => d.Equipment)
                    .WithMany(p => p.RentalTransactions)
                    .HasForeignKey(d => d.EquipmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rental_Transaction_Equipment");

                entity.HasOne(d => d.RentalRequest)
                    .WithMany(p => p.RentalTransactions)
                    .HasForeignKey(d => d.RentalRequestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rental_Transaction_Rental_Request");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RentalTransactions)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rental_Transaction_User");
            });

            modelBuilder.Entity<ReturnRecord>(entity =>
            {
                entity.Property(e => e.ReturnRecordId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.EquipmentCondition)
                    .WithMany(p => p.ReturnRecords)
                    .HasForeignKey(d => d.EquipmentConditionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Return_Record_Equipment_Condition");

                entity.HasOne(d => d.Equipment)
                    .WithMany(p => p.ReturnRecords)
                    .HasForeignKey(d => d.EquipmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Return_Record_Equipment");

                entity.HasOne(d => d.RentalTransaction)
                    .WithMany(p => p.ReturnRecords)
                    .HasForeignKey(d => d.RentalTransactionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Return_Record_Rental_Transaction");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ReturnRecords)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Return_Record_User");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
