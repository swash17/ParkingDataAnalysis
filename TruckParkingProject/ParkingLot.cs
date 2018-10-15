using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TruckParkingDataAnalysis
{
    public partial class frmParkingLot : Form
    {
        List<TruckParkingRecord> TruckRecords = new List<TruckParkingRecord>();
        public frmParkingLot(List<TruckParkingRecord> recordsImport)
        {
            InitializeComponent();
            TruckRecords = recordsImport;
        }

        private void btnSpace1_Click(object sender, EventArgs e)
        {

        }

        private void btnSpace2_Click(object sender, EventArgs e)
        {

        }

        private void btnOverall_Click(object sender, EventArgs e)
        {
            //frmParkingRecords OverallCharts = new frmParkingRecords(TruckRecords);
            //OverallCharts.Show();
        }
    }
}
