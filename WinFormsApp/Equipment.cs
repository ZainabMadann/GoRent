using ClassLibrary.Model;
using Microsoft.EntityFrameworkCore;
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
    public partial class Equipment : Form
    {
        CourseDBContext context;

        public Equipment()
        {
            InitializeComponent();
            context = new CourseDBContext(); // Initialize the database context
        }

        // Navigate back to the Home form
        private void btnHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        // Form load event: populate dropdown and load data
        private void Equipment_Load(object sender, EventArgs e)
        {
            // Populate equipment status dropdown
            ddlStatus.DataSource = context.EquipmentStatuses.ToList();
            ddlStatus.DisplayMember = "Name";
            ddlStatus.ValueMember = "EquipmentStatusId";
            ddlStatus.SelectedItem = null;

            // Load equipment data into DataGridView
            RefereshGridView();
        }

        // Load and filter equipment data into the grid
        private void RefereshGridView()
        {
            dgvEquipment.DataSource = null;

            // Create a queryable for filtering
            var equipmentToSHow = context.Equipment.AsQueryable();

            // Filter by equipment name
            if (txtSearch.Text != "")
            {
                equipmentToSHow = equipmentToSHow.Where(x => x.Name.Contains(txtSearch.Text));
            }

            // Filter by selected status
            if (ddlStatus.SelectedValue != null)
            {
                equipmentToSHow = equipmentToSHow.Where(x => x.EquipmentStatus.EquipmentStatusId == Convert.ToInt32(ddlStatus.SelectedValue));
            }

            // If no results, show message
            if (equipmentToSHow.Count() < 1)
            {
                MessageBox.Show("No record found");
            }
            else
            {
                // Bind filtered results to DataGridView
                dgvEquipment.DataSource = equipmentToSHow
                    .Select(x => new
                    {
                        EquipmentID = x.EquipmentId,
                        Name = x.Name,
                        Description = x.Description,
                        RentalRate = x.RentalRate,
                        Category = x.Category.Name,
                        EquipmentCondition = x.EquipmentCondition.Name,
                        EquipmentSatus = x.EquipmentStatus.Name
                    }).ToList();
            }
        }

        // Clear filters and reload all equipment
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            ddlStatus.SelectedItem = null;
            RefereshGridView();
        }

        // Apply search filters
        private void btnSearch_Click(object sender, EventArgs e)
        {
            RefereshGridView();
        }

        // Edit selected equipment details
        private void btnEditEquipment_Click(object sender, EventArgs e)
        {
            int equipmentID = Convert.ToInt32(dgvEquipment.SelectedCells[0].OwningRow.Cells[0].Value);
            EditEquipmentDetails edit = new EditEquipmentDetails(equipmentID);
            edit.ShowDialog();

            // Refresh grid after successful edit
            if (edit.DialogResult == DialogResult.OK)
            {
                RefereshGridView();
            }
        }
    }
}
