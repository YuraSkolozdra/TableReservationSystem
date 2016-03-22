using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using System.Windows.Forms;
using TRS.Repositories.Abstract;
using TRS.Repositories.Concrete;
using TRS.Entities;
using TRS.DesktopUI.Code;

namespace TRS.DesktopUI.Forms
{
    public partial class ReserveForm : Form
    {
        #region Const Fields

        private const int openHours = 8;
        private const int closeHours = 23;
        private const int reservationInterval = 30;

        #endregion

        #region Private Fields

        private readonly IReservationRepository _reservationRepository;
        private readonly ITableRepository _tableRepository;

        #endregion

        #region Constructors

        public ReserveForm()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["TRS_DB"].ConnectionString;
            _reservationRepository = new SqlReservationRepository(connectionString);
            _tableRepository = new SqlTableRepository(connectionString);

            InitializeComponent();
        }

        #endregion

        #region Methods of form's components

        private void ReserveForm_Load(object sender, EventArgs e)
        {
            var dateNow = DateTime.Now;
            dtpDate.MinDate = dateNow;

            InitializeTimeInputs(dtpDate.Value.Date);
            InitializeDataTables();
            InitializeCountOfSeats();
        }

        private void btnCheckAvailability_Click(object sender, EventArgs e)
        {
            ShowAvailableTables();
            dgvTables_SelectionChanged(sender, e);
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            if (!IsFieldsValid())
            {
                return;
            }

            var dateIn = dtpDate.Value.Date.Add(ParseCbToTime(cbTimeFrom));
            var dateOut = dtpDate.Value.Date.Add(ParseCbToTime(cbTimeTo));

            var table = _tableRepository.GetTableById((int)dgvTables[0, dgvTables.SelectedRows[0].Index].Value);

            var customer = new Customer() { FirstName = tbFirstName.Text, LastName = tbLastName.Text, Phone = tbPhone.Text };

            var reservation = new Reservation
            {
                Table = table,
                Customer = customer,
                DateIn = dateIn,
                DateOut = dateOut,
                UserId = CurrentUser.Id
            };

            var confirmResult = MessageBox.Show("Are you sure to reserve this table ??",
                                     "Confirm reservation!!",
                                     MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                reservation.Id = _reservationRepository.ReserveTable(reservation);
                var message = string.Format("Reservation was made, reservation id: {0}", reservation.Id.ToString());
                MessageBox.Show(message, "Reservation succeeded", MessageBoxButtons.OK);
                dgvTables.Rows.Clear();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to close reservation ?",
                                     "Close reservation!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            InitializeTimeInputs(dtpDate.Value.Date);
            dgvTables.Rows.Clear();
        }

        private void dgvTables_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTables.SelectedRows.Count < 1 || dgvTables.SelectedRows[0].Cells[0].Value == null)
            {
                lblSelectedTable.Text = "Selected table";
                lblCost.Text = "Cost";
                return;
            }

            var table = _tableRepository.GetTableById((int)dgvTables[0, dgvTables.SelectedRows[0].Index].Value);

            var dateIn = dtpDate.Value.Date.Add(ParseCbToTime(cbTimeFrom));
            var dateOut = dtpDate.Value.Date.Add(ParseCbToTime(cbTimeTo));

            decimal cost = _reservationRepository.GetCostOfReservation(table, dateIn, dateOut);

            lblSelectedTable.Text = string.Format("Selected table\t {0}", table.Id);
            lblCost.Text = string.Format("Cost\t {0:C}", cost);
        }

        private void cbTimeFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvTables.Rows.Clear();
        }

        private void cbTimeTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvTables.Rows.Clear();
        }

        private void cbCountOfPeople_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvTables.Rows.Clear();
        }

        #endregion

        #region Initializing methods        

        private void InitializeTimeInputs(DateTime selectedDate)
        {
            cbTimeFrom.Items.Clear();
            cbTimeTo.Items.Clear();

            var startTime = new TimeSpan(openHours, 0, 0);
            var interval = new TimeSpan(0, reservationInterval, 0);

            var dateNow = DateTime.Now;

            if (selectedDate.Date == dateNow.Date &&
                (dateNow.Hour > openHours) &&
                (dateNow.Hour < closeHours))
            {
                var minutes = (dateNow.Minute % reservationInterval > 0) ? reservationInterval : 0;
                startTime = new TimeSpan(dateNow.AddHours(1).Hour, minutes, 0);
            }

            var open = selectedDate.Date.Add(startTime);
            var close = selectedDate.Date.Add(new TimeSpan(closeHours, 0, 0));

            for (var _time = open; _time <= close; _time = _time.AddMinutes(reservationInterval))
            {
                cbTimeFrom.Items.Add(_time.ToString("HH:mm"));
                cbTimeTo.Items.Add(_time.ToString("HH:mm"));
            }

            cbTimeFrom.SelectedIndex = 0;
            cbTimeTo.SelectedIndex = 0;
        }

        private void InitializeCountOfSeats()
        {
            var maxCountOfSeats = _tableRepository.GetMaxCountOfSeats();

            for (var i = 1; i <= maxCountOfSeats; i++)
            {
                cbCountOfPeople.Items.Add(i);
            }

            cbCountOfPeople.SelectedIndex = 0;
        }

        private void InitializeDataTables()
        {
            dgvTables.ReadOnly = true;
            dgvTables.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTables.MultiSelect = false;
        }

        private void ShowAvailableTables()
        {
            if (!IsTimesValid())
            {
                MessageBox.Show("Bad From and To reservation's times!", "Error", MessageBoxButtons.OK);
                return;
            }
            var dateIn = dtpDate.Value.Date.Add(ParseCbToTime(cbTimeFrom));
            var dateOut = dtpDate.Value.Date.Add(ParseCbToTime(cbTimeTo));
            var countOfPeople = Int32.Parse(cbCountOfPeople.Text);

            var tables = (List<Table>)_tableRepository.GetAvailableTables(dateIn, dateOut, countOfPeople);

            dgvTables.Rows.Clear();
            for (var i = 0; i < tables.Count; i++)
            {
                dgvTables.Rows.Add();
                dgvTables[0, i].Value = tables[i].Id;
                dgvTables[1, i].Value = tables[i].Rate.ToString("C");
                dgvTables[2, i].Value = tables[i].CountOfSeats;
                dgvTables[3, i].Value = tables[i].Location.Name;
            }
        }

        #endregion

        #region Input Validators

        private bool IsFirstNameValid()
        {
            return (tbFirstName.Text.Length >= 2);
        }

        private bool IsLastNameValid()
        {
            return (tbLastName.Text.Length >= 2);
        }

        private bool IsPhoneValid()
        {
            return (tbPhone.Text.Length >= 3);
        }

        private bool IsTableSelected()
        {
            return dgvTables.SelectedRows.Count > 0;
        }

        private bool IsFieldsValid()
        {
            var isFieldsValid = IsFirstNameValid() && IsLastNameValid() && IsPhoneValid();

            if (!isFieldsValid)
            {
                var errorMessageBuilder = new StringBuilder();

                if (!IsFirstNameValid()) errorMessageBuilder.AppendFormat("Bad first name: {0}\n", tbFirstName.Text);
                if (!IsLastNameValid()) errorMessageBuilder.AppendFormat("Bad surname: {0}\n", tbLastName.Text);
                if (!IsPhoneValid()) errorMessageBuilder.AppendFormat("Bad phone number: {0}\n", tbPhone.Text);
                if (!IsTableSelected()) errorMessageBuilder.AppendFormat("No table selected \n");

                MessageBox.Show(errorMessageBuilder.ToString(), "Error", MessageBoxButtons.OK);
            }

            return isFieldsValid;
        }

        private bool IsTimesValid()
        {
            var startTime = dtpDate.Value.Date.Add(ParseCbToTime(cbTimeFrom));
            var endTime = dtpDate.Value.Date.Add(ParseCbToTime(cbTimeTo));
            return DateTime.Compare(startTime, endTime) < 0;
        }

        private TimeSpan ParseCbToTime(ComboBox comboBox)
        {
            var cbSplit = comboBox.Text.Split(':');
            var hours = Int32.Parse(cbSplit[0]);
            var minutes = Int32.Parse(cbSplit[1]);

            return new TimeSpan(hours, minutes, 0);
        }

        #endregion


    }
}
