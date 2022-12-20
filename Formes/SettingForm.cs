using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Hotel.Formes
{
    public partial class SettingForm : Form
    {
        public Hotel Company { get; private set; }           
        private readonly Button button;
        public SettingForm()
        {
            InitializeComponent();
        }
        public SettingForm(Hotel company,Button button)
        {
            InitializeComponent();           
            this.button = button;
            Company = company;
            button.Text = Company.Name.ToUpper();
        }
        private void SettingForm_Load(object sender, EventArgs e)
        {
            Company = Company;
            nameTextBox.Text = Company.Name;
            descriptionTextBox.Text = Company.Description;
        }
        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Length == 0)
            {
                MessageBox.Show("Ваше название не может быть пустым!", "Предупреждение!");
            }
            else
            {
                button.Text = nameTextBox.Text.Replace('\n', ' ').ToUpper();
                using (SQLiteConnection connection = new SQLiteConnection("Data Source = Hotel.db;Version=3;"))
                {
                    connection.Open();
                    SQLiteCommand command = new SQLiteCommand(connection);                    
                    command.CommandText = "UPDATE Settings SET Value=@Name where Name=@NameId";
                    command.Parameters.Add("@Name", DbType.String).Value = nameTextBox.Text;
                    command.Parameters.Add("@NameId", DbType.String).Value = "Name";
                    command.ExecuteNonQuery();
                    command.Parameters.Add("@Name", DbType.String).Value = descriptionTextBox.Text;
                    command.Parameters.Add("@NameId", DbType.String).Value = "Description";
                    command.ExecuteNonQuery();
                    connection.Close();

                }
            }

        }

       
    }
}
