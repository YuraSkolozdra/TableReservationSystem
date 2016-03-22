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
using TRS.DesktopUI.Code;
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

        /// <summary>
        /// represents reservation radiobutton status : 
        /// 1 - confirmed reservations
        /// 2 - canceled
        /// </summary>
        private int rbChecked = 1;

        #endregion

        #region Constructors

        public MainForm()
        {
            _reservationRepository = new SqlReservationRepository(ConfigurationManager.ConnectionStrings["TRS_DBConnectionString"].ConnectionString);

            InitializeComponent();

            InitializeDataReservations();
        }

        #endregion

        #region Component's methods

        private void btnReserve_Click(object sender, EventArgs e)
        {
            ReserveForm reserveForm = new ReserveForm();
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            ShowReservations();
        }

        #endregion

        #region Initialize methods

        private void InitializeDataReservations()
        {
            dgvReservations.ReadOnly = true;
            dgvReservations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReservations.MultiSelect = false;

            rbConfirmedRes.Checked = true;
            ShowReservations();
        }

        #endregion


        #region Showing methods

        private void ShowReservations(int reservationStatus = 1)
        {
            var reservationDate = dtpDate.Value;
            dgvReservations.Rows.Clear();
            var reservations = (List<Reservation>)_reservationRepository.GetReservationsByDate(reservationDate, reservationStatus);

            for (var i = 0; i < reservations.Count; i++)
            {
                dgvReservations.Rows.Add();
                dgvReservations[0, i].Value = reservations[i].Id;
                dgvReservations[1, i].Value = reservations[i].Customer.FirstName;
                dgvReservations[2, i].Value = reservations[i].Customer.LastName;
                dgvReservations[3, i].Value = reservations[i].Customer.Phone;
                dgvReservations[4, i].Value = reservations[i].DateIn.TimeOfDay;
                dgvReservations[5, i].Value = reservations[i].DateOut.TimeOfDay;
                dgvReservations[6, i].Value = reservations[i].Table.Id;
                dgvReservations[7, i].Value = reservations[i].Cost.ToString("C");
                dgvReservations[8, i].Value = reservations[i].Table.CountOfSeats;
            }

            lblReservationCount.Text = String.Format("Count of reservations: {0}", _reservationRepository.GetCountOfReservationByDate(reservationDate));
            lblTotalGuests.Text = String.Format("Total Guests: {0}", _reservationRepository.GetTotalGuestsOnDate(reservationDate));
        }

        #endregion

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ShowReservations(rbChecked);
        }

        private void OnCheckedChange(object sender, EventArgs e)
        {
            if (rbConfirmedRes.Checked)
            {
                rbChecked = 1;
            }
            if (rbCanceledRes.Checked)
            {
                rbChecked = 2;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (!IsTableRowSelected())
            {
                MessageBox.Show("Select reservation!", "Error", MessageBoxButtons.OK);
                return;
            }

            var reservationId = (int)dgvReservations[0, dgvReservations.SelectedRows[0].Index].Value;


            var confirmResult = MessageBox.Show("Are you sure to delete reservation ??",
                                     "Cancel reservation!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {

            }
            _reservationRepository.CancelReservationById(reservationId, CurrentUser.Id);
        }


        #region Validators

        private bool IsTableRowSelected()
        {
            return dgvReservations.SelectedRows.Count > 0;
        }

        #endregion
    }
}
