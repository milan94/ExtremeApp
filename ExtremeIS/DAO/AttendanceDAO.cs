using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtremeIS.Model;
using ExtremeIS.Model.Entities;
using ExtremeIS.DTO;
namespace ExtremeIS.DAO
{
    class AttendanceDAO
    {
        //public static DateTime? getLastById(int id)
        //{
        //    using (var db = new ExtremeAppContext())
        //    {
        //        var attendances =
        //            (from a in db.attendances
        //             where a.member_id == id
        //             select a.check_in_time).ToList();

        //        DateTime? attendance;
        //        if (attendances.Count() == 0)
        //        {
        //            attendance = null;
        //        }
        //        else
        //        {
        //            attendance = attendances.Max();
        //        }
        //        return attendance;
        //    }
        //}

        public static String getLastById(int id)
        {
            var lastAtt = "Nema evidentiranih prijava";

            using (var db = new ExtremeAppContext())
            {
                var attendances =
                    (from a in db.attendances
                     where a.member_id == id
                     select a.check_in_time).ToList();

                if (attendances.Count() > 0)
                {
                    var attendance = attendances.Max();
                    lastAtt = attendance.ToString("dd.MM.yyyy  H:mm");
                }
                return lastAtt;
            }
        }

        public static List<DateTime> getAllById(int id)
        {
            using (var db = new ExtremeAppContext())
            {
                var attendances =
                    (from a in db.attendances
                     where a.member_id == id
                     select a.check_in_time).ToList();

                return attendances;

            }
        }


        public static List<MemberAttendanceDTO> getMembersAttendanceInDateRange(DateTime dateFrom,
            DateTime dateTo)
        {
            dateTo = dateTo.AddDays(1);
            Console.WriteLine(dateTo);
            using (var db = new ExtremeAppContext())
            {
                var membersAttendances =
                    (from a in db.attendances
                     join m in db.members
                     on a.member_id equals m.member_id
                     where a.check_in_time >= dateFrom.Date
                     where a.check_in_time <= dateTo.Date
                     select new MemberAttendanceDTO
                     {
                         member_id = m.member_id,
                         first_name = m.first_name,
                         last_name = m.last_name,
                         check_in_time = a.check_in_time
                     }).ToList();

                return membersAttendances;

            }
        }

        public static List<MemberAttendanceSummaryDTO> getMembersAttendanceSummaryInDateRange(DateTime dateFrom,
            DateTime dateTo)
        {
            dateTo = dateTo.AddDays(1);
            Console.WriteLine(dateTo);
            using (var db = new ExtremeAppContext())
            {
                var membersAttendancesSummary =
                    (from a in db.attendances
                     join m in db.members
                     on a.member_id equals m.member_id
                     where a.check_in_time >= dateFrom.Date
                     where a.check_in_time <= dateTo.Date
                     group a by new
                     {
                         member_id = a.member_id,
                         first_name = m.first_name,
                         last_name = m.last_name
                     }
                     into g
                     select new MemberAttendanceSummaryDTO
                     {
                         member_id = g.Key.member_id,
                         first_name = g.Key.first_name,
                         last_name = g.Key.last_name,
                         number_of_attendances = g.Count()
                     }).ToList();

                return membersAttendancesSummary;

            }
        }
        public static List<attendance_list_member> getAllToday()
        {
            DateTime startDateTime = DateTime.Today;                       //Today at 00:00:00
            DateTime endDateTime = DateTime.Today.AddDays(1).AddTicks(-1); //Today at 23:59:59

            var attendancesToday = getAllForDateRange(startDateTime, endDateTime);
            return attendancesToday;
        }

        public static List<attendance_list_member> getAllForDateRange(DateTime startDateTime, DateTime endDateTime)
        {
            using (var db = new ExtremeAppContext())
            {
                var attendances =
                    (from a in db.attendances
                     join m in db.members on a.member_id equals m.member_id
                     where (a.check_in_time >= startDateTime && a.check_in_time <= endDateTime)
                     select new attendance_list_member()
                     {
                         fullName = m.first_name + " " + m.last_name,
                         checkInTime = a.check_in_time
                         //dopuniti sta bude potrebno
                     }).ToList();

                return attendances;
            }
        }

        public static Boolean insert(attendance newAttendance)
        {
            int retVal = 0;

            using (var db = new ExtremeAppContext())
            {
                db.attendances.Add(newAttendance);
                retVal = db.SaveChanges();
            }
            return retVal > 0 ? true : false;

        }
        public static Boolean isAlreadyCheckedIn(int memberId, int day, int month, int year)
        {
            using (var db = new ExtremeAppContext())
            {
                var exists =
                    (from a in db.attendances
                     where a.member_id == memberId
                     where a.check_in_time.Day == day
                     where a.check_in_time.Month == month
                     where a.check_in_time.Year == year
                     select a).Any();

                return exists;

            }
        }
    }
}
