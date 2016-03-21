using System;
using System.Collections.Generic;
using TRS.Entities;

namespace TRS.Repositories.Abstract
{
    public interface ITableRepository
    {
        IEnumerable<Table> SellectAll();
        Table GetTableById(int tableId);
        IEnumerable<Table> GetBySeats(int countOfSeats);
        IEnumerable<Table> GetAvailableTables(DateTime dateIn, DateTime dateOut, int countOfSeats);
        int GetMaxCountOfSeats();
    }
}
