using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookish.Data.Interfaces
{
    public interface ICheckOutQueries
    {
        List<CheckOuts> GetCheckOutsByBookID(int id);
        List<CheckOuts> GetCheckOutsByUserID(int id);
        List<CheckOuts> GetAllCheckOuts();
    }
}
