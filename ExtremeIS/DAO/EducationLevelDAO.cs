using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtremeIS.Model.Entities;

namespace ExtremeIS.DAO
{
    class EducationLevelDAO
    {
        public static List<String> getAll()
        {

            using (var db = new ExtremeAppContext())
            {
                var allEducationLevels =
                    (from e in db.education_level
                     select e.name).ToList();

                return allEducationLevels;

            }
        }

        public static String getById(int id)
        {
            using (var db = new ExtremeAppContext())
            {
                var name =
                    (from e in db.education_level
                     where e.education_level_id == id
                     select e.name).First();

                return name;

            }
        }
    }
}
