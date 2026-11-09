namespace CATAYAS_WEEK_05_WORK_04
{
    partial class ProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Barcode = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.Category = new System.Windows.Forms.Label();
            this.Origin = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.Cost = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.Markup = new System.Windows.Forms.Label();
            this.txtboxBarcode = new System.Windows.Forms.TextBox();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.txtboxDescription = new System.Windows.Forms.TextBox();
            this.cmboCategory = new System.Windows.Forms.ComboBox();
            this.grpbxmanufactured = new System.Windows.Forms.GroupBox();
            this.radioAbroad = new System.Windows.Forms.RadioButton();
            this.radioLocal = new System.Windows.Forms.RadioButton();
            this.checkStatus = new System.Windows.Forms.CheckBox();
            this.txtboxCost = new System.Windows.Forms.TextBox();
            this.txtboxPrice = new System.Windows.Forms.TextBox();
            this.txtboxMarkup = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpbxmanufactured.SuspendLayout();
            this.SuspendLayout();
            // 
            // Barcode
            // 
            this.Barcode.AutoSize = true;
            this.Barcode.Location = new System.Drawing.Point(71, 40);
            this.Barcode.Name = "Barcode";
            this.Barcode.Size = new System.Drawing.Size(59, 16);
            this.Barcode.TabIndex = 0;
            this.Barcode.Text = "Barcode";
            this.Barcode.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(71, 123);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            this.lblName.Click += new System.EventHandler(this.Name_Click);
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(71, 163);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(75, 16);
            this.Description.TabIndex = 2;
            this.Description.Text = "Description";
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.Location = new System.Drawing.Point(71, 305);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(62, 16);
            this.Category.TabIndex = 3;
            this.Category.Text = "Category";
            // 
            // Origin
            // 
            this.Origin.AutoSize = true;
            this.Origin.Location = new System.Drawing.Point(71, 347);
            this.Origin.Name = "Origin";
            this.Origin.Size = new System.Drawing.Size(42, 16);
            this.Origin.TabIndex = 4;
            this.Origin.Text = "Origin";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(71, 441);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(44, 16);
            this.Status.TabIndex = 5;
            this.Status.Text = "Status";
            // 
            // Cost
            // 
            this.Cost.AutoSize = true;
            this.Cost.Location = new System.Drawing.Point(71, 495);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(34, 16);
            this.Cost.TabIndex = 6;
            this.Cost.Text = "Cost";
            this.Cost.Click += new System.EventHandler(this.label7_Click);
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(208, 495);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(38, 16);
            this.Price.TabIndex = 7;
            this.Price.Text = "Price";
            this.Price.Click += new System.EventHandler(this.label8_Click);
            // 
            // Markup
            // 
            this.Markup.AutoSize = true;
            this.Markup.Location = new System.Drawing.Point(375, 496);
            this.Markup.Name = "Markup";
            this.Markup.Size = new System.Drawing.Size(75, 16);
            this.Markup.TabIndex = 8;
            this.Markup.Text = "Markup (%)";
            // 
            // txtboxBarcode
            // 
            this.txtboxBarcode.Location = new System.Drawing.Point(174, 34);
            this.txtboxBarcode.Name = "txtboxBarcode";
            this.txtboxBarcode.Size = new System.Drawing.Size(304, 22);
            this.txtboxBarcode.TabIndex = 9;
            this.txtboxBarcode.TextChanged += new System.EventHandler(this.txtboxBarcode_TextChanged);
            // 
            // txtboxName
            // 
            this.txtboxName.Location = new System.Drawing.Point(174, 120);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(304, 22);
            this.txtboxName.TabIndex = 10;
            this.txtboxName.TextChanged += new System.EventHandler(this.txtboxName_TextChanged);
            // 
            // txtboxDescription
            // 
            this.txtboxDescription.Location = new System.Drawing.Point(174, 160);
            this.txtboxDescription.Multiline = true;
            this.txtboxDescription.Name = "txtboxDescription";
            this.txtboxDescription.Size = new System.Drawing.Size(304, 125);
            this.txtboxDescription.TabIndex = 11;
            this.txtboxDescription.TextChanged += new System.EventHandler(this.txtboxDescription_TextChanged);
            // 
            // cmboCategory
            // 
            this.cmboCategory.FormattingEnabled = true;
            this.cmboCategory.Location = new System.Drawing.Point(174, 299);
            this.cmboCategory.Name = "cmboCategory";
            this.cmboCategory.Size = new System.Drawing.Size(304, 24);
            this.cmboCategory.TabIndex = 12;
            this.cmboCategory.SelectedIndexChanged += new System.EventHandler(this.cmboCategory_SelectedIndexChanged);
            // 
            // grpbxmanufactured
            // 
            this.grpbxmanufactured.Controls.Add(this.radioAbroad);
            this.grpbxmanufactured.Controls.Add(this.radioLocal);
            this.grpbxmanufactured.Location = new System.Drawing.Point(174, 344);
            this.grpbxmanufactured.Name = "grpbxmanufactured";
            this.grpbxmanufactured.Size = new System.Drawing.Size(304, 72);
            this.grpbxmanufactured.TabIndex = 13;
            this.grpbxmanufactured.TabStop = false;
            this.grpbxmanufactured.Text = "Manufactured";
            this.grpbxmanufactured.Enter += new System.EventHandler(this.grpbxmanufactured_Enter);
            // 
            // radioAbroad
            // 
            this.radioAbroad.AutoSize = true;
            this.radioAbroad.Location = new System.Drawing.Point(175, 30);
            this.radioAbroad.Name = "radioAbroad";
            this.radioAbroad.Size = new System.Drawing.Size(73, 20);
            this.radioAbroad.TabIndex = 1;
            this.radioAbroad.TabStop = true;
            this.radioAbroad.Text = "Abroad";
            this.radioAbroad.UseVisualStyleBackColor = true;
            // 
            // radioLocal
            // 
            this.radioLocal.AutoSize = true;
            this.radioLocal.Location = new System.Drawing.Point(25, 31);
            this.radioLocal.Name = "radioLocal";
            this.radioLocal.Size = new System.Drawing.Size(61, 20);
            this.radioLocal.TabIndex = 0;
            this.radioLocal.TabStop = true;
            this.radioLocal.Text = "Local";
            this.radioLocal.UseVisualStyleBackColor = true;
            // 
            // checkStatus
            // 
            this.checkStatus.AutoSize = true;
            this.checkStatus.Location = new System.Drawing.Point(174, 440);
            this.checkStatus.Name = "checkStatus";
            this.checkStatus.Size = new System.Drawing.Size(66, 20);
            this.checkStatus.TabIndex = 14;
            this.checkStatus.Text = "Active";
            this.checkStatus.UseVisualStyleBackColor = true;
            this.checkStatus.CheckedChanged += new System.EventHandler(this.checkStatus_CheckedChanged);
            // 
            // txtboxCost
            // 
            this.txtboxCost.Location = new System.Drawing.Point(74, 515);
            this.txtboxCost.Name = "txtboxCost";
            this.txtboxCost.Size = new System.Drawing.Size(108, 22);
            this.txtboxCost.TabIndex = 15;
            this.txtboxCost.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtboxPrice
            // 
            this.txtboxPrice.Location = new System.Drawing.Point(211, 514);
            this.txtboxPrice.Name = "txtboxPrice";
            this.txtboxPrice.Size = new System.Drawing.Size(108, 22);
            this.txtboxPrice.TabIndex = 16;
            this.txtboxPrice.TextChanged += new System.EventHandler(this.txtboxPrice_TextChanged);
            // 
            // txtboxMarkup
            // 
            this.txtboxMarkup.Location = new System.Drawing.Point(378, 515);
            this.txtboxMarkup.Name = "txtboxMarkup";
            this.txtboxMarkup.Size = new System.Drawing.Size(100, 22);
            this.txtboxMarkup.TabIndex = 17;
            this.txtboxMarkup.TextChanged += new System.EventHandler(this.txtboxMarkup_TextChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(74, 589);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 37);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(211, 589);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(108, 37);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(378, 589);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 37);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 669);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtboxMarkup);
            this.Controls.Add(this.txtboxPrice);
            this.Controls.Add(this.txtboxCost);
            this.Controls.Add(this.checkStatus);
            this.Controls.Add(this.grpbxmanufactured);
            this.Controls.Add(this.cmboCategory);
            this.Controls.Add(this.txtboxDescription);
            this.Controls.Add(this.txtboxName);
            this.Controls.Add(this.txtboxBarcode);
            this.Controls.Add(this.Markup);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Cost);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Origin);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.Barcode);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.grpbxmanufactured.ResumeLayout(false);
            this.grpbxmanufactured.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Barcode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.Label Origin;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Label Cost;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label Markup;
        private System.Windows.Forms.TextBox txtboxBarcode;
        private System.Windows.Forms.TextBox txtboxName;
        private System.Windows.Forms.TextBox txtboxDescription;
        private System.Windows.Forms.ComboBox cmboCategory;
        private System.Windows.Forms.GroupBox grpbxmanufactured;
        private System.Windows.Forms.CheckBox checkStatus;
        private System.Windows.Forms.RadioButton radioAbroad;
        private System.Windows.Forms.RadioButton radioLocal;
        private System.Windows.Forms.TextBox txtboxCost;
        private System.Windows.Forms.TextBox txtboxPrice;
        private System.Windows.Forms.TextBox txtboxMarkup;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
    }
}