
namespace Project_PRG455
{
    partial class Form_Reservation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_done = new System.Windows.Forms.Button();
            this.txt_customerID = new System.Windows.Forms.TextBox();
            this.txt_fName = new System.Windows.Forms.TextBox();
            this.txt_lName = new System.Windows.Forms.TextBox();
            this.txt_tele = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_guestsNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radioBtn_Have = new System.Windows.Forms.RadioButton();
            this.radioBtn_Dont = new System.Windows.Forms.RadioButton();
            this.panel_receipt = new System.Windows.Forms.Panel();
            this.lbl_final_costR = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.lbl_taxR = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lbl_total_priceR = new System.Windows.Forms.Label();
            this.lbl_date_outR = new System.Windows.Forms.Label();
            this.lbl_date_inR = new System.Windows.Forms.Label();
            this.lbl_cityR = new System.Windows.Forms.Label();
            this.lbl_hotelNameR = new System.Windows.Forms.Label();
            this.lbl_hotel_IDR = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.lbl_roomNR = new System.Windows.Forms.Label();
            this.lbl_guestNR = new System.Windows.Forms.Label();
            this.lbl_customer_addrR = new System.Windows.Forms.Label();
            this.lbl_teleR = new System.Windows.Forms.Label();
            this.lbl_lNameR = new System.Windows.Forms.Label();
            this.lbl_fNameR = new System.Windows.Forms.Label();
            this.lbl_cus_IDR = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_roomNum = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel_customerInfo = new System.Windows.Forms.Panel();
            this.panel_receipt.SuspendLayout();
            this.panel_customerInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_done
            // 
            this.btn_done.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_done.Location = new System.Drawing.Point(102, 198);
            this.btn_done.Name = "btn_done";
            this.btn_done.Size = new System.Drawing.Size(100, 23);
            this.btn_done.TabIndex = 0;
            this.btn_done.Text = "Done";
            this.btn_done.UseVisualStyleBackColor = false;
            this.btn_done.Click += new System.EventHandler(this.btn_done_Click);
            // 
            // txt_customerID
            // 
            this.txt_customerID.Location = new System.Drawing.Point(102, 7);
            this.txt_customerID.Name = "txt_customerID";
            this.txt_customerID.Size = new System.Drawing.Size(100, 20);
            this.txt_customerID.TabIndex = 1;
            // 
            // txt_fName
            // 
            this.txt_fName.Location = new System.Drawing.Point(102, 33);
            this.txt_fName.Name = "txt_fName";
            this.txt_fName.Size = new System.Drawing.Size(100, 20);
            this.txt_fName.TabIndex = 2;
            // 
            // txt_lName
            // 
            this.txt_lName.Location = new System.Drawing.Point(102, 59);
            this.txt_lName.Name = "txt_lName";
            this.txt_lName.Size = new System.Drawing.Size(100, 20);
            this.txt_lName.TabIndex = 3;
            // 
            // txt_tele
            // 
            this.txt_tele.Location = new System.Drawing.Point(102, 85);
            this.txt_tele.Name = "txt_tele";
            this.txt_tele.Size = new System.Drawing.Size(100, 20);
            this.txt_tele.TabIndex = 4;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(102, 111);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(100, 20);
            this.txt_address.TabIndex = 5;
            // 
            // txt_guestsNum
            // 
            this.txt_guestsNum.Location = new System.Drawing.Point(102, 137);
            this.txt_guestsNum.Name = "txt_guestsNum";
            this.txt_guestsNum.Size = new System.Drawing.Size(100, 20);
            this.txt_guestsNum.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Customer ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "First name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Last name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Telefone number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Number of guests:";
            // 
            // radioBtn_Have
            // 
            this.radioBtn_Have.AutoSize = true;
            this.radioBtn_Have.Location = new System.Drawing.Point(285, 84);
            this.radioBtn_Have.Name = "radioBtn_Have";
            this.radioBtn_Have.Size = new System.Drawing.Size(156, 17);
            this.radioBtn_Have.TabIndex = 13;
            this.radioBtn_Have.Text = "Already have a customer ID";
            this.radioBtn_Have.UseVisualStyleBackColor = true;
            this.radioBtn_Have.CheckedChanged += new System.EventHandler(this.radioBtn_Have_CheckedChanged);
            // 
            // radioBtn_Dont
            // 
            this.radioBtn_Dont.AutoSize = true;
            this.radioBtn_Dont.Location = new System.Drawing.Point(285, 110);
            this.radioBtn_Dont.Name = "radioBtn_Dont";
            this.radioBtn_Dont.Size = new System.Drawing.Size(100, 17);
            this.radioBtn_Dont.TabIndex = 14;
            this.radioBtn_Dont.Text = "Need to register";
            this.radioBtn_Dont.UseVisualStyleBackColor = true;
            this.radioBtn_Dont.CheckedChanged += new System.EventHandler(this.radioNtn_Dont_CheckedChanged);
            // 
            // panel_receipt
            // 
            this.panel_receipt.BackColor = System.Drawing.Color.White;
            this.panel_receipt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_receipt.Controls.Add(this.label16);
            this.panel_receipt.Controls.Add(this.label15);
            this.panel_receipt.Controls.Add(this.lbl_final_costR);
            this.panel_receipt.Controls.Add(this.label30);
            this.panel_receipt.Controls.Add(this.lbl_taxR);
            this.panel_receipt.Controls.Add(this.label22);
            this.panel_receipt.Controls.Add(this.lbl_total_priceR);
            this.panel_receipt.Controls.Add(this.lbl_date_outR);
            this.panel_receipt.Controls.Add(this.lbl_date_inR);
            this.panel_receipt.Controls.Add(this.lbl_cityR);
            this.panel_receipt.Controls.Add(this.lbl_hotelNameR);
            this.panel_receipt.Controls.Add(this.lbl_hotel_IDR);
            this.panel_receipt.Controls.Add(this.label23);
            this.panel_receipt.Controls.Add(this.label24);
            this.panel_receipt.Controls.Add(this.label25);
            this.panel_receipt.Controls.Add(this.label26);
            this.panel_receipt.Controls.Add(this.label27);
            this.panel_receipt.Controls.Add(this.label28);
            this.panel_receipt.Controls.Add(this.lbl_roomNR);
            this.panel_receipt.Controls.Add(this.lbl_guestNR);
            this.panel_receipt.Controls.Add(this.lbl_customer_addrR);
            this.panel_receipt.Controls.Add(this.lbl_teleR);
            this.panel_receipt.Controls.Add(this.lbl_lNameR);
            this.panel_receipt.Controls.Add(this.lbl_fNameR);
            this.panel_receipt.Controls.Add(this.lbl_cus_IDR);
            this.panel_receipt.Controls.Add(this.label14);
            this.panel_receipt.Controls.Add(this.label7);
            this.panel_receipt.Controls.Add(this.label8);
            this.panel_receipt.Controls.Add(this.label9);
            this.panel_receipt.Controls.Add(this.label10);
            this.panel_receipt.Controls.Add(this.label11);
            this.panel_receipt.Controls.Add(this.label12);
            this.panel_receipt.Location = new System.Drawing.Point(0, 230);
            this.panel_receipt.Name = "panel_receipt";
            this.panel_receipt.Size = new System.Drawing.Size(530, 320);
            this.panel_receipt.TabIndex = 15;
            this.panel_receipt.Visible = false;
            // 
            // lbl_final_costR
            // 
            this.lbl_final_costR.AutoSize = true;
            this.lbl_final_costR.Location = new System.Drawing.Point(269, 286);
            this.lbl_final_costR.Name = "lbl_final_costR";
            this.lbl_final_costR.Size = new System.Drawing.Size(27, 13);
            this.lbl_final_costR.TabIndex = 43;
            this.lbl_final_costR.Text = "N/A";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(202, 286);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(58, 13);
            this.label30.TabIndex = 42;
            this.label30.Text = "Total Cost:";
            // 
            // lbl_taxR
            // 
            this.lbl_taxR.AutoSize = true;
            this.lbl_taxR.Location = new System.Drawing.Point(269, 255);
            this.lbl_taxR.Name = "lbl_taxR";
            this.lbl_taxR.Size = new System.Drawing.Size(27, 13);
            this.lbl_taxR.TabIndex = 41;
            this.lbl_taxR.Text = "N/A";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(202, 255);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(28, 13);
            this.label22.TabIndex = 40;
            this.label22.Text = "Tax:";
            // 
            // lbl_total_priceR
            // 
            this.lbl_total_priceR.AutoSize = true;
            this.lbl_total_priceR.Location = new System.Drawing.Point(269, 233);
            this.lbl_total_priceR.Name = "lbl_total_priceR";
            this.lbl_total_priceR.Size = new System.Drawing.Size(27, 13);
            this.lbl_total_priceR.TabIndex = 39;
            this.lbl_total_priceR.Text = "N/A";
            // 
            // lbl_date_outR
            // 
            this.lbl_date_outR.AutoSize = true;
            this.lbl_date_outR.Location = new System.Drawing.Point(398, 114);
            this.lbl_date_outR.Name = "lbl_date_outR";
            this.lbl_date_outR.Size = new System.Drawing.Size(27, 13);
            this.lbl_date_outR.TabIndex = 37;
            this.lbl_date_outR.Text = "N/A";
            // 
            // lbl_date_inR
            // 
            this.lbl_date_inR.AutoSize = true;
            this.lbl_date_inR.Location = new System.Drawing.Point(398, 88);
            this.lbl_date_inR.Name = "lbl_date_inR";
            this.lbl_date_inR.Size = new System.Drawing.Size(27, 13);
            this.lbl_date_inR.TabIndex = 36;
            this.lbl_date_inR.Text = "N/A";
            // 
            // lbl_cityR
            // 
            this.lbl_cityR.AutoSize = true;
            this.lbl_cityR.Location = new System.Drawing.Point(398, 62);
            this.lbl_cityR.Name = "lbl_cityR";
            this.lbl_cityR.Size = new System.Drawing.Size(27, 13);
            this.lbl_cityR.TabIndex = 35;
            this.lbl_cityR.Text = "N/A";
            // 
            // lbl_hotelNameR
            // 
            this.lbl_hotelNameR.AutoSize = true;
            this.lbl_hotelNameR.Location = new System.Drawing.Point(398, 36);
            this.lbl_hotelNameR.Name = "lbl_hotelNameR";
            this.lbl_hotelNameR.Size = new System.Drawing.Size(27, 13);
            this.lbl_hotelNameR.TabIndex = 34;
            this.lbl_hotelNameR.Text = "N/A";
            // 
            // lbl_hotel_IDR
            // 
            this.lbl_hotel_IDR.AutoSize = true;
            this.lbl_hotel_IDR.Location = new System.Drawing.Point(398, 10);
            this.lbl_hotel_IDR.Name = "lbl_hotel_IDR";
            this.lbl_hotel_IDR.Size = new System.Drawing.Size(27, 13);
            this.lbl_hotel_IDR.TabIndex = 33;
            this.lbl_hotel_IDR.Text = "N/A";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(202, 233);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(61, 13);
            this.label23.TabIndex = 32;
            this.label23.Text = "Total Price:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(270, 114);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(85, 13);
            this.label24.TabIndex = 30;
            this.label24.Text = "Check-out Date:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(270, 88);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(78, 13);
            this.label25.TabIndex = 29;
            this.label25.Text = "Check-in Date:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(270, 62);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(122, 13);
            this.label26.TabIndex = 28;
            this.label26.Text = "Destination city/country:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(270, 36);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(66, 13);
            this.label27.TabIndex = 27;
            this.label27.Text = "Hotel Name:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(270, 10);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(49, 13);
            this.label28.TabIndex = 26;
            this.label28.Text = "Hotel ID:";
            // 
            // lbl_roomNR
            // 
            this.lbl_roomNR.AutoSize = true;
            this.lbl_roomNR.Location = new System.Drawing.Point(110, 165);
            this.lbl_roomNR.Name = "lbl_roomNR";
            this.lbl_roomNR.Size = new System.Drawing.Size(27, 13);
            this.lbl_roomNR.TabIndex = 24;
            this.lbl_roomNR.Text = "N/A";
            // 
            // lbl_guestNR
            // 
            this.lbl_guestNR.AutoSize = true;
            this.lbl_guestNR.Location = new System.Drawing.Point(110, 140);
            this.lbl_guestNR.Name = "lbl_guestNR";
            this.lbl_guestNR.Size = new System.Drawing.Size(27, 13);
            this.lbl_guestNR.TabIndex = 25;
            this.lbl_guestNR.Text = "N/A";
            // 
            // lbl_customer_addrR
            // 
            this.lbl_customer_addrR.AutoSize = true;
            this.lbl_customer_addrR.Location = new System.Drawing.Point(110, 114);
            this.lbl_customer_addrR.Name = "lbl_customer_addrR";
            this.lbl_customer_addrR.Size = new System.Drawing.Size(27, 13);
            this.lbl_customer_addrR.TabIndex = 23;
            this.lbl_customer_addrR.Text = "N/A";
            // 
            // lbl_teleR
            // 
            this.lbl_teleR.AutoSize = true;
            this.lbl_teleR.Location = new System.Drawing.Point(110, 88);
            this.lbl_teleR.Name = "lbl_teleR";
            this.lbl_teleR.Size = new System.Drawing.Size(27, 13);
            this.lbl_teleR.TabIndex = 22;
            this.lbl_teleR.Text = "N/A";
            // 
            // lbl_lNameR
            // 
            this.lbl_lNameR.AutoSize = true;
            this.lbl_lNameR.Location = new System.Drawing.Point(110, 62);
            this.lbl_lNameR.Name = "lbl_lNameR";
            this.lbl_lNameR.Size = new System.Drawing.Size(27, 13);
            this.lbl_lNameR.TabIndex = 21;
            this.lbl_lNameR.Text = "N/A";
            // 
            // lbl_fNameR
            // 
            this.lbl_fNameR.AutoSize = true;
            this.lbl_fNameR.Location = new System.Drawing.Point(110, 36);
            this.lbl_fNameR.Name = "lbl_fNameR";
            this.lbl_fNameR.Size = new System.Drawing.Size(27, 13);
            this.lbl_fNameR.TabIndex = 20;
            this.lbl_fNameR.Text = "N/A";
            // 
            // lbl_cus_IDR
            // 
            this.lbl_cus_IDR.AutoSize = true;
            this.lbl_cus_IDR.Location = new System.Drawing.Point(110, 10);
            this.lbl_cus_IDR.Name = "lbl_cus_IDR";
            this.lbl_cus_IDR.Size = new System.Drawing.Size(27, 13);
            this.lbl_cus_IDR.TabIndex = 19;
            this.lbl_cus_IDR.Text = "N/A";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 165);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "Number of Rooms:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Number of guests:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Address:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Telefone number:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Last name:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "First name:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Customer ID:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 166);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Number of Rooms:";
            // 
            // txt_roomNum
            // 
            this.txt_roomNum.Location = new System.Drawing.Point(102, 163);
            this.txt_roomNum.Name = "txt_roomNum";
            this.txt_roomNum.Size = new System.Drawing.Size(100, 20);
            this.txt_roomNum.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(193, 270);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(118, 13);
            this.label15.TabIndex = 18;
            this.label15.Text = "-------------------------------------";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(194, 262);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(13, 13);
            this.label16.TabIndex = 44;
            this.label16.Text = "+";
            // 
            // panel_customerInfo
            // 
            this.panel_customerInfo.Controls.Add(this.label1);
            this.panel_customerInfo.Controls.Add(this.txt_roomNum);
            this.panel_customerInfo.Controls.Add(this.txt_customerID);
            this.panel_customerInfo.Controls.Add(this.label13);
            this.panel_customerInfo.Controls.Add(this.txt_fName);
            this.panel_customerInfo.Controls.Add(this.txt_lName);
            this.panel_customerInfo.Controls.Add(this.btn_done);
            this.panel_customerInfo.Controls.Add(this.txt_tele);
            this.panel_customerInfo.Controls.Add(this.radioBtn_Dont);
            this.panel_customerInfo.Controls.Add(this.txt_address);
            this.panel_customerInfo.Controls.Add(this.radioBtn_Have);
            this.panel_customerInfo.Controls.Add(this.txt_guestsNum);
            this.panel_customerInfo.Controls.Add(this.label6);
            this.panel_customerInfo.Controls.Add(this.label2);
            this.panel_customerInfo.Controls.Add(this.label5);
            this.panel_customerInfo.Controls.Add(this.label3);
            this.panel_customerInfo.Controls.Add(this.label4);
            this.panel_customerInfo.Location = new System.Drawing.Point(0, 0);
            this.panel_customerInfo.Name = "panel_customerInfo";
            this.panel_customerInfo.Size = new System.Drawing.Size(530, 230);
            this.panel_customerInfo.TabIndex = 18;
            // 
            // Form_Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(534, 555);
            this.Controls.Add(this.panel_customerInfo);
            this.Controls.Add(this.panel_receipt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Reservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservation";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Reservation_FormClosed);
            this.Load += new System.EventHandler(this.Form_Reservation_Load);
            this.panel_receipt.ResumeLayout(false);
            this.panel_receipt.PerformLayout();
            this.panel_customerInfo.ResumeLayout(false);
            this.panel_customerInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_done;
        private System.Windows.Forms.TextBox txt_customerID;
        private System.Windows.Forms.TextBox txt_fName;
        private System.Windows.Forms.TextBox txt_lName;
        private System.Windows.Forms.TextBox txt_tele;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_guestsNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioBtn_Have;
        private System.Windows.Forms.RadioButton radioBtn_Dont;
        private System.Windows.Forms.Panel panel_receipt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_roomNum;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbl_roomNR;
        private System.Windows.Forms.Label lbl_guestNR;
        private System.Windows.Forms.Label lbl_customer_addrR;
        private System.Windows.Forms.Label lbl_teleR;
        private System.Windows.Forms.Label lbl_lNameR;
        private System.Windows.Forms.Label lbl_fNameR;
        private System.Windows.Forms.Label lbl_cus_IDR;
        private System.Windows.Forms.Label lbl_final_costR;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label lbl_taxR;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lbl_total_priceR;
        private System.Windows.Forms.Label lbl_date_outR;
        private System.Windows.Forms.Label lbl_date_inR;
        private System.Windows.Forms.Label lbl_cityR;
        private System.Windows.Forms.Label lbl_hotelNameR;
        private System.Windows.Forms.Label lbl_hotel_IDR;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel_customerInfo;
    }
}