using ClassLibrary.Model; // Importing the model classes from the class library
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class AdminLogs : Form
    {
        CourseDBContext context; // Database context for accessing the database

        public AdminLogs()
        {
            InitializeComponent(); // Initialize UI components
            context = new CourseDBContext(); // Instantiate the database context
        }

        // Method to refresh and filter the DataGridView based on search inputs
        private void RefereshGridView()
        {
            dgvLogs.DataSource = null; // Clear the current data source

            var logsToSHow = context.Logs.AsQueryable(); // Start with all logs

            // Filter by email if the search textbox is not empty
            if (txtSearch.Text != "")
            {
                logsToSHow = logsToSHow.Where(x => x.User.Email == txtSearch.Text);
            }

            // Filter by action if an action is selected in the dropdown
            if (ddlAction.SelectedItem != null)
            {
                string action = ddlAction.SelectedItem.ToString();
                logsToSHow = logsToSHow.Where(x => x.Action == action);
            }

            // If no records are found, show a message box
            if (logsToSHow.Count() < 1)
            {
                MessageBox.Show("No record found");
            }
            else
            {
                // Bind the filtered logs to the DataGridView with selected columns
                dgvLogs.DataSource = logsToSHow
                    .Select(x => new
                    {
                        logID = x.LogId,
                        Action = x.Action,
                        User = x.User.Email,
                        currentValue = x.CurrentValue,
                        origenalValue = x.OriginalValue,
                        EntityChanged = x.EntityChanged
                    })
                    .ToList();
            }
        }

        // Event handler for Home button click - navigates to the Home form
        private void btnHome_Click(object sender, EventArgs e)
        {
            Home home = new Home(); // Create a new Home form
            this.Hide(); // Hide the current form
            home.Show(); // Show the Home form
        }

        // Event handler when the AdminLogs form loads
        private void AdminLogs_Load(object sender, EventArgs e)
        {
            RefereshGridView(); // Load logs into the DataGridView on form load
        }

        // Event handler for Refresh button click - resets filters and reloads data
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = ""; // Clear search textbox
            ddlAction.SelectedItem = null; // Reset dropdown selection
            RefereshGridView(); // Reload the grid view
        }

        // Event handler for Search button click - applies filters and updates data
        private void btnSearch_Click(object sender, EventArgs e)
        {
            RefereshGridView(); // Reload the grid with search filters
        }
    }
}
