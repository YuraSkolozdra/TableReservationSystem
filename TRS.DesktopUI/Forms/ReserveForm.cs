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
using TRS.Repositories.Abstract;
using TRS.Repositories.Concrete;
using TRS.Entities;

namespace TRS.DesktopUI.Forms
{
    public partial class ReserveForm : Form
    {
        private readonly IReservationRepository _reservationRepository;

        public ReserveForm()
        {
            _reservationRepository = new SqlReservationRepository(ConfigurationManager.ConnectionStrings["TRS_DBConnectionString"].ConnectionString);

            InitializeComponent();

            dtpTimeFrom.CustomFormat = "HH:mm";
            dtpTimeFrom.ShowUpDown = true;
            DateTime dateTime = DateTime.Now;
            dtpTimeFrom.MinDate = dateTime;
            dtpTimeFrom.MaxDate = dateTime.AddHours(5);
            Show();
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            if (!IsFieldsValid()) return;
            //var customer = _customerRepository.CreateCustomer("Yura", "SK", "093");
            //var user = _userRepository.GetCurrentUser();
            //var table = _tableRepository.GetTableById(tableId);

            //var reservation = new Reservation
            //{
            //    DateIn = DateTime.Now,
            //    DateOut = DateTime.Now.AddHours(1),
            //    Table = table,
            //    User = user,
            //    Customer = customer
            //};


            //reservation.Id = _reservationRepository.ReserveTable(reservation);

            //update UI with new reservation
            //MessageBox.Show(reservationId.ToString());
        }

        #region Input Validators

        private bool IsFirstNameValid()
        {
            return (tbFirstName.Text.Length >= 1);
        }

        private bool IsLastNameValid()
        {
            return (tbLastName.Text.Length >= 1);
        }

        private bool IsPhoneValid()
        {
            return (tbPhone.Text.Length >= 1);
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

                MessageBox.Show(errorMessageBuilder.ToString(), "Error", MessageBoxButtons.OK);
            }

            return isFieldsValid;
        }
       
        #endregion

    }
}
