namespace ExtremeIS
{
    partial class DailyTicketForm
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.textBoxVisitorName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTicketType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTicketPrice = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.numTicketQuantity = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numTicketQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(63, 300);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(135, 35);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "Potvrdi";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(229, 300);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(124, 35);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // textBoxVisitorName
            // 
            this.textBoxVisitorName.Location = new System.Drawing.Point(168, 50);
            this.textBoxVisitorName.Name = "textBoxVisitorName";
            this.textBoxVisitorName.Size = new System.Drawing.Size(186, 22);
            this.textBoxVisitorName.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Na ime:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tip karte:";
            // 
            // comboBoxTicketType
            // 
            this.comboBoxTicketType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTicketType.FormattingEnabled = true;
            this.comboBoxTicketType.Location = new System.Drawing.Point(168, 97);
            this.comboBoxTicketType.Name = "comboBoxTicketType";
            this.comboBoxTicketType.Size = new System.Drawing.Size(186, 24);
            this.comboBoxTicketType.TabIndex = 19;
            this.comboBoxTicketType.SelectedIndexChanged += new System.EventHandler(this.numTicketQuantity_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Količina:";
            // 
            // lblTicketPrice
            // 
            this.lblTicketPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketPrice.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblTicketPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTicketPrice.Location = new System.Drawing.Point(229, 225);
            this.lblTicketPrice.Name = "lblTicketPrice";
            this.lblTicketPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTicketPrice.Size = new System.Drawing.Size(124, 15);
            this.lblTicketPrice.TabIndex = 25;
            this.lblTicketPrice.Text = "0KM";
            this.lblTicketPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(61, 223);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(51, 17);
            this.lblAmount.TabIndex = 24;
            this.lblAmount.Text = "Iznos:";
            // 
            // label17
            // 
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(63, 200);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(291, 3);
            this.label17.TabIndex = 26;
            // 
            // numTicketQuantity
            // 
            this.numTicketQuantity.Location = new System.Drawing.Point(168, 145);
            this.numTicketQuantity.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numTicketQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTicketQuantity.Name = "numTicketQuantity";
            this.numTicketQuantity.Size = new System.Drawing.Size(185, 22);
            this.numTicketQuantity.TabIndex = 27;
            this.numTicketQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numTicketQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTicketQuantity.ValueChanged += new System.EventHandler(this.numTicketQuantity_ValueChanged);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 3);
            this.label3.TabIndex = 28;
            // 
            // DailyTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 367);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numTicketQuantity);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lblTicketPrice);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxTicketType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxVisitorName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Name = "DailyTicketForm";
            this.Text = "Izdavanje dnevne karte";
            ((System.ComponentModel.ISupportInitialize)(this.numTicketQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox textBoxVisitorName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTicketType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTicketPrice;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown numTicketQuantity;
        private System.Windows.Forms.Label label3;
    }
}