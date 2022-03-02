using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_PRG455
{
    public partial class Form_HotelDetails : Form
    {
        public Form_HotelDetails()
        {
            InitializeComponent();
        }

        private void Form_HotelDetails_Load(object sender, EventArgs e) // Putting the entered hotel information
        {
            lbl_hotelID.Text = GlobalValv.hotel_table.Rows[GlobalValv.Selected_Hotel_Index][GlobalValv.hotel_ID].ToString();
            lbl_DesCity.Text = GlobalValv.hotel_table.Rows[GlobalValv.Selected_Hotel_Index][GlobalValv.des_].ToString();
            lbl_hotelName.Text = GlobalValv.hotel_table.Rows[GlobalValv.Selected_Hotel_Index][GlobalValv.hotel_name].ToString();
            lbl_checkIN.Text = GlobalValv.hotel_table.Rows[GlobalValv.Selected_Hotel_Index][GlobalValv.in_date].ToString();
            lbl_checkOUT.Text = GlobalValv.hotel_table.Rows[GlobalValv.Selected_Hotel_Index][GlobalValv.out_date].ToString();
            lbl_availableR.Text = GlobalValv.hotel_table.Rows[GlobalValv.Selected_Hotel_Index][GlobalValv.available_rooms].ToString();
            lbl_price.Text = "$" + GlobalValv.hotel_table.Rows[GlobalValv.Selected_Hotel_Index][GlobalValv.price].ToString();

            pictureBox1.ImageLocation = "Image" + lbl_hotelID.Text + ".jpg";
            rText_description.Text = "Description:\n\n" + GlobalValv.hotel_table.Rows[GlobalValv.Selected_Hotel_Index][GlobalValv.description].ToString();
        }

        private void Form_HotelDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            //this.Close();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            Form_Reservation frm_Resrvation = new Form_Reservation();
            this.Hide();
            frm_Resrvation.ShowDialog();
        }
    }
}
