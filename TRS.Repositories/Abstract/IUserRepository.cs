using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRS.Entities;

namespace TRS.Repositories.Abstract
{
    public interface IUserRepository
    {
        User GetUserByLogin(string login, string password);
    }
}
