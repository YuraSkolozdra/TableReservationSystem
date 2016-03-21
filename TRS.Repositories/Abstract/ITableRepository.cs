using System.Collections.Generic;
using TRS.Entities;

namespace TRS.Repositories.Abstract
{
    public interface ITableRepository
    {
        IEnumerable<Table> SellectAll();
        IEnumerable<Table> GetBySeats(int countOfSeats);
    }
}
