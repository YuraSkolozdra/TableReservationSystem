using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRS.Entities;

namespace TRS.Repositories.Abstract
{
    public interface IReservationRepository
    {
        IEnumerable<Reservation> SellectAll();
        IEnumerable<Reservation> GetReservationsByDate(DateTime reservationDate);
        int GetCountOfReservationOnDate(DateTime reservationDate);
        int GetTotalGuestsOnDate(DateTime reservationDate);
    }
}
