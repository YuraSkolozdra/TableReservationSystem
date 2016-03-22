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
        IEnumerable<Reservation> GetReservationsByDate(DateTime reservationDate, int reservationStatus = 1);
        IEnumerable<Reservation> GetReservationsByCustomerPhone(Customer customer);
        int GetCountOfReservationByDate(DateTime reservationDate);
        int GetTotalGuestsOnDate(DateTime reservationDate);
        decimal GetCostOfReservation(Table table, DateTime dateIn, DateTime dateOut);
        int ReserveTable(Reservation reservation);
        bool CancelReservationById(int reservationId, int userId);
    }
}
