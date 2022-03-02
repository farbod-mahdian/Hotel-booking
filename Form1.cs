using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace Project_PRG455
{
    public partial class Form1 : Form
    {
        Form_HotelDetails frm_HotelDetails;

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string conStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=ProjectDataBase.accdb";
            string sqlStr = "SELECT  * FROM HotelData";

            OleDbDataAdapter dadapt = new OleDbDataAdapter(sqlStr, conStr);

            dadapt.Fill(GlobalValv.hotel_table);
            dadapt.Dispose();

            frm_HotelDetails = new Form_HotelDetails();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            for(int i = 0;i < GlobalValv.hotel_table.Rows.Count;i++)
            {
                if(txt_hotelName.Text.ToLower() == GlobalValv.hotel_table.Rows[i][GlobalValv.hotel_name].ToString().ToLower()) //Searching for the entered hotel name
                {
                    GlobalValv.Selected_Hotel_Index = i;
                    frm_HotelDetails.ShowDialog();
                    break;
                }
                if (i == (GlobalValv.hotel_table.Rows.Count - 1))
                    MessageBox.Show("ERROR: Could not find this hotel.\nPlease try another hotel.");
            }
        }
    }
}
