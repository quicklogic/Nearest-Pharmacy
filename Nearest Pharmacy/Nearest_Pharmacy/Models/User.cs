using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nearest_Pharmacy.Models
{
    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Patronymic { get; set; }
        public DateTime DateTime { get; set; }
        public string Email { get; set; }
        public string Number { get; set; }
        public string Address { get; set; }

        public User(User user)
        {
            Login = user.Login;
            Password = user.Password;
            FirstName = user.FirstName;
            SecondName = user.SecondName;
            Patronymic = user.Patronymic;
            DateTime = user.DateTime;
            Email = user.Email;
            Number = user.Number;
            Address = user.Address;
        }
    }
}
