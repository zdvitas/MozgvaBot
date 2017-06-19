using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MozgvaBot.Core.BL;
using Timer = System.Timers.Timer;
using System.Data.SQLite;
using System.Data.SQLite.Linq;

namespace MozgvaBot.Core.Database
{
    public class UserDbProvider : IDisposable , IUserDbProvider
    {
        public UserDbProvider()
        {
            usersLock = new object();
            _timer = new Timer();
            _timer.Elapsed += RefreshDbOnTimer;
            _timer.AutoReset = true;
            _timer.Interval = TimerInterval;
            _timer.Start();
            _users = GetAllUsers();
        }

        private List<User> GetAllUsers()
        {
            // TODO
            return new List<User>();
        }

        private void RefreshDbOnTimer(Object source, System.Timers.ElapsedEventArgs e)
        {

        }
        private List<User> _users;
        private object usersLock;
        private Timer _timer;

        private static readonly double TimerInterval = TimeSpan.FromMinutes(5).TotalMilliseconds;

        public void Dispose()
        {
            _timer.Stop();
            RefreshDb();
        }

        private void RefreshDb()
        {
            User[] usersTmp;
            lock (usersLock)
            {
                usersTmp = new User[_users.Count];
                _users.CopyTo(usersTmp);
            }
            WriteUsersArrayToDb(usersTmp);
        }

        private void WriteUsersArrayToDb(User[] usersTmp)
        {
            throw new NotImplementedException();
        }

        public User GetUserByName(string userName)
        {
            lock (usersLock)
            {
                return new User();
            }
        }

        public User GetUserById(int Id)
        {
            lock (usersLock)
            {
                return new User();
            }
        }

        public void UpdateUser(User user)
        {
            lock (usersLock)
            {
                
            }
        }

        public void AddUser(User user)
        {
            lock (usersLock)
            {

            }
        }
    }
}
