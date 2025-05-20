using ClassLibrary.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp
{
    public static class AuditLogger
    {
        public static void AddAuditLogs(CourseDBContext context, string userEmail)
        {
            var entriesToLog = new List<Log>();

            var entries = context.ChangeTracker.Entries()
                .Where(e => e.State == EntityState.Modified || e.State == EntityState.Added);

            var currentUser = context.Users.FirstOrDefault(u => u.Email == userEmail);
            if (currentUser == null)
            {
                MessageBox.Show("Could not find current user in main database for logging.");
                return;
            }

            foreach (var entry in entries)
            {
                if (entry.Entity is RentalTransaction)
                {
                    if (entry.State == EntityState.Added)
                    {
                        entriesToLog.Add(new Log
                        {
                            Action = "Created",
                            EntityChanged = "RentalTransaction",
                            OriginalValue = "N/A",
                            CurrentValue = "N/A",
                            TimeStamp = DateTime.Now,
                            UserId = currentUser.UserId
                        });
                    }
                    else if (entry.State == EntityState.Modified)
                    {
                        foreach (var prop in entry.Properties)
                        {
                            string propName = prop.Metadata.Name;

                            if (propName == "TotalCost" || propName == "RentalEndDate" || propName == "PaymentStatus")
                            {
                                if (prop.IsModified)
                                {
                                    entriesToLog.Add(new Log
                                    {
                                        Action = "Modified",
                                        EntityChanged = "RentalTransaction",
                                        OriginalValue = prop.OriginalValue?.ToString() ?? "null",
                                        CurrentValue = prop.CurrentValue?.ToString() ?? "null",
                                        TimeStamp = DateTime.Now,
                                        UserId = currentUser.UserId
                                    });
                                }
                            }
                        }
                    }
                }
            }

            context.Logs.AddRange(entriesToLog);
        }
    }
}
