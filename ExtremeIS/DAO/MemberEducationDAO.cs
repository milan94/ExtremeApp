using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtremeIS.Model.Entities;

namespace ExtremeIS.DAO
{
    class MemberEducationDAO
    {
        public static List<member_education> getById(int id)
        {
            using (var db = new ExtremeAppContext())
            {
                var membershipEducation =
                    (from e in db.member_education where e.member_id==id
                     select e).ToList();

                return membershipEducation;

            }
        }
        public static int insert(member_education memberEducation)
        {
            int result = 0;

            using (var db = new ExtremeAppContext())
            {


                db.member_education.Add(memberEducation);
                result = db.SaveChanges();
            }
            return result;
        }
    }
}
