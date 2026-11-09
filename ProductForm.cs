using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CATAYAS_WEEK_05_WORK_04
{
    public partial class ProductForm : Form
    {
        private readonly ErrorProvider errProvider = new ErrorProvider();

        public ProductForm()
        {
            InitializeComponent();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            errProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            txtboxBarcode.MaxLength = 13;
            txtboxName.MaxLength = 50;
            txtboxDescription.MaxLength = 200;
            txtboxPrice.ReadOnly = true;
            cmboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            if (cmboCategory.Items.Count == 0)
            {
                cmboCategory.Items.AddRange(new object[] { "Beverages", "Snacks", "Groceries", "Household", "Personal Care", "Others" });
            }
            txtboxBarcode.KeyPress += DigitsOnly_KeyPress;
            txtboxCost.KeyPress += Decimal_KeyPress;
            txtboxMarkup.KeyPress += Decimal_KeyPress;
            txtboxBarcode.TextChanged += (s, ev) => errProvider.SetError(txtboxBarcode, "");
            txtboxName.TextChanged += (s, ev) => errProvider.SetError(txtboxName, "");
            cmboCategory.SelectedIndexChanged += (s, ev) => errProvider.SetError(cmboCategory, "");
            foreach (RadioButton rb in grpbxmanufactured.Controls.OfType<RadioButton>())
            {
                rb.CheckedChanged += (s, ev) => errProvider.SetError(grpbxmanufactured, "");
            }
            txtboxBarcode.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void DigitsOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Decimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            Control tb = (Control)sender;
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar))
            {
                return;
            }
            if (e.KeyChar == '.' && !tb.Text.Contains("."))
            {
                return;
            }
            e.Handled = true;
        }

        private void txtboxBarcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grpbxmanufactured_Enter(object sender, EventArgs e)
        {

        }

        private void checkStatus_CheckedChanged(object sender, EventArgs e)
        {
            checkStatus.Text = checkStatus.Checked ? "Active" : "Inactive";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            ComputePrice();
        }

        private void txtboxPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxMarkup_TextChanged(object sender, EventArgs e)
        {
            ComputePrice();
        }

        private void ComputePrice()
        {
            decimal cost, markup;
            bool okCost = decimal.TryParse(txtboxCost.Text, NumberStyles.Number, CultureInfo.CurrentCulture, out cost);
            bool okMarkup = decimal.TryParse(txtboxMarkup.Text, NumberStyles.Number, CultureInfo.CurrentCulture, out markup);
            if (okCost && okMarkup)
            {
                txtboxPrice.Text = (cost + (cost * markup / 100m)).ToString("N2");
            }
            else
            {
                txtboxPrice.Clear();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel? Unsaved changes will be lost.",
                "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                return;
            }
            string origin = grpbxmanufactured.Controls.OfType<RadioButton>().First(r => r.Checked).Text;
            string summary =
                "Barcode: " + txtboxBarcode.Text.Trim() + Environment.NewLine +
                "Name: " + txtboxName.Text.Trim() + Environment.NewLine +
                "Description: " + txtboxDescription.Text.Trim() + Environment.NewLine +
                "Category: " + cmboCategory.Text + Environment.NewLine +
                "Manufactured: " + origin + Environment.NewLine +
                "Status: " + (checkStatus.Checked ? "Active" : "Inactive") + Environment.NewLine +
                "Cost: " + txtboxCost.Text + Environment.NewLine +
                "Markup: " + txtboxMarkup.Text + "%" + Environment.NewLine +
                "Price: " + txtboxPrice.Text;
            MessageBox.Show(summary, "Product Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearForm();
        }

        private bool ValidateForm()
        {
            bool valid = true;
            Control firstInvalid = null;
            errProvider.Clear();
            if (string.IsNullOrWhiteSpace(txtboxBarcode.Text))
            {
                valid = Fail(txtboxBarcode, "Barcode is required.", ref firstInvalid);
            }
            else if (txtboxBarcode.Text.Trim().Length < 8)
            {
                valid = Fail(txtboxBarcode, "Barcode must be 8 to 13 digits.", ref firstInvalid);
            }
            if (string.IsNullOrWhiteSpace(txtboxName.Text))
            {
                valid = Fail(txtboxName, "Product name is required.", ref firstInvalid);
            }
            if (cmboCategory.SelectedIndex < 0)
            {
                valid = Fail(cmboCategory, "Please select a category.", ref firstInvalid);
            }
            if (!grpbxmanufactured.Controls.OfType<RadioButton>().Any(r => r.Checked))
            {
                valid = Fail(grpbxmanufactured, "Please select Local or Abroad.", ref firstInvalid);
            }
            decimal cost;
            if (!decimal.TryParse(txtboxCost.Text, NumberStyles.Number, CultureInfo.CurrentCulture, out cost) || cost <= 0)
            {
                valid = Fail(txtboxCost, "Enter a cost greater than 0.", ref firstInvalid);
            }
            decimal markup;
            if (!decimal.TryParse(txtboxMarkup.Text, NumberStyles.Number, CultureInfo.CurrentCulture, out markup) || markup < 0 || markup > 1000)
            {
                valid = Fail(txtboxMarkup, "Enter a markup from 0 to 1000.", ref firstInvalid);
            }
            if (!valid)
            {
                MessageBox.Show("Please fix the fields marked with the red icon.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                firstInvalid.Focus();
            }
            return valid;
        }

        private bool Fail(Control ctrl, string message, ref Control firstInvalid)
        {
            errProvider.SetError(ctrl, message);
            if (firstInvalid == null)
            {
                firstInvalid = ctrl;
            }
            return false;
        }

        private void ClearForm()
        {
            errProvider.Clear();
            txtboxBarcode.Clear();
            txtboxName.Clear();
            txtboxDescription.Clear();
            cmboCategory.SelectedIndex = -1;
            foreach (RadioButton rb in grpbxmanufactured.Controls.OfType<RadioButton>())
            {
                rb.Checked = false;
            }
            checkStatus.Checked = false;
            txtboxCost.Clear();
            txtboxMarkup.Clear();
            txtboxPrice.Clear();
            txtboxBarcode.Focus();
        }

        private void Name_Click(object sender, EventArgs e)
        {

        }
    }
}