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
    public partial class FloorForm : Form
    {
        public string FloorName { get; private set; }
        private Hotel company;       
        public FloorForm(Hotel company)
        {           
            InitializeComponent();
            this.company = company;
            btnAddChapter.DialogResult = DialogResult.OK;
        }
        private void btnAddChapter_Click(object sender, EventArgs e)
        {
            FloorName = tbChapter.Text;
            using (SQLiteConnection connection = new SQLiteConnection("Data Source = Hotel.db;Version=3;"))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(connection);
                command.CommandText = $"Insert into Floors(Name) values(@Name)";              
                command.Parameters.Add("Name", DbType.String).Value = FloorName;
                command.ExecuteNonQuery();
                connection.Close();

            }
        }
    }
}
