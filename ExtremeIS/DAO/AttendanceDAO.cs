using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtremeIS.Model.Entities;

namespace ExtremeIS.DAO
{
    class AttendanceDAO
    {
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
    }
}
