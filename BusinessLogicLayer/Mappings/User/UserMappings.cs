using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public static class UserMappings
    {
        public static User FromDataRowToUser(DataRow row)
        {
            User user = new User();
            int.TryParse(row["Id"]?.ToString() ?? "-1", out int id);
            user.Id = id;

            string name = row["Name"]?.ToString()!;
            user.Name= name;

            string email = row["Email"]?.ToString()!;
            user.Email = email;

            string role = row["Role"]?.ToString()!;
            user.Role = role;

            string password = row["Password"]?.ToString()!;
            user.Password = password;

            return user;
        }

    }
}
