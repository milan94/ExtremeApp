using System;
namespace ExtremeIS.Forms
{
    partial class AddMemberForm
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
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.dateTimePickerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.radioButtonSexMale = new System.Windows.Forms.RadioButton();
            this.radioButtonSexFemale = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageBasicInfo = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddProfilePicture = new System.Windows.Forms.Button();
            this.pictureBoxProfilePicture = new System.Windows.Forms.PictureBox();
            this.tabPageMembership = new System.Windows.Forms.TabPage();
            this.pictureBoxBarcodeMembershipCard = new System.Windows.Forms.PictureBox();
            this.lblLastNameMembershipCard = new System.Windows.Forms.Label();
            this.lblFirstNameMembershipCard = new System.Windows.Forms.Label();
            this.checkBoxActiveMember = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGenerateMembershipCard = new System.Windows.Forms.Button();
            this.comboBoxMembershipType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerRegistrationDate = new System.Windows.Forms.DateTimePicker();
            this.lblRegistrationDate = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblMemberIdMembershipCard = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageBasicInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).BeginInit();
            this.tabPageMembership.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarcodeMembershipCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(17, 102);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 17;
            this.lblEmail.Text = "Email";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(17, 67);
            this.lblPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(69, 13);
            this.lblPhoneNumber.TabIndex = 14;
            this.lblPhoneNumber.Text = "Broj telefona:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(17, 36);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(43, 13);
            this.lblAddress.TabIndex = 13;
            this.lblAddress.Text = "Adresa:";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthDate.Location = new System.Drawing.Point(21, 177);
            this.lblBirthDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(80, 13);
            this.lblBirthDate.TabIndex = 12;
            this.lblBirthDate.Text = "Datum rođenja:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(21, 136);
            this.lblGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(25, 13);
            this.lblGender.TabIndex = 11;
            this.lblGender.Text = "Pol:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(21, 93);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(47, 13);
            this.lblLastName.TabIndex = 10;
            this.lblLastName.Text = "Prezime:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(21, 50);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(27, 13);
            this.lblFirstName.TabIndex = 9;
            this.lblFirstName.Text = "Ime:";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(82, 51);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(144, 20);
            this.textBoxFirstName.TabIndex = 18;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(82, 91);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(144, 20);
            this.textBoxLastName.TabIndex = 19;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(95, 33);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(197, 20);
            this.textBoxAddress.TabIndex = 21;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(95, 64);
            this.textBoxPhoneNumber.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(197, 20);
            this.textBoxPhoneNumber.TabIndex = 20;
            // 
            // dateTimePickerBirthDate
            // 
            this.dateTimePickerBirthDate.Location = new System.Drawing.Point(23, 196);
            this.dateTimePickerBirthDate.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            this.dateTimePickerBirthDate.Size = new System.Drawing.Size(202, 20);
            this.dateTimePickerBirthDate.TabIndex = 23;
            this.dateTimePickerBirthDate.Value = this.dateTimePickerBirthDate.Value;
            // 
            // radioButtonSexMale
            // 
            this.radioButtonSexMale.AutoSize = true;
            this.radioButtonSexMale.Checked = true;
            this.radioButtonSexMale.Location = new System.Drawing.Point(82, 136);
            this.radioButtonSexMale.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonSexMale.Name = "radioButtonSexMale";
            this.radioButtonSexMale.Size = new System.Drawing.Size(34, 17);
            this.radioButtonSexMale.TabIndex = 25;
            this.radioButtonSexMale.TabStop = true;
            this.radioButtonSexMale.Text = "M";
            this.radioButtonSexMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonSexFemale
            // 
            this.radioButtonSexFemale.AutoSize = true;
            this.radioButtonSexFemale.Location = new System.Drawing.Point(120, 136);
            this.radioButtonSexFemale.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonSexFemale.Name = "radioButtonSexFemale";
            this.radioButtonSexFemale.Size = new System.Drawing.Size(32, 17);
            this.radioButtonSexFemale.TabIndex = 26;
            this.radioButtonSexFemale.TabStop = true;
            this.radioButtonSexFemale.Text = "Ž";
            this.radioButtonSexFemale.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageBasicInfo);
            this.tabControl1.Controls.Add(this.tabPageMembership);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(374, 431);
            this.tabControl1.TabIndex = 27;
            // 
            // tabPageBasicInfo
            // 
            this.tabPageBasicInfo.BackColor = System.Drawing.Color.White;
            this.tabPageBasicInfo.Controls.Add(this.groupBox1);
            this.tabPageBasicInfo.Controls.Add(this.lblMemberID);
            this.tabPageBasicInfo.Controls.Add(this.label1);
            this.tabPageBasicInfo.Controls.Add(this.btnAddProfilePicture);
            this.tabPageBasicInfo.Controls.Add(this.pictureBoxProfilePicture);
            this.tabPageBasicInfo.Controls.Add(this.radioButtonSexFemale);
            this.tabPageBasicInfo.Controls.Add(this.lblFirstName);
            this.tabPageBasicInfo.Controls.Add(this.radioButtonSexMale);
            this.tabPageBasicInfo.Controls.Add(this.lblLastName);
            this.tabPageBasicInfo.Controls.Add(this.lblGender);
            this.tabPageBasicInfo.Controls.Add(this.dateTimePickerBirthDate);
            this.tabPageBasicInfo.Controls.Add(this.lblBirthDate);
            this.tabPageBasicInfo.Controls.Add(this.textBoxLastName);
            this.tabPageBasicInfo.Controls.Add(this.textBoxFirstName);
            this.tabPageBasicInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPageBasicInfo.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageBasicInfo.Name = "tabPageBasicInfo";
            this.tabPageBasicInfo.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageBasicInfo.Size = new System.Drawing.Size(366, 405);
            this.tabPageBasicInfo.TabIndex = 0;
            this.tabPageBasicInfo.Text = "Osnovne informacije";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxAddress);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.textBoxPhoneNumber);
            this.groupBox1.Controls.Add(this.textBoxEmail);
            this.groupBox1.Controls.Add(this.lblPhoneNumber);
            this.groupBox1.Controls.Add(this.lblAddress);
            this.groupBox1.Location = new System.Drawing.Point(25, 247);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(328, 132);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kontakt informacije";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(95, 98);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(197, 20);
            this.textBoxEmail.TabIndex = 27;
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblMemberID.Location = new System.Drawing.Point(86, 20);
            this.lblMemberID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(12, 13);
            this.lblMemberID.TabIndex = 29;
            this.lblMemberID.Text = "/";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "ID korisnika:";
            // 
            // btnAddProfilePicture
            // 
            this.btnAddProfilePicture.Location = new System.Drawing.Point(243, 195);
            this.btnAddProfilePicture.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddProfilePicture.Name = "btnAddProfilePicture";
            this.btnAddProfilePicture.Size = new System.Drawing.Size(110, 22);
            this.btnAddProfilePicture.TabIndex = 28;
            this.btnAddProfilePicture.Text = "Dodaj fotografiju";
            this.btnAddProfilePicture.UseVisualStyleBackColor = true;
            this.btnAddProfilePicture.Click += new System.EventHandler(this.btnAddProfilePicture_Click);
            // 
            // pictureBoxProfilePicture
            // 
            this.pictureBoxProfilePicture.Image = global::ExtremeIS.Properties.Resources.user;
            this.pictureBoxProfilePicture.Location = new System.Drawing.Point(243, 50);
            this.pictureBoxProfilePicture.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxProfilePicture.Name = "pictureBoxProfilePicture";
            this.pictureBoxProfilePicture.Size = new System.Drawing.Size(110, 141);
            this.pictureBoxProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfilePicture.TabIndex = 22;
            this.pictureBoxProfilePicture.TabStop = false;
            // 
            // tabPageMembership
            // 
            this.tabPageMembership.Controls.Add(this.label4);
            this.tabPageMembership.Controls.Add(this.lblMemberIdMembershipCard);
            this.tabPageMembership.Controls.Add(this.pictureBoxBarcodeMembershipCard);
            this.tabPageMembership.Controls.Add(this.lblLastNameMembershipCard);
            this.tabPageMembership.Controls.Add(this.lblFirstNameMembershipCard);
            this.tabPageMembership.Controls.Add(this.checkBoxActiveMember);
            this.tabPageMembership.Controls.Add(this.label3);
            this.tabPageMembership.Controls.Add(this.btnGenerateMembershipCard);
            this.tabPageMembership.Controls.Add(this.comboBoxMembershipType);
            this.tabPageMembership.Controls.Add(this.label2);
            this.tabPageMembership.Controls.Add(this.dateTimePickerRegistrationDate);
            this.tabPageMembership.Controls.Add(this.lblRegistrationDate);
            this.tabPageMembership.Controls.Add(this.pictureBox2);
            this.tabPageMembership.Location = new System.Drawing.Point(4, 22);
            this.tabPageMembership.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageMembership.Name = "tabPageMembership";
            this.tabPageMembership.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageMembership.Size = new System.Drawing.Size(366, 405);
            this.tabPageMembership.TabIndex = 1;
            this.tabPageMembership.Text = "Članstvo";
            this.tabPageMembership.UseVisualStyleBackColor = true;
            // 
            // pictureBoxBarcodeMembershipCard
            // 
            this.pictureBoxBarcodeMembershipCard.Image = global::ExtremeIS.Properties.Resources.defaultBarcode;
            this.pictureBoxBarcodeMembershipCard.Location = new System.Drawing.Point(206, 275);
            this.pictureBoxBarcodeMembershipCard.Name = "pictureBoxBarcodeMembershipCard";
            this.pictureBoxBarcodeMembershipCard.Size = new System.Drawing.Size(120, 45);
            this.pictureBoxBarcodeMembershipCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBarcodeMembershipCard.TabIndex = 28;
            this.pictureBoxBarcodeMembershipCard.TabStop = false;
            // 
            // lblLastNameMembershipCard
            // 
            this.lblLastNameMembershipCard.AutoSize = true;
            this.lblLastNameMembershipCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastNameMembershipCard.Location = new System.Drawing.Point(53, 294);
            this.lblLastNameMembershipCard.Name = "lblLastNameMembershipCard";
            this.lblLastNameMembershipCard.Size = new System.Drawing.Size(79, 24);
            this.lblLastNameMembershipCard.TabIndex = 27;
            this.lblLastNameMembershipCard.Text = "Prezime";
            // 
            // lblFirstNameMembershipCard
            // 
            this.lblFirstNameMembershipCard.AutoSize = true;
            this.lblFirstNameMembershipCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstNameMembershipCard.Location = new System.Drawing.Point(53, 268);
            this.lblFirstNameMembershipCard.Name = "lblFirstNameMembershipCard";
            this.lblFirstNameMembershipCard.Size = new System.Drawing.Size(41, 24);
            this.lblFirstNameMembershipCard.TabIndex = 27;
            this.lblFirstNameMembershipCard.Text = "Ime";
            // 
            // checkBoxActiveMember
            // 
            this.checkBoxActiveMember.AutoSize = true;
            this.checkBoxActiveMember.Checked = true;
            this.checkBoxActiveMember.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxActiveMember.Location = new System.Drawing.Point(159, 115);
            this.checkBoxActiveMember.Name = "checkBoxActiveMember";
            this.checkBoxActiveMember.Size = new System.Drawing.Size(62, 17);
            this.checkBoxActiveMember.TabIndex = 26;
            this.checkBoxActiveMember.Text = "Aktivan";
            this.checkBoxActiveMember.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 349);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(304, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Napomena: štamapnje karte je moguće po završetku registracije";
            // 
            // btnGenerateMembershipCard
            // 
            this.btnGenerateMembershipCard.Location = new System.Drawing.Point(26, 157);
            this.btnGenerateMembershipCard.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerateMembershipCard.Name = "btnGenerateMembershipCard";
            this.btnGenerateMembershipCard.Size = new System.Drawing.Size(133, 23);
            this.btnGenerateMembershipCard.TabIndex = 23;
            this.btnGenerateMembershipCard.Text = "Generiši člansku kartu";
            this.btnGenerateMembershipCard.UseVisualStyleBackColor = true;
            this.btnGenerateMembershipCard.Click += new System.EventHandler(this.btnGenerateMembershipCard_Click);
            // 
            // comboBoxMembershipType
            // 
            this.comboBoxMembershipType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMembershipType.FormattingEnabled = true;
            this.comboBoxMembershipType.Location = new System.Drawing.Point(159, 78);
            this.comboBoxMembershipType.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxMembershipType.Name = "comboBoxMembershipType";
            this.comboBoxMembershipType.Size = new System.Drawing.Size(181, 21);
            this.comboBoxMembershipType.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Kategorija";
            // 
            // dateTimePickerRegistrationDate
            // 
            this.dateTimePickerRegistrationDate.CustomFormat = "";
            this.dateTimePickerRegistrationDate.Location = new System.Drawing.Point(159, 35);
            this.dateTimePickerRegistrationDate.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerRegistrationDate.MinDate = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerRegistrationDate.Name = "dateTimePickerRegistrationDate";
            this.dateTimePickerRegistrationDate.Size = new System.Drawing.Size(181, 20);
            this.dateTimePickerRegistrationDate.TabIndex = 19;
            // 
            // lblRegistrationDate
            // 
            this.lblRegistrationDate.AutoSize = true;
            this.lblRegistrationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrationDate.Location = new System.Drawing.Point(24, 35);
            this.lblRegistrationDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegistrationDate.Name = "lblRegistrationDate";
            this.lblRegistrationDate.Size = new System.Drawing.Size(94, 13);
            this.lblRegistrationDate.TabIndex = 17;
            this.lblRegistrationDate.Text = "Datum registracije:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ExtremeIS.Properties.Resources.membershipCard;
            this.pictureBox2.Location = new System.Drawing.Point(29, 193);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(305, 154);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // btnAddMember
            // 
            this.btnAddMember.Location = new System.Drawing.Point(76, 449);
            this.btnAddMember.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(100, 28);
            this.btnAddMember.TabIndex = 28;
            this.btnAddMember.Text = "Dodaj";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(194, 449);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(107, 28);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblMemberIdMembershipCard
            // 
            this.lblMemberIdMembershipCard.AutoSize = true;
            this.lblMemberIdMembershipCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberIdMembershipCard.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMemberIdMembershipCard.Location = new System.Drawing.Point(291, 252);
            this.lblMemberIdMembershipCard.Name = "lblMemberIdMembershipCard";
            this.lblMemberIdMembershipCard.Size = new System.Drawing.Size(31, 13);
            this.lblMemberIdMembershipCard.TabIndex = 29;
            this.lblMemberIdMembershipCard.Text = "1000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(262, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Čl.Br.:";
            // 
            // AddMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 495);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddMember);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddMemberForm";
            this.Text = "Dodavnje novog člana";
            this.Load += new System.EventHandler(this.AddMemberForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageBasicInfo.ResumeLayout(false);
            this.tabPageBasicInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).EndInit();
            this.tabPageMembership.ResumeLayout(false);
            this.tabPageMembership.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarcodeMembershipCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.PictureBox pictureBoxProfilePicture;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthDate;
        private System.Windows.Forms.RadioButton radioButtonSexMale;
        private System.Windows.Forms.RadioButton radioButtonSexFemale;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageBasicInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddProfilePicture;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.TabPage tabPageMembership;
        private System.Windows.Forms.CheckBox checkBoxActiveMember;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGenerateMembershipCard;
        private System.Windows.Forms.ComboBox comboBoxMembershipType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerRegistrationDate;
        private System.Windows.Forms.Label lblRegistrationDate;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBoxBarcodeMembershipCard;
        private System.Windows.Forms.Label lblFirstNameMembershipCard;
        private System.Windows.Forms.Label lblLastNameMembershipCard;
        private System.Windows.Forms.Label lblMemberIdMembershipCard;
        private System.Windows.Forms.Label label4;
    }
}