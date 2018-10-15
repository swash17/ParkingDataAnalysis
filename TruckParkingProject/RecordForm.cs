using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TruckParkingProject
{
    public partial class frmRecord : Form
    {
        List<TruckParkingRecord> TruckRecords = new List<TruckParkingRecord>(); 
        public frmRecord(List<TruckParkingRecord> recordsImport)
        {
            InitializeComponent();
            TruckRecords = recordsImport;
        }

        private void frmRecord_Load(object sender, EventArgs e)
        {
            LoadTruckRecords();
        }
        private void LoadTruckRecords()
        {
            dgvTruckRecords.Rows.Clear();

            int TotalVehs = TruckRecords.Count;
            int RowCounter = 0;
            string InOrOut = "";
            string VehType = "";
            dgvTruckRecords.Rows.Add(TotalVehs);

            foreach (TruckParkingRecord record in TruckRecords)
            {
                dgvTruckRecords.Rows[RowCounter].Cells[colID.Name].Value = (RowCounter+1).ToString();
                dgvTruckRecords.Rows[RowCounter].Cells[colSpaceNum.Name].Value = record.SpaceNumber.ToString();
                if (record.IsComingIn == true)
                {
                    InOrOut = "In";
                }
                else
                {
                    InOrOut = "Out";
                }
                dgvTruckRecords.Rows[RowCounter].Cells[colInOrOut.Name].Value = InOrOut;
                dgvTruckRecords.Rows[RowCounter].Cells[colDate.Name].Value = record.Date.ToString();
                dgvTruckRecords.Rows[RowCounter].Cells[colYear.Name].Value = record.Year.ToString();
                dgvTruckRecords.Rows[RowCounter].Cells[colMonth.Name].Value = record.Month.ToString();
                dgvTruckRecords.Rows[RowCounter].Cells[colDay.Name].Value = record.Day.ToString();
                dgvTruckRecords.Rows[RowCounter].Cells[colTime.Name].Value = record.Time.ToString();
                dgvTruckRecords.Rows[RowCounter].Cells[colHour.Name].Value = record.Hour.ToString();
                dgvTruckRecords.Rows[RowCounter].Cells[colMinute.Name].Value = record.Minute.ToString();
                dgvTruckRecords.Rows[RowCounter].Cells[colSecond.Name].Value = record.Second.ToString();
                if(record.Class == 1)
                {
                    VehType = "Truck";
                }
                else
                {
                    VehType = "Other";
                }
                dgvTruckRecords.Rows[RowCounter].Cells[colVehType.Name].Value = VehType;
                dgvTruckRecords.Rows[RowCounter].Cells[colAlignment.Name].Value = record.Alignment;
                dgvTruckRecords.Rows[RowCounter].Cells[colIdentifyingInfo.Name].Value = record.IdentifyingInformation;
                RowCounter++;
            }


        }

    }
}
