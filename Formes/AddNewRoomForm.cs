using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.Formes
{
    public partial class AddNewRoomForm : Form
    {
        public Room room { get; private set; }
        private Hotel hotel;
        public AddNewRoomForm(Hotel hotel)
        {
            InitializeComponent();
            this.hotel = hotel;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string inputName = nameTextBox.Text;
            decimal price = priceNumericUpDown.Value;
            int count = (int)countNumericUpDown.Value;
            room = new Room(hotel.GetNextRoomId(), inputName, null, price, DateTime.Now.ToString(), count);
            Close();
        }

    }
}
