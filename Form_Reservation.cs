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
    public partial class Form_Reservation : Form
    {
        int customer_ID = 1, fName = 2, lName = 3, telNumber = 4, address = 5;
        DataTable customer_table = new DataTable();
        int customer_selected_index;
        double total_price;

        public Form_Reservation()
        {
            InitializeComponent();
        }

        private void Form_Reservation_Load(object sender, EventArgs e)
        {
            radioBtn_Have.PerformClick();

            string conStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=ProjectDataBase.accdb";
            string sqlStr = "SELECT  * FROM CustomerData";

            OleDbDataAdapter dadapt = new OleDbDataAdapter(sqlStr, conStr);

            dadapt.Fill(customer_table);
            dadapt.Dispose();
        }

        public void clear_txt() // Clear the textboxes when switching between radio buttons
        {
            txt_customerID.Text = "";
            txt_fName.Text = "";
            txt_lName.Text = "";
            txt_tele.Text = "";
            txt_address.Text = "";
            txt_guestsNum.Text = "";
            txt_roomNum.Text = "";
        }

        private void Form_Reservation_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void radioNtn_Dont_CheckedChanged(object sender, EventArgs e) // Don't have customer ID
        {
            txt_customerID.Enabled = false;
            txt_fName.Enabled = true;
            txt_lName.Enabled = true;
            txt_tele.Enabled = true;
            txt_address.Enabled = true;
            clear_txt();
        }

        private void radioBtn_Have_CheckedChanged(object sender, EventArgs e) // Have customer ID
        {
            txt_customerID.Enabled = true;
            txt_fName.Enabled = false;
            txt_lName.Enabled = false;
            txt_tele.Enabled = false;
            txt_address.Enabled = false;
            clear_txt();
        }

        private void btn_done_Click(object sender, EventArgs e)
        {
            string conStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=ProjectDataBase.accdb";
            OleDbDataAdapter dadapt = new OleDbDataAdapter();
            OleDbConnection con = new OleDbConnection(conStr);

            int available_room;
            bool ID_found = false;

            try
            {
                int tmp = Convert.ToInt32(txt_guestsNum.Text); // Only to check the format of the guest number inputed value
                if (Convert.ToInt32(txt_roomNum.Text) <= Convert.ToInt32(GlobalValv.hotel_table.Rows[GlobalValv.Selected_Hotel_Index][GlobalValv.available_rooms]))
                {
                    available_room = Convert.ToInt32(GlobalValv.hotel_table.Rows[GlobalValv.Selected_Hotel_Index][GlobalValv.available_rooms]) - Convert.ToInt32(txt_roomNum.Text);
                    total_price = Convert.ToDouble(GlobalValv.hotel_table.Rows[GlobalValv.Selected_Hotel_Index][GlobalValv.price]) * Convert.ToDouble(txt_roomNum.Text); // total price without tax

                    if (radioBtn_Have.Checked)
                    {
                        for (int i = 0; i < customer_table.Rows.Count; i++)
                        {
                            if (txt_customerID.Text == customer_table.Rows[i][customer_ID].ToString())
                            {
                                customer_selected_index = i;

                                txt_customerID.Text = customer_table.Rows[customer_selected_index][customer_ID].ToString();
                                txt_fName.Text = customer_table.Rows[customer_selected_index][fName].ToString();
                                txt_lName.Text = customer_table.Rows[customer_selected_index][lName].ToString();
                                txt_tele.Text = customer_table.Rows[customer_selected_index][telNumber].ToString();
                                txt_address.Text = customer_table.Rows[customer_selected_index][address].ToString();

                                conStr = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=ProjectDataBase.accdb";
                                string sqlAdd = "INSERT INTO BookingData(customer_ID,first_name,last_name,telephone_number,address,number_of_guests,hotel_ID,hotel_name,destination_city,check_in_date,check_out_date,number_of_rooms,total_price)" + "VALUES('" + (customer_selected_index + 1).ToString() + "','" + txt_fName.Text + "','" + txt_lName.Text + "','" + txt_tele.Text + "','" + txt_address.Text + "','" + txt_guestsNum.Text + "', '" + GlobalValv.hotel_table.Rows[GlobalValv.Selected_Hotel_Index][GlobalValv.hotel_ID] + "','" + GlobalValv.hotel_table.Rows[GlobalValv.Selected_Hotel_Index][GlobalValv.hotel_name] + "','" + GlobalValv.hotel_table.Rows[GlobalValv.Selected_Hotel_Index][GlobalValv.des_] + "','" + GlobalValv.hotel_table.Rows[GlobalValv.Selected_Hotel_Index][GlobalValv.in_date] + "','" + GlobalValv.hotel_table.Rows[GlobalValv.Selected_Hotel_Index][GlobalValv.out_date] + "','" + txt_roomNum.Text + "','" + total_price.ToString() + "')";
                                string sqlUpdate = "UPDATE HotelData SET number_of_rooms_available='" + available_room.ToString() + "'" + "WHERE hotel_ID= '" + GlobalValv.hotel_table.Rows[GlobalValv.Selected_Hotel_Index][GlobalValv.hotel_ID] + "'";

                                con.Open();
                                dadapt.InsertCommand = new OleDbCommand(sqlAdd, con);
                                dadapt.InsertCommand.ExecuteNonQuery();

                                dadapt.UpdateCommand = new OleDbCommand(sqlUpdate, con);
                                dadapt.UpdateCommand.ExecuteNonQuery();
                                con.Close();

                                ID_found = true;
                                break;
                            }
                            if (i == (customer_table.Rows.Count - 1))
                                MessageBox.Show("ERROR: Could not find this Customer ID.");
                        }
                    }
                    else
                    {
                        customer_selected_index = customer_table.Rows.Count;
                        txt_customerID.Text = (customer_selected_index + 1).ToString();

                        txt_tele.Text = Convert.ToInt64(txt_tele.Text).ToString("(###) ###-####");

                        string sqlAddCustomer = "INSERT INTO CustomerData(customer_ID,first_name,last_name,telephone_number,address)" + "VALUES('" + (customer_selected_index + 1).ToString() + "','" + txt_fName.Text + "','" + txt_lName.Text + "','" + txt_tele.Text + "','" + txt_address.Text + "')";
                        string sqlUpdate = "UPDATE HotelData SET number_of_rooms_available='" + available_room.ToString() + "'" + "WHERE hotel_ID= '" + GlobalValv.hotel_table.Rows[GlobalValv.Selected_Hotel_Index][GlobalValv.hotel_ID] + "'";
                        string sqlAddBooking = "INSERT INTO BookingData(customer_ID,first_name,last_name,telephone_number,address,number_of_guests,hotel_ID,hotel_name,destination_city,check_in_date,check_out_date,number_of_rooms,total_price)" + "VALUES('" + (customer_selected_index + 1).ToString() + "','" + txt_fName.Text + "','" + txt_lName.Text + "','" + txt_tele.Text + "','" + txt_address.Text + "','" + txt_guestsNum.Text + "', '" + GlobalValv.hotel_table.Rows[GlobalValv.Selected_Hotel_Index][GlobalValv.hotel_ID] + "','" + GlobalValv.hotel_table.Rows[GlobalValv.Selected_Hotel_Index][GlobalValv.hotel_name] + "','" + GlobalValv.hotel_table.Rows[GlobalValv.Selected_Hotel_Index][GlobalValv.des_] + "','" + GlobalValv.hotel_table.Rows[GlobalValv.Selected_Hotel_Index][GlobalValv.in_date] + "','" + GlobalValv.hotel_table.Rows[GlobalValv.Selected_Hotel_Index][GlobalValv.out_date] + "','" + txt_roomNum.Text + "','" + total_price.ToString() + "')";

                        con.Open();
                        dadapt.InsertCommand = new OleDbCommand(sqlAddBooking, con);
                        dadapt.InsertCommand.ExecuteNonQuery();

                        dadapt.InsertCommand = new OleDbCommand(sqlAddCustomer, con);
                        dadapt.InsertCommand.ExecuteNonQuery();

                        dadapt.UpdateCommand = new OleDbCommand(sqlUpdate, con);
                        dadapt.UpdateCommand.ExecuteNonQuery();
                        con.Close();

                        ID_found = true;
                    }

                    if (ID_found)
                    {
                        lbl_cus_IDR.Text = txt_customerID.Text;
                        lbl_fNameR.Text = txt_fName.Text;
                        lbl_lNameR.Text = txt_lName.Text;
                        lbl_teleR.Text = txt_tele.Text;
                        lbl_customer_addrR.Text = txt_address.Text;
                        lbl_guestNR.Text = txt_guestsNum.Text;
                        lbl_roomNR.Text = txt_roomNum.Text;

                        lbl_hotel_IDR.Text = GlobalValv.hotel_table.Rows[GlobalValv.Selected_Hotel_Index][GlobalValv.hotel_ID].ToString();
                        lbl_hotelNameR.Text = GlobalValv.hotel_table.Rows[GlobalValv.Selected_Hotel_Index][GlobalValv.hotel_name].ToString();
                        lbl_cityR.Text = GlobalValv.hotel_table.Rows[GlobalValv.Selected_Hotel_Index][GlobalValv.des_].ToString();
                        lbl_date_inR.Text = GlobalValv.hotel_table.Rows[GlobalValv.Selected_Hotel_Index][GlobalValv.in_date].ToString();
                        lbl_date_outR.Text = GlobalValv.hotel_table.Rows[GlobalValv.Selected_Hotel_Index][GlobalValv.out_date].ToString();

                        lbl_total_priceR.Text = total_price.ToString();
                        lbl_taxR.Text = (total_price * 0.13).ToString();
                        lbl_final_costR.Text = (total_price * 1.13).ToString();

                        MessageBox.Show("Your reservation is successfully done.\nNow you can see your receipt.");
                        panel_receipt.Location = new Point(0, 0);
                        panel_customerInfo.Visible = false;
                        panel_receipt.Visible = true;
                    }
                }
                else
                    MessageBox.Show("Sorry, there is only " + GlobalValv.hotel_table.Rows[GlobalValv.Selected_Hotel_Index][GlobalValv.available_rooms].ToString() + " rooms left in this hotel.");
            }
            catch (System.FormatException)
            {
                MessageBox.Show("ERROR:Invalid input(s).\nPlease try again.");
            }
        }
    }
}