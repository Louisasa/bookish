using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookish.Data.SQLQueries
{
    class UserQueries
    {
        private readonly string connectionString;

        public UserQueries(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Book> GetBooksByUserID(string name)
        {
            throw new System.NotImplementedException();
        }
        public List<Users> GetUserIDByLogin(string name)
        {
            throw new System.NotImplementedException();
        }
        public List<Users> GetUsernameByBook(string name)
        {
            throw new System.NotImplementedException();
        }
        public int AddNewUser(Users name)
        {
            throw new System.NotImplementedException();
        }
    }
}
