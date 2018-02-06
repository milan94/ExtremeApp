namespace ExtremeIS
{
    partial class AddGearForm
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
            this.checkBoxMultipleSizes = new System.Windows.Forms.CheckBox();
            this.cBoxGearSize = new System.Windows.Forms.ComboBox();
            this.lblGearSize = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.nUpDownGearQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnAddGearConfirm = new System.Windows.Forms.Button();
            this.btnAddGearCancle = new System.Windows.Forms.Button();
            this.groupBoxSizes = new System.Windows.Forms.GroupBox();
            this.checkBoxXS = new System.Windows.Forms.CheckBox();
            this.checkBoxS = new System.Windows.Forms.CheckBox();
            this.checkBoxM = new System.Windows.Forms.CheckBox();
            this.checkBoxL = new System.Windows.Forms.CheckBox();
            this.nUpDownXXL = new System.Windows.Forms.NumericUpDown();
            this.checkBoxXL = new System.Windows.Forms.CheckBox();
            this.nUpDownXL = new System.Windows.Forms.NumericUpDown();
            this.checkBoxXXL = new System.Windows.Forms.CheckBox();
            this.nUpDownL = new System.Windows.Forms.NumericUpDown();
            this.nUpDownXS = new System.Windows.Forms.NumericUpDown();
            this.nUpDownM = new System.Windows.Forms.NumericUpDown();
            this.nUpDownS = new System.Windows.Forms.NumericUpDown();
            this.groupBoxBasicInfo = new System.Windows.Forms.GroupBox();
            this.cBoxGearName = new System.Windows.Forms.ComboBox();
            this.rTextBoxGearDescription = new System.Windows.Forms.RichTextBox();
            this.cBoxGearCategory = new System.Windows.Forms.ComboBox();
            this.cBoxGearManufacturer = new System.Windows.Forms.ComboBox();
            this.lblRemark = new System.Windows.Forms.Label();
            this.lblGearCategory = new System.Windows.Forms.Label();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.lblGearName = new System.Windows.Forms.Label();
            this.lblGearNameError = new System.Windows.Forms.Label();
            this.lblGearCategoryError = new System.Windows.Forms.Label();
            this.lblGearManufacturerError = new System.Windows.Forms.Label();
            this.lblGearSizeError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownGearQuantity)).BeginInit();
            this.groupBoxSizes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownXXL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownXL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownXS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownS)).BeginInit();
            this.groupBoxBasicInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxMultipleSizes
            // 
            this.checkBoxMultipleSizes.AutoSize = true;
            this.checkBoxMultipleSizes.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxMultipleSizes.Location = new System.Drawing.Point(610, 152);
            this.checkBoxMultipleSizes.Name = "checkBoxMultipleSizes";
            this.checkBoxMultipleSizes.Size = new System.Drawing.Size(241, 21);
            this.checkBoxMultipleSizes.TabIndex = 34;
            this.checkBoxMultipleSizes.Text = "Omogući unos više veličina          ";
            this.checkBoxMultipleSizes.UseVisualStyleBackColor = true;
            this.checkBoxMultipleSizes.CheckedChanged += new System.EventHandler(this.checkBoxMultipleSizes_CheckedChanged);
            // 
            // cBoxGearSize
            // 
            this.cBoxGearSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxGearSize.FormattingEnabled = true;
            this.cBoxGearSize.Location = new System.Drawing.Point(739, 110);
            this.cBoxGearSize.Name = "cBoxGearSize";
            this.cBoxGearSize.Size = new System.Drawing.Size(110, 24);
            this.cBoxGearSize.TabIndex = 36;
            // 
            // lblGearSize
            // 
            this.lblGearSize.AutoSize = true;
            this.lblGearSize.Location = new System.Drawing.Point(609, 113);
            this.lblGearSize.Name = "lblGearSize";
            this.lblGearSize.Size = new System.Drawing.Size(61, 17);
            this.lblGearSize.TabIndex = 35;
            this.lblGearSize.Text = "Veličina:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(609, 74);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(70, 17);
            this.lblQuantity.TabIndex = 51;
            this.lblQuantity.Text = "Količina:";
            // 
            // nUpDownGearQuantity
            // 
            this.nUpDownGearQuantity.Location = new System.Drawing.Point(739, 73);
            this.nUpDownGearQuantity.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nUpDownGearQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUpDownGearQuantity.Name = "nUpDownGearQuantity";
            this.nUpDownGearQuantity.Size = new System.Drawing.Size(110, 22);
            this.nUpDownGearQuantity.TabIndex = 52;
            this.nUpDownGearQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUpDownGearQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddGearConfirm
            // 
            this.btnAddGearConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGearConfirm.Location = new System.Drawing.Point(355, 369);
            this.btnAddGearConfirm.Name = "btnAddGearConfirm";
            this.btnAddGearConfirm.Size = new System.Drawing.Size(127, 32);
            this.btnAddGearConfirm.TabIndex = 53;
            this.btnAddGearConfirm.Text = "Potvrdi";
            this.btnAddGearConfirm.UseVisualStyleBackColor = true;
            this.btnAddGearConfirm.Click += new System.EventHandler(this.btnAddGearConfirm_Click);
            // 
            // btnAddGearCancle
            // 
            this.btnAddGearCancle.Location = new System.Drawing.Point(507, 369);
            this.btnAddGearCancle.Name = "btnAddGearCancle";
            this.btnAddGearCancle.Size = new System.Drawing.Size(127, 32);
            this.btnAddGearCancle.TabIndex = 54;
            this.btnAddGearCancle.Text = "Odustani";
            this.btnAddGearCancle.UseVisualStyleBackColor = true;
            // 
            // groupBoxSizes
            // 
            this.groupBoxSizes.Controls.Add(this.checkBoxXS);
            this.groupBoxSizes.Controls.Add(this.checkBoxS);
            this.groupBoxSizes.Controls.Add(this.checkBoxM);
            this.groupBoxSizes.Controls.Add(this.checkBoxL);
            this.groupBoxSizes.Controls.Add(this.nUpDownXXL);
            this.groupBoxSizes.Controls.Add(this.checkBoxXL);
            this.groupBoxSizes.Controls.Add(this.nUpDownXL);
            this.groupBoxSizes.Controls.Add(this.checkBoxXXL);
            this.groupBoxSizes.Controls.Add(this.nUpDownL);
            this.groupBoxSizes.Controls.Add(this.nUpDownXS);
            this.groupBoxSizes.Controls.Add(this.nUpDownM);
            this.groupBoxSizes.Controls.Add(this.nUpDownS);
            this.groupBoxSizes.Enabled = false;
            this.groupBoxSizes.Location = new System.Drawing.Point(507, 217);
            this.groupBoxSizes.Name = "groupBoxSizes";
            this.groupBoxSizes.Size = new System.Drawing.Size(450, 125);
            this.groupBoxSizes.TabIndex = 55;
            this.groupBoxSizes.TabStop = false;
            this.groupBoxSizes.Text = "Izbor veličina i broja stavki:";
            // 
            // checkBoxXS
            // 
            this.checkBoxXS.AutoSize = true;
            this.checkBoxXS.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxXS.Location = new System.Drawing.Point(28, 39);
            this.checkBoxXS.Name = "checkBoxXS";
            this.checkBoxXS.Size = new System.Drawing.Size(48, 21);
            this.checkBoxXS.TabIndex = 52;
            this.checkBoxXS.Text = "XS";
            this.checkBoxXS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxXS.UseVisualStyleBackColor = true;
            this.checkBoxXS.CheckedChanged += new System.EventHandler(this.checkBoxXS_CheckedChanged);
            // 
            // checkBoxS
            // 
            this.checkBoxS.AutoSize = true;
            this.checkBoxS.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxS.Location = new System.Drawing.Point(97, 39);
            this.checkBoxS.Name = "checkBoxS";
            this.checkBoxS.Size = new System.Drawing.Size(39, 21);
            this.checkBoxS.TabIndex = 53;
            this.checkBoxS.Text = "S";
            this.checkBoxS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxS.UseVisualStyleBackColor = true;
            this.checkBoxS.CheckedChanged += new System.EventHandler(this.checkBoxS_CheckedChanged);
            // 
            // checkBoxM
            // 
            this.checkBoxM.AutoSize = true;
            this.checkBoxM.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxM.Location = new System.Drawing.Point(165, 39);
            this.checkBoxM.Name = "checkBoxM";
            this.checkBoxM.Size = new System.Drawing.Size(41, 21);
            this.checkBoxM.TabIndex = 54;
            this.checkBoxM.Text = "M";
            this.checkBoxM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxM.UseVisualStyleBackColor = true;
            this.checkBoxM.CheckedChanged += new System.EventHandler(this.checkBoxM_CheckedChanged);
            // 
            // checkBoxL
            // 
            this.checkBoxL.AutoSize = true;
            this.checkBoxL.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxL.Location = new System.Drawing.Point(234, 39);
            this.checkBoxL.Name = "checkBoxL";
            this.checkBoxL.Size = new System.Drawing.Size(38, 21);
            this.checkBoxL.TabIndex = 55;
            this.checkBoxL.Text = "L";
            this.checkBoxL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxL.UseVisualStyleBackColor = true;
            this.checkBoxL.CheckedChanged += new System.EventHandler(this.checkBoxL_CheckedChanged);
            // 
            // nUpDownXXL
            // 
            this.nUpDownXXL.Enabled = false;
            this.nUpDownXXL.Location = new System.Drawing.Point(374, 75);
            this.nUpDownXXL.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nUpDownXXL.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUpDownXXL.Name = "nUpDownXXL";
            this.nUpDownXXL.Size = new System.Drawing.Size(47, 22);
            this.nUpDownXXL.TabIndex = 63;
            this.nUpDownXXL.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkBoxXL
            // 
            this.checkBoxXL.AutoSize = true;
            this.checkBoxXL.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxXL.Location = new System.Drawing.Point(303, 39);
            this.checkBoxXL.Name = "checkBoxXL";
            this.checkBoxXL.Size = new System.Drawing.Size(47, 21);
            this.checkBoxXL.TabIndex = 56;
            this.checkBoxXL.Text = "XL";
            this.checkBoxXL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxXL.UseVisualStyleBackColor = true;
            this.checkBoxXL.CheckedChanged += new System.EventHandler(this.checkBoxXL_CheckedChanged);
            // 
            // nUpDownXL
            // 
            this.nUpDownXL.Enabled = false;
            this.nUpDownXL.Location = new System.Drawing.Point(303, 75);
            this.nUpDownXL.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nUpDownXL.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUpDownXL.Name = "nUpDownXL";
            this.nUpDownXL.Size = new System.Drawing.Size(47, 22);
            this.nUpDownXL.TabIndex = 62;
            this.nUpDownXL.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkBoxXXL
            // 
            this.checkBoxXXL.AutoSize = true;
            this.checkBoxXXL.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxXXL.Location = new System.Drawing.Point(374, 39);
            this.checkBoxXXL.Name = "checkBoxXXL";
            this.checkBoxXXL.Size = new System.Drawing.Size(56, 21);
            this.checkBoxXXL.TabIndex = 57;
            this.checkBoxXXL.Text = "XXL";
            this.checkBoxXXL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxXXL.UseVisualStyleBackColor = true;
            this.checkBoxXXL.CheckedChanged += new System.EventHandler(this.checkBoxXXL_CheckedChanged);
            // 
            // nUpDownL
            // 
            this.nUpDownL.Enabled = false;
            this.nUpDownL.Location = new System.Drawing.Point(234, 75);
            this.nUpDownL.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nUpDownL.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUpDownL.Name = "nUpDownL";
            this.nUpDownL.Size = new System.Drawing.Size(47, 22);
            this.nUpDownL.TabIndex = 61;
            this.nUpDownL.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nUpDownXS
            // 
            this.nUpDownXS.Enabled = false;
            this.nUpDownXS.Location = new System.Drawing.Point(28, 75);
            this.nUpDownXS.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nUpDownXS.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUpDownXS.Name = "nUpDownXS";
            this.nUpDownXS.Size = new System.Drawing.Size(47, 22);
            this.nUpDownXS.TabIndex = 58;
            this.nUpDownXS.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nUpDownM
            // 
            this.nUpDownM.Enabled = false;
            this.nUpDownM.Location = new System.Drawing.Point(165, 75);
            this.nUpDownM.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nUpDownM.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUpDownM.Name = "nUpDownM";
            this.nUpDownM.Size = new System.Drawing.Size(47, 22);
            this.nUpDownM.TabIndex = 60;
            this.nUpDownM.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nUpDownS
            // 
            this.nUpDownS.Enabled = false;
            this.nUpDownS.Location = new System.Drawing.Point(97, 75);
            this.nUpDownS.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nUpDownS.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUpDownS.Name = "nUpDownS";
            this.nUpDownS.Size = new System.Drawing.Size(47, 22);
            this.nUpDownS.TabIndex = 59;
            this.nUpDownS.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBoxBasicInfo
            // 
            this.groupBoxBasicInfo.Controls.Add(this.lblGearManufacturerError);
            this.groupBoxBasicInfo.Controls.Add(this.lblGearCategoryError);
            this.groupBoxBasicInfo.Controls.Add(this.lblGearNameError);
            this.groupBoxBasicInfo.Controls.Add(this.cBoxGearName);
            this.groupBoxBasicInfo.Controls.Add(this.rTextBoxGearDescription);
            this.groupBoxBasicInfo.Controls.Add(this.cBoxGearCategory);
            this.groupBoxBasicInfo.Controls.Add(this.cBoxGearManufacturer);
            this.groupBoxBasicInfo.Controls.Add(this.lblRemark);
            this.groupBoxBasicInfo.Controls.Add(this.lblGearCategory);
            this.groupBoxBasicInfo.Controls.Add(this.lblManufacturer);
            this.groupBoxBasicInfo.Controls.Add(this.lblGearName);
            this.groupBoxBasicInfo.Location = new System.Drawing.Point(32, 24);
            this.groupBoxBasicInfo.Name = "groupBoxBasicInfo";
            this.groupBoxBasicInfo.Size = new System.Drawing.Size(450, 318);
            this.groupBoxBasicInfo.TabIndex = 56;
            this.groupBoxBasicInfo.TabStop = false;
            this.groupBoxBasicInfo.Text = "Osnovni podaci";
            // 
            // cBoxGearName
            // 
            this.cBoxGearName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBoxGearName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxGearName.FormattingEnabled = true;
            this.cBoxGearName.Location = new System.Drawing.Point(153, 41);
            this.cBoxGearName.Name = "cBoxGearName";
            this.cBoxGearName.Size = new System.Drawing.Size(265, 24);
            this.cBoxGearName.TabIndex = 19;
            this.cBoxGearName.SelectedIndexChanged += new System.EventHandler(this.cBoxGearName_SelectedIndexChanged);
            // 
            // rTextBoxGearDescription
            // 
            this.rTextBoxGearDescription.Location = new System.Drawing.Point(153, 198);
            this.rTextBoxGearDescription.Name = "rTextBoxGearDescription";
            this.rTextBoxGearDescription.Size = new System.Drawing.Size(265, 92);
            this.rTextBoxGearDescription.TabIndex = 18;
            this.rTextBoxGearDescription.Text = "";
            // 
            // cBoxGearCategory
            // 
            this.cBoxGearCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxGearCategory.FormattingEnabled = true;
            this.cBoxGearCategory.Location = new System.Drawing.Point(153, 145);
            this.cBoxGearCategory.Name = "cBoxGearCategory";
            this.cBoxGearCategory.Size = new System.Drawing.Size(265, 24);
            this.cBoxGearCategory.TabIndex = 17;
            // 
            // cBoxGearManufacturer
            // 
            this.cBoxGearManufacturer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBoxGearManufacturer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxGearManufacturer.FormattingEnabled = true;
            this.cBoxGearManufacturer.Location = new System.Drawing.Point(153, 93);
            this.cBoxGearManufacturer.Name = "cBoxGearManufacturer";
            this.cBoxGearManufacturer.Size = new System.Drawing.Size(265, 24);
            this.cBoxGearManufacturer.TabIndex = 16;
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Location = new System.Drawing.Point(20, 198);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(81, 17);
            this.lblRemark.TabIndex = 14;
            this.lblRemark.Text = "Napomena:";
            // 
            // lblGearCategory
            // 
            this.lblGearCategory.AutoSize = true;
            this.lblGearCategory.Location = new System.Drawing.Point(20, 148);
            this.lblGearCategory.Name = "lblGearCategory";
            this.lblGearCategory.Size = new System.Drawing.Size(76, 17);
            this.lblGearCategory.TabIndex = 13;
            this.lblGearCategory.Text = "Kategorija:";
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Location = new System.Drawing.Point(20, 96);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(85, 17);
            this.lblManufacturer.TabIndex = 12;
            this.lblManufacturer.Text = "Proizvodjač:";
            // 
            // lblGearName
            // 
            this.lblGearName.AutoSize = true;
            this.lblGearName.Location = new System.Drawing.Point(20, 44);
            this.lblGearName.Name = "lblGearName";
            this.lblGearName.Size = new System.Drawing.Size(101, 17);
            this.lblGearName.TabIndex = 11;
            this.lblGearName.Text = "Detaljan naziv:";
            this.lblGearName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGearNameError
            // 
            this.lblGearNameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGearNameError.ForeColor = System.Drawing.Color.Red;
            this.lblGearNameError.Location = new System.Drawing.Point(153, 68);
            this.lblGearNameError.Name = "lblGearNameError";
            this.lblGearNameError.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblGearNameError.Size = new System.Drawing.Size(265, 23);
            this.lblGearNameError.TabIndex = 57;
            // 
            // lblGearCategoryError
            // 
            this.lblGearCategoryError.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGearCategoryError.ForeColor = System.Drawing.Color.Red;
            this.lblGearCategoryError.Location = new System.Drawing.Point(153, 119);
            this.lblGearCategoryError.Name = "lblGearCategoryError";
            this.lblGearCategoryError.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblGearCategoryError.Size = new System.Drawing.Size(265, 23);
            this.lblGearCategoryError.TabIndex = 58;
            // 
            // lblGearManufacturerError
            // 
            this.lblGearManufacturerError.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGearManufacturerError.ForeColor = System.Drawing.Color.Red;
            this.lblGearManufacturerError.Location = new System.Drawing.Point(153, 172);
            this.lblGearManufacturerError.Name = "lblGearManufacturerError";
            this.lblGearManufacturerError.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblGearManufacturerError.Size = new System.Drawing.Size(265, 23);
            this.lblGearManufacturerError.TabIndex = 59;
            // 
            // lblGearSizeError
            // 
            this.lblGearSizeError.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGearSizeError.ForeColor = System.Drawing.Color.Red;
            this.lblGearSizeError.Location = new System.Drawing.Point(753, 185);
            this.lblGearSizeError.Name = "lblGearSizeError";
            this.lblGearSizeError.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblGearSizeError.Size = new System.Drawing.Size(100, 23);
            this.lblGearSizeError.TabIndex = 60;
            // 
            // AddGearForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 424);
            this.Controls.Add(this.lblGearSizeError);
            this.Controls.Add(this.groupBoxBasicInfo);
            this.Controls.Add(this.groupBoxSizes);
            this.Controls.Add(this.btnAddGearCancle);
            this.Controls.Add(this.btnAddGearConfirm);
            this.Controls.Add(this.nUpDownGearQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.cBoxGearSize);
            this.Controls.Add(this.lblGearSize);
            this.Controls.Add(this.checkBoxMultipleSizes);
            this.Name = "AddGearForm";
            this.Text = "Dodavanje opreme";
            this.Load += new System.EventHandler(this.AddGearForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownGearQuantity)).EndInit();
            this.groupBoxSizes.ResumeLayout(false);
            this.groupBoxSizes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownXXL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownXL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownXS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownS)).EndInit();
            this.groupBoxBasicInfo.ResumeLayout(false);
            this.groupBoxBasicInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBoxMultipleSizes;
        private System.Windows.Forms.ComboBox cBoxGearSize;
        private System.Windows.Forms.Label lblGearSize;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown nUpDownGearQuantity;
        private System.Windows.Forms.Button btnAddGearConfirm;
        private System.Windows.Forms.Button btnAddGearCancle;
        private System.Windows.Forms.GroupBox groupBoxSizes;
        private System.Windows.Forms.CheckBox checkBoxXS;
        private System.Windows.Forms.CheckBox checkBoxS;
        private System.Windows.Forms.CheckBox checkBoxM;
        private System.Windows.Forms.CheckBox checkBoxL;
        private System.Windows.Forms.NumericUpDown nUpDownXXL;
        private System.Windows.Forms.CheckBox checkBoxXL;
        private System.Windows.Forms.NumericUpDown nUpDownXL;
        private System.Windows.Forms.CheckBox checkBoxXXL;
        private System.Windows.Forms.NumericUpDown nUpDownL;
        private System.Windows.Forms.NumericUpDown nUpDownXS;
        private System.Windows.Forms.NumericUpDown nUpDownM;
        private System.Windows.Forms.NumericUpDown nUpDownS;
        private System.Windows.Forms.GroupBox groupBoxBasicInfo;
        private System.Windows.Forms.RichTextBox rTextBoxGearDescription;
        private System.Windows.Forms.ComboBox cBoxGearCategory;
        private System.Windows.Forms.ComboBox cBoxGearManufacturer;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.Label lblGearCategory;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.Label lblGearName;
        private System.Windows.Forms.ComboBox cBoxGearName;
        private System.Windows.Forms.Label lblGearNameError;
        private System.Windows.Forms.Label lblGearManufacturerError;
        private System.Windows.Forms.Label lblGearCategoryError;
        private System.Windows.Forms.Label lblGearSizeError;
    }
}