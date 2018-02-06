using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExtremeIS.DAO;
using ExtremeIS.Model;
using ExtremeIS.DTO;
namespace ExtremeIS.Forms
{
    public partial class ReportForm : Form
    {
        private DateTime dateFrom;
        private DateTime dateTo;
        private String category;
        private String type;

        private enum months
        {
            Januar = 1, Februar, Mart, April, Maj,
            Jun, Jul, Avgust, Septembar, Oktobar, Novembar, Decembar
        };
        public ReportForm(String firstName,String lastName,String memberId,
            String barcodePath)
        {
            InitializeComponent();
            MembershipCardTemplateLoad(firstName,lastName,memberId,barcodePath);
        }
        public ReportForm(String category, String type, DateTime dateFrom, DateTime dateTo)
        {
            InitializeComponent();
            this.dateFrom = dateFrom;
            this.dateTo = dateTo;
            this.category = category;
            this.type = type;
            switch (category)
            {

                case "Članovi":
                    if ("Prisustva - pojedinačno".Equals(type))
                    {
                        ReportMembersAttendanceLoad();
                    }
                    else if ("Prisustva - zbirno".Equals(type))
                    {
                        ReportMembersAttendanceSummaryLoad();
                    }
                    break;
                case "Finansije":
                    if("Dnevne karte".Equals(type))
                    {
                        ReportDailyTicketsLoad();
                    }
                    else if ("Članarine".Equals(type))
                    {
                        ReportMemberFeesLoad();
                    }
                    break;
                case "Oprema":
                    ReportGearTotalLoad();
                    break;
                    
            }

        }
        private void MembershipCardTemplateLoad(String firstName,String lastName,String memberId
            ,String barcodePath)
        {
            crystalReportViewer.ReportSource = membershipCardTemplate1;
            membershipCardTemplate1.SetParameterValue("pFirstName", firstName);
            membershipCardTemplate1.SetParameterValue("pLastName", lastName);
            membershipCardTemplate1.SetParameterValue("pMemberId", memberId);
            membershipCardTemplate1.SetParameterValue("pBarcodePath", barcodePath);

            crystalReportViewer.Refresh();
        }
        private void ReportGearTotalLoad()
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable("Gear");

            dt.Columns.Add("gear_id");
            dt.Columns.Add("name");
            dt.Columns.Add("manufacturer_name");
            dt.Columns.Add("category");
            dt.Columns.Add("description");
            dt.Columns.Add("size");
            dt.Columns.Add("total");

            ds.Tables.Add(dt);

            List<gear_detailed> gears =
            GearDAO.getAllDetailed();
            foreach (var gear in gears)
            {
                DataRow dr = ds.Tables[0].NewRow();
                dr["gear_id"] = gear.gear_id;
                dr["name"] = gear.name;
                dr["manufacturer_name"] = gear.manufacturer_name;
                dr["category"] = gear.gear_category_name;
                dr["description"] = gear.description;
                dr["size"] = gear.size_value;
                dr["total"] = gear.quantity;


                ds.Tables[0].Rows.Add(dr);
            }

            rptGearTotal1.SetDataSource(ds);
            rptGearTotal1.SetParameterValue("pDateFrom", dateFrom.ToString("dd.MM.yyyy."));
            rptGearTotal1.SetParameterValue("pDateTo", dateTo.ToString("dd.MM.yyyy."));
            rptGearTotal1.SetParameterValue("pDatum", DateTime.Now.ToString("dd.MM.yyyy."));
            crystalReportViewer.ReportSource = rptGearTotal1;
            crystalReportViewer.Refresh();
        }
        private void ReportMemberFeesLoad()
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable("MembershipFee");

            dt.Columns.Add("member_id");
            dt.Columns.Add("first_name");
            dt.Columns.Add("last_name");
            dt.Columns.Add("month");
            dt.Columns.Add("paying_date");
            dt.Columns.Add("issuer_username");
            dt.Columns.Add("price");
            dt.Columns.Add("category");

            ds.Tables.Add(dt);
         
                List<MemberFeeDTO> membershipFees =
                MembershipFeePaymentDAO.getMembershipFeePaymentsInDateRange(dateFrom, dateTo);
                foreach (var memberFee in membershipFees)
                {
                    DataRow dr = ds.Tables[0].NewRow();
                    dr["member_id"] = memberFee.member_id;
                    dr["first_name"] = memberFee.first_name;
                    dr["last_name"] = memberFee.last_name;
                    dr["month"] = ((months)memberFee.month).ToString();
                    dr["paying_date"] = memberFee.payingDate.ToString("dd.MM.yyyy.");
                    dr["issuer_username"] = memberFee.issuer_user_name;
                    dr["price"] = memberFee.price;
                    dr["category"] = memberFee.category;


                    ds.Tables[0].Rows.Add(dr);
                }
            
            rptMembershipFees1.SetDataSource(ds);
            rptMembershipFees1.SetParameterValue("pDateFrom", dateFrom.ToString("dd.MM.yyyy."));
            rptMembershipFees1.SetParameterValue("pDateTo", dateTo.ToString("dd.MM.yyyy."));
            rptMembershipFees1.SetParameterValue("pDatum", DateTime.Now.ToString("dd.MM.yyyy."));
            crystalReportViewer.ReportSource = rptMembershipFees1;
            crystalReportViewer.Refresh();
        }

        private void ReportMembersAttendanceSummaryLoad()
        {

            DataSet ds = new DataSet();
            DataTable dt = new DataTable("MembersAttendanceSummary");

            dt.Columns.Add("member_id");
            dt.Columns.Add("first_name");
            dt.Columns.Add("last_name");
            dt.Columns.Add("number_of_attendances");

            ds.Tables.Add(dt);
            List<MemberAttendanceSummaryDTO> membersAttendanceSummary =
                AttendanceDAO.getMembersAttendanceSummaryInDateRange(dateFrom, dateTo);
            foreach (var memberAttendance in membersAttendanceSummary)
            {
                DataRow dr = ds.Tables[0].NewRow();
                dr["member_id"] = memberAttendance.member_id;
                dr["first_name"] = memberAttendance.first_name;
                dr["last_name"] = memberAttendance.last_name;
                dr["number_of_attendances"] = memberAttendance.number_of_attendances;
                ds.Tables[0].Rows.Add(dr);
            }

            rptMembersAttendanceSummary1.SetDataSource(ds);
            rptMembersAttendanceSummary1.SetParameterValue("pDateFrom", dateFrom.ToString("dd.MM.yyyy."));
            rptMembersAttendanceSummary1.SetParameterValue("pDateTo", dateTo.ToString("dd.MM.yyyy."));
            rptMembersAttendanceSummary1.SetParameterValue("pDatum", DateTime.Now.ToString("dd.MM.yyyy."));
            crystalReportViewer.ReportSource = rptMembersAttendanceSummary1;
            crystalReportViewer.Refresh();
        }

        private void ReportMembersAttendanceLoad()
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable("MembersAttendances");

            dt.Columns.Add("member_id");
            dt.Columns.Add("first_name");
            dt.Columns.Add("last_name");
            dt.Columns.Add("check_in_time");

            ds.Tables.Add(dt);
            List<MemberAttendanceDTO> membersAttendance = AttendanceDAO.getMembersAttendanceInDateRange(dateFrom, dateTo);
            foreach (var memberAttendance in membersAttendance)
            {
                DataRow dr = ds.Tables[0].NewRow();
                dr["member_id"] = memberAttendance.member_id;
                dr["first_name"] = memberAttendance.first_name;
                dr["last_name"] = memberAttendance.last_name;
                dr["check_in_time"] = memberAttendance.check_in_time.ToString("dd.MM.yyyy. hh:mm:ss");
                ds.Tables[0].Rows.Add(dr);
            }
            rptMembersAttendance1.SetDataSource(ds);
            rptMembersAttendance1.SetParameterValue("pDateFrom", dateFrom.ToString("dd.MM.yyyy."));
            rptMembersAttendance1.SetParameterValue("pDateTo", dateTo.ToString("dd.MM.yyyy."));
            rptMembersAttendance1.SetParameterValue("pDatum", DateTime.Now.ToString("dd.MM.yyyy."));
            crystalReportViewer.ReportSource = rptMembersAttendance1;
            crystalReportViewer.Refresh();
        }
        private void ReportDailyTicketsLoad()
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable("DailyTickets");

            dt.Columns.Add("person_name");
            dt.Columns.Add("issuer_user_name");
            dt.Columns.Add("price");
            dt.Columns.Add("create_date");

            ds.Tables.Add(dt);
            List<DailyTicketDTO> dailyTickets = DailyTicketsDAO.getDailyTicketsInDateRange(dateFrom, dateTo);
            foreach (var dailyTicket in dailyTickets)
            {
                DataRow dr = ds.Tables[0].NewRow();
                dr["person_name"] = dailyTicket.person_name;
                dr["issuer_user_name"] = dailyTicket.issuer_user_name;
                dr["price"] = dailyTicket.price;
                dr["create_date"] = dailyTicket.create_date.ToString("dd.MM.yyyy. hh:mm:ss");
                ds.Tables[0].Rows.Add(dr);
            }
            rptDailyTickets1.SetDataSource(ds);
            rptDailyTickets1.SetParameterValue("pDateFrom", dateFrom.ToString("dd.MM.yyyy."));
            rptDailyTickets1.SetParameterValue("pDateTo", dateTo.ToString("dd.MM.yyyy."));
            rptDailyTickets1.SetParameterValue("pDatum", DateTime.Now.ToString("dd.MM.yyyy."));
            crystalReportViewer.ReportSource = rptDailyTickets1;
            crystalReportViewer.Refresh();
        }
        private void ReportForm_Load(object sender, EventArgs e)
        {

        }
    }
}
