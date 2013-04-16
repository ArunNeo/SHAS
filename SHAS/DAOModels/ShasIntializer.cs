using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace SHAS.DAOModels
{
    public class ShasIntializer : DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {
            GetUserLoginDao().ForEach(c => context.UserLoginDAO.Add(c));
           
        }
        private static List<UserLoginDAO> GetUserLoginDao()
        {
            var userLogin = new List<UserLoginDAO>{
                new UserLoginDAO{

                    userName ="Admin",
                    Password ="Password123"
                }
                };

            return userLogin;
        
        
        }


    }
}