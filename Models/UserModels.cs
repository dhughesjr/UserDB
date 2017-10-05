using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UserDB.Models
{
    public class UserModels
    {
        //[DisplayName("FirstName")]

        //[Required (ErrorMessage="First name is required")]

        public string FirstName { get; set; }
        //[Required]
        //[StringLength (50)]
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

        //[DataType(DataType.Date)]
        public DateTime DOB { get; set; }
        //[Range (100,1000000)]
        public decimal Salary { get; set; }
    }

    public class Users
    {
        public Users()
        {
            _userList.Add(new UserModels
            {
                FirstName = "Jack",
                LastName = "Johnson",
                Address = "99 Nevereverland",
                Email = "test@test.com",
                DOB = Convert.ToDateTime("06/12/1969"),
                Salary = 75000
            });
            _userList.Add(new UserModels
            {
                FirstName = "Bo",
                LastName = "Jangles",
                Address = "123 Crispy Ave",
                Email = "test1@test.com",
                DOB = Convert.ToDateTime("10/02/1972"),
                Salary = 5000
            });
            _userList.Add(new UserModels
            {
                FirstName = "Strawberry",
                LastName = "Shortcake",
                Address = "1 Rainbow Rd",
                Email = "test2@test.com",
                DOB = Convert.ToDateTime("01/02/1979"),
                Salary = 1000
            });
        }

        public List<UserModels> _userList = new List<UserModels>();

        public void CreateUser(UserModels userModel)
        {
            _userList.Add(userModel);
        }

        public void AddUser(UserModels userModel)
        {
            foreach (UserModels urslst in _userList)
            {
                if (urslst.Email == userModel.Email)
                {
                    _userList.Remove(urslst);
                    _userList.Add(userModel);
                    break;
                }
            }
        }

        public UserModels GetUser(string Email)
        {
            UserModels usrMdl = null;

            foreach (UserModels um in _userList)
                if (um.Email == Email)
                    usrMdl = um;

            return usrMdl;
        }
    }
}