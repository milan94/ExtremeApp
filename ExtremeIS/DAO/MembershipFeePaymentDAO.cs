using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtremeIS.Model.Entities;
using ExtremeIS.DTO;

namespace ExtremeIS.DAO
{
    class MembershipFeePaymentDAO
    {
        public static Boolean isPaidFor(int memberId, int month, int year)
        {
            using (var db = new ExtremeAppContext())
            {
                var feePayment =
                    (from p in db.membeship_fee_payment
                     where p.member_id == memberId
                     where p.month == month
                     where p.year == year
                     select p).First();

                return feePayment.is_paid;

            }
        }

        public static int getLastPaidMonth(int memberId)
        {


            using (var db = new ExtremeAppContext())
            {
                var attendances =
                    (from a in db.membeship_fee_payment
                     where a.member_id == memberId
                     orderby a.payment_date descending
                     select a).ToList();

                int attendance;
                if (attendances.Count() == 0)
                {
                    attendance = 0;
                }
                else
                {
                    attendance = attendances.First().month;
                }
                return attendance;
            }
        }

        public static int getNumberOfPaidMembershipFees(int memberId)
        {


            using (var db = new ExtremeAppContext())
            {
                var attendances =
                    (from a in db.membeship_fee_payment
                     where a.member_id == memberId
                     orderby a.payment_date descending
                     select a).ToList();


                return attendances.Count();
            }
        }

        public static int insert(membeship_fee_payment membershipFeePayment)
        {
            int result = 0;

            using (var db = new ExtremeAppContext())
            {


                db.membeship_fee_payment.Add(membershipFeePayment);
                result = db.SaveChanges();
            }
            return result;
        }

        public static List<MemberFeeDTO> getMembershipFeePaymentsInDateRange(DateTime dateFrom,
            DateTime dateTo)
        {
            dateTo = dateTo.AddDays(1);
            Console.WriteLine(dateTo);
            using (var db = new ExtremeAppContext())
            {
                var membersAttendances =
                    (from m in db.membeship_fee_payment
                     where m.payment_date >= dateFrom.Date
                     where m.payment_date <= dateTo.Date
                     select new MemberFeeDTO
                     {
                         member_id = m.member_id,
                         first_name = m.member.first_name,
                         last_name = m.member.last_name,
                         month = m.month,
                         payingDate = m.payment_date,
                         issuer_user_name = m.user_account.username,
                         price = m.price,
                         category = m.member.membership_type.name,
            }
                     ).ToList();

                return membersAttendances;

            }
        }
    }
}
