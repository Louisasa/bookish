using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookish.Data.Interfaces
{
    public interface IUserQueries
    {
        int GetUserIDByEmail(string name);
        List<Users> GetUsernameByBook(string name);
    }
}
