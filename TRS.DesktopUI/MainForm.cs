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
using TRS.Repositories.Abstract;
using TRS.Repositories.Concrete;

namespace TRS.DesktopUI
{
    public partial class MainForm : Form
    {
        private readonly IReservationRepository _reservationRepository;


        public MainForm()
        {
            _reservationRepository = new SqlReservationRepository(ConfigurationManager.ConnectionStrings["TRS_DBConnectionString"].ConnectionString);

            InitializeComponent();
        }

        private void mcDate_DateSelected(object sender, DateRangeEventArgs e)
        {
            lblReservationCount.Text = String.Format("Count of reservations: {0}",_reservationRepository.GetCountOfReservationOnDate(mcDate.SelectionStart));
            lblTotalGuests.Text = String.Format("Total Guests: {0}", _reservationRepository.GetTotalGuestsOnDate(mcDate.SelectionStart));
        }
    }
}
