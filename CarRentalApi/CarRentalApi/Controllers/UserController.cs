using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarRentalApi.Controllers
{
    public class UserController : Controller
    {
        Data.User user = new Data.User();
        public bool addUser(string fullName, string id, string userName, string gender, string email, string password, DateTime dateOfBirth = default(DateTime), byte[] image = null){
            if(dateOfBirth == default(DateTime))
            {
                return false;
            }
            return true;
        }
    }
}
