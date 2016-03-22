using TRS.Entities;

namespace TRS.Repositories.Abstract
{
    public interface IUserRepository
    {
        User GetUserByLogin(string login, string password);
    }
}
