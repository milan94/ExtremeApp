namespace ExtremeIS.Forms
{
    partial class ReportForm
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
            this.crystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptMembersAttendance1 = new ExtremeIS.Reports.rptMembersAttendance();
            this.rptMembersAttendanceSummary1 = new ExtremeIS.Reports.rptMembersAttendanceSummary();
            this.rptDailyTickets1 = new ExtremeIS.Reports.rptDailyTickets();
            this.rptMembershipFees1 = new ExtremeIS.Reports.rptMembershipFees();
            this.rptGearTotal1 = new ExtremeIS.Reports.rptGearTotal();
            this.membershipCardTemplate1 = new ExtremeIS.MembershipCard.MembershipCardTemplate();
            this.SuspendLayout();
            // 
            // crystalReportViewer
            // 
            this.crystalReportViewer.ActiveViewIndex = -1;
            this.crystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer.Name = "crystalReportViewer";
            this.crystalReportViewer.Size = new System.Drawing.Size(736, 437);
            this.crystalReportViewer.TabIndex = 0;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 437);
            this.Controls.Add(this.crystalReportViewer);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer;
        private Reports.rptMembersAttendance rptMembersAttendance1;
        private Reports.rptMembersAttendanceSummary rptMembersAttendanceSummary1;
        private Reports.rptDailyTickets rptDailyTickets1;
        private Reports.rptMembershipFees rptMembershipFees1;
        private Reports.rptGearTotal rptGearTotal1;
        private MembershipCard.MembershipCardTemplate membershipCardTemplate1;
    }
}