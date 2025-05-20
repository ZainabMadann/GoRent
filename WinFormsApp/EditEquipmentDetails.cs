using ClassLibrary.Model;
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
    public partial class EditEquipmentDetails : Form
    {
        CourseDBContext context;
        int equipmentID;
        ClassLibrary.Model.Equipment equipment;

        public EditEquipmentDetails(int equipmentID)
        {
            InitializeComponent();
            context = new CourseDBContext();
            this.equipmentID = equipmentID;
        }

        private void EditEquipmentDetails_Load(object sender, EventArgs e)
        {
            equipment = context.Equipment.Single(x => x.EquipmentId == equipmentID);

            // Populating the drop down lists with values
            ddlCategory.DataSource = context.Categories.ToList();
            ddlCategory.DisplayMember = "Name";
            ddlCategory.ValueMember = "CategoryId";
            ddlCategory.SelectedItem = null;

            ddlStatus.DataSource = context.EquipmentStatuses.ToList();
            ddlStatus.DisplayMember = "Name";
            ddlStatus.ValueMember = "EquipmentStatusId";
            ddlStatus.SelectedItem = null;

            ddlCondition.DataSource = context.EquipmentConditions.ToList();
            ddlCondition.DisplayMember = "Name";
            ddlCondition.ValueMember = "EquipmentConditionId";
            ddlCondition.SelectedItem = null;

            // Populating the fields with the equipment info
            txtEquipmentID.Text = equipment.EquipmentId.ToString();
            txtDescription.Text = equipment.Description.ToString();
            txtRentalRate.Text = equipment.RentalRate.ToString();
            txtName.Text = equipment.Name;
            ddlCategory.SelectedValue = equipment.CategoryId;
            ddlCondition.SelectedValue = equipment.EquipmentConditionId;
            ddlStatus.SelectedValue = equipment.EquipmentStatusId;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate Name
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("Please enter the equipment name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate Description
                if (string.IsNullOrWhiteSpace(txtDescription.Text))
                {
                    MessageBox.Show("Please enter the description.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate Rental Rate
                if (!decimal.TryParse(txtRentalRate.Text, out decimal rentalRate) || rentalRate < 0)
                {
                    MessageBox.Show("Please enter a valid rental rate.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate Category
                if (ddlCategory.SelectedValue == null)
                {
                    MessageBox.Show("Please select a category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate Condition
                if (ddlCondition.SelectedItem == null)
                {
                    MessageBox.Show("Please select the equipment condition.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate Status
                if (ddlStatus.SelectedItem == null)
                {
                    MessageBox.Show("Please select the equipment status.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Update the equipment fields
                equipment.Name = txtName.Text;
                equipment.Description = txtDescription.Text;
                equipment.RentalRate = rentalRate;
                equipment.CategoryId = Convert.ToInt32(ddlCategory.SelectedValue);
                equipment.EquipmentConditionId = Convert.ToInt32(ddlCondition.SelectedValue);
                equipment.EquipmentStatusId = Convert.ToInt32(ddlStatus.SelectedValue);

                // Save changes
                context.Equipment.Update(equipment);
                context.SaveChanges();

                MessageBox.Show("Equipment updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating equipment.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
