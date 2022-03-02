using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

static class GlobalValv
{
    public static int hotel_ID = 1, des_ = 2, hotel_name = 3, in_date = 4, out_date = 5, available_rooms = 6, price = 7, description = 8;
    public static int Selected_Hotel_Index;
    public static DataTable hotel_table = new DataTable();
}

namespace Project_PRG455
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
