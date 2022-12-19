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
    public partial class EditRoom : Form
    {
        private Room place;
        public EditRoom(Room place)
        {
            this.place = place;
            InitializeComponent();
            if (place.Holder == null)
            {
                fireBtn.Visible = fireBtn.Enabled = false;
            }
            nameTextBox.Text = place.Name;
            priceUpDown.Value = place.Price;
            scheduleTextBox.Text = place.DateOfVisiting;
        }
        public static void EditRoomInfo(Room place)
        {
            place.Name = place.Name;
            place.Price = place.Price;
            place.DateOfVisiting = place.DateOfVisiting;
            using (SQLiteConnection connection = new SQLiteConnection("Data Source = Hotel.db;Version=3;"))
            {

                connection.Open();
                SQLiteCommand command = new SQLiteCommand(connection);
                command.CommandText = @"UPDATE Rooms SET Name=@Name,Price=@price,LastVisiting=@lastVisiting WHERE Id=@Id";
                command.Parameters.Add("@Id", DbType.Int32).Value = place.Id;
                command.Parameters.Add("@Name", DbType.String).Value = place.Name;
                command.Parameters.Add("@price", DbType.Decimal).Value = place.Price;
                command.Parameters.Add("@lastVisiting", DbType.String).Value = place.DateOfVisiting;
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            place.Name = nameTextBox.Text;
            place.Price = priceUpDown.Value;
            place.DateOfVisiting = scheduleTextBox.Text;
            EditRoomInfo(place);
            Close();
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить эту комнату?Вместе с ней удалится и гость", "Предупреждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SQLiteConnection connection = new SQLiteConnection("Data Source=Hotel.db;Version=3;"))
                {
                    connection.Open();
                    SQLiteCommand command = new SQLiteCommand(connection);
                    command.CommandText = "Delete from Rooms where Id=@id";
                    command.Parameters.Add("@id", System.Data.DbType.Int32).Value = place.Id;
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                place.Floor.RemovePlace(place);
                
                Close();
            }
            Update();
        }

        private void fireBtn_Click(object sender, EventArgs e)
        {
            place.DateOfVisiting = DateTime.Now.ToString();
            EditRoomInfo(place);
            if (MessageBox.Show("Вы действительно хотите выселить этого гостя?", "Предупреждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SQLiteConnection connection = new SQLiteConnection("Data Source = Hotel.db;Version=3;"))
                {
                    connection.Open();
                    SQLiteCommand command = new SQLiteCommand(connection);
                    command.CommandText = "Delete from Visitors where Id=@id";
                    command.Parameters.Add("@id", System.Data.DbType.Int32).Value = place.Holder.Id;
                    command.ExecuteNonQuery();
                    command.CommandText = $"Update Rooms SET VisitorId=@null WHERE visitorId=@Id";
                    command.Parameters.Add("@id", System.Data.DbType.Int32).Value = place.Holder.Id;
                    command.Parameters.Add("@null", System.Data.DbType.Int32).Value = null;
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                place.Holder = null;
                Close();
            }
        }
    }
}
