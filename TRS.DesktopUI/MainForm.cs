using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TRS.DesktopUI.Forms;
using TRS.Entities;
using TRS.Repositories.Abstract;
using TRS.Repositories.Concrete;

namespace TRS.DesktopUI
{
    public partial class MainForm : Form
    {
        #region Private Fields

        private readonly IReservationRepository _reservationRepository;

        #endregion

        #region Constructors

        public MainForm()
        {
            _reservationRepository = new SqlReservationRepository(ConfigurationManager.ConnectionStrings["TRS_DBConnectionString"].ConnectionString);

            InitializeComponent();
        }

        #endregion

        #region Component's methods

        private void btnReserve_Click(object sender, EventArgs e)
        {
            ReserveForm reserveForm = new ReserveForm();
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            UpdateReservations();
        }

        #endregion

        #region Initialize methods

        private void InitializeDatareservations()
        {
            dgvReservations.ReadOnly = true;
            dgvReservations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReservations.MultiSelect = false;
        }

        #endregion


        #region Update methods

        private void UpdateReservations()
        {
            var reservationDate = dtpDate.Value;
            dgvReservations.Rows.Clear();
            var reservations = (List<Reservation>)_reservationRepository.GetReservationsByDate(reservationDate);

            for (int i = 0; i < reservations.Count; i++)
            {
                dgvReservations.Rows.Add();
                dgvReservations[0, i].Value = reservations[i].Id;
                dgvReservations[1, i].Value = reservations[i].Table.Id;
                dgvReservations[2, i].Value = reservations[i].Customer.FirstName;
                dgvReservations[3, i].Value = reservations[i].Customer.LastName;
                dgvReservations[4, i].Value = reservations[i].Customer.Phone;
                dgvReservations[5, i].Value = reservations[i].DateIn.TimeOfDay;
                dgvReservations[6, i].Value = reservations[i].DateOut.TimeOfDay;
                dgvReservations[7, i].Value = reservations[i].Table.CountOfSeats;
                dgvReservations[8, i].Value = reservations[i].Cost;
            }

            lblReservationCount.Text = String.Format("Count of reservations: {0}", _reservationRepository.GetCountOfReservationByDate(reservationDate));
            lblTotalGuests.Text = String.Format("Total Guests: {0}", _reservationRepository.GetTotalGuestsOnDate(reservationDate));
        }

        #endregion
    }
}
