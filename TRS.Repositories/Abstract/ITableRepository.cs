using System.Collections.Generic;
using TRS.Entities;

namespace TRS.Repository.Abstract
{
    public interface ITableRepository
    {
        IEnumerable<Table> SellectAll();
        IEnumerable<Table> GetBySeats(int countOfSeats);
    }
}
