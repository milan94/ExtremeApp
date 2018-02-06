using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtremeIS.Model.Entities;

namespace ExtremeIS.DAO
{
    class UserAccountDAO
    {

        //insert 
        public static Boolean insert(user_account newUser)                          //lower to invariant kod pravljenja za username
        {
            int retVal = 0;

            //Check if user with same username already exists                       //DORADITI

            using (var db = new ExtremeAppContext())
            {
                db.user_account.Add(newUser);
                retVal = db.SaveChanges();
            }
            return retVal > 0 ? true : false;
        }

        //revoke permissions for user 


        //User identification 
        public static user_account identifyUser(String username)
        {
            using (var db = new ExtremeAppContext())
            {
                var userAccount =
                   (from ua in db.user_account
                    where ua.username == username
                    select ua).SingleOrDefault();

                return userAccount;
            }
        }

        //User authentication
        public static Boolean authenticateUser(user_account user, String password)
        {
            var retVal = false;

            var initialSalt = user.username.Substring(0,3);
            var passHash = Utils.Utilities.getPasswordHash(password, initialSalt);

            if (user.password.Equals(passHash))
            {
                retVal = true;
            }
            return retVal;
        }


    }
}
