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
            int result = 0;

            using (var db = new ExtremeAppContext())
            {


                db.members.Add(member);
                result = db.SaveChanges();
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

                existingMember.first_name = member.first_name;
                existingMember.last_name = member.last_name;
                existingMember.sex = member.sex;
                existingMember.birth_date = member.birth_date;
                existingMember.address = member.address;
                existingMember.phone_number = member.phone_number;
                existingMember.email = member.email;
                existingMember.registration_date = member.registration_date;
                existingMember.last_modified = DateTime.Now;
                existingMember.profile_picture = member.profile_picture;
                existingMember.active = member.active;
                existingMember.membership_type_id = member.membership_type_id;
                result = db.SaveChanges();
            }
            return result;
        }
        public static member getById(int id)
        {
            using (var db = new ExtremeAppContext())
            {
                var member =
                    (from m in db.members
                     where m.member_id == id
                     select m).First();

                return member;

            }
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
        public static int getLast()
        {

            using (var db = new ExtremeAppContext())
            {
                var lastMemberId =
                    (from m in db.members
                     select m.member_id).Max();

                return lastMemberId;

            }
        }

        //Vraca string listu oblika ID - Ime_Prezime
        public static List<String> getAllBasicInfo()
        {

            using (var db = new ExtremeAppContext())
            {
                var allMembers =
                    (from m in db.members select m).ToList();

                List<String> allMemberBasicInfo = new List<String>();

                foreach (member m in allMembers)
                {
                    allMemberBasicInfo.Add($"{m.first_name} {m.last_name} -{m.member_id}");
                    if (!m.first_name.StartsWith(m.last_name.Substring(0, 2)))
                        allMemberBasicInfo.Add($"{m.last_name} {m.first_name} -{m.member_id}");
                }
                return allMemberBasicInfo;

            }
        }
        public static String getBarcodeNumber(int memberId)
        {
            using (var db = new ExtremeAppContext())
            {
                var barcodeNumber =
                    (from m in db.membership_card
                     where m.member_id==memberId
                     select m.barcode_number).First();

                return barcodeNumber;

            }
        }
    }
}


