using System;
using System.Collections.Generic;
using TRS.Entities;

namespace TRS.Repositories.Abstract
{
    public interface ITableRepository
    {
        IEnumerable<Table> SellectAll();
        IEnumerable<Table> GetAvailableTables(DateTime dateIn, DateTime dateOut, int countOfSeats);
        Table GetTableById(int tableId);
        int GetMaxCountOfSeats();
    }
}
