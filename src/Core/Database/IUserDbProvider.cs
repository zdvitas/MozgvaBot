using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MozgvaBot.Core.BL;

namespace MozgvaBot.Core.Database
{
    public interface IUserDbProvider
    {
        User GetUserByName(string userName);
        User GetUserById(int Id);
        void UpdateUser(User user);
        void AddUser(User user);
    }
}
