using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtremeIS.Model.Entities;
namespace ExtremeIS.DAO
{
    class MemberDAO
    {
        public static int insert(member member)
        {
            int result=0;

            using (var db = new ExtremeAppContext())
            {
                

                db.members.Add(member);
                result=db.SaveChanges();
            }
            return result;
        }

        public static int update(member member)
        {
            int result = 0;

            using (var db = new ExtremeAppContext())
            {
                var existingMember = (from m in db.members
                                      where m.member_id == member.member_id
                                      select m).First();

                existingMember = member;
                result = db.SaveChanges();
            }
            return result;
        }
        public static List<member> getAll()
        {

            using (var db = new ExtremeAppContext())
            {
                var allMembers =
                    (from m in db.members
                     select m).ToList();

                return allMembers;

            }
        }
    }
}


