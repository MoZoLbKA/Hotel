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
    public partial class AddNewVisitorForm : Form
    {
        public Visitor Selected { get; private set; }
        private Room place;
        public AddNewVisitorForm(Room place)
        {
            InitializeComponent();
            this.place = place;
            infoLabel.Text = $"Количество спальных мест : {place.CountOfPlaces} \nЦена: {place.Price}\nТип комнаты:{place.Type}";
            
        }       
        private void SelectBtn_Click(object sender, EventArgs e)
        {
            
            string name = nameTextBox.Text;
            int age;
            double pasport;
            if (!double.TryParse(idTextBox.Text, out pasport))
            {
                MessageBox.Show("Данные паспорта в таком формате: 'серия, паспорт'", "Предупреждение");
                return;
            }
            if (!int.TryParse(ageTextBox.Text,out age))
            {
                MessageBox.Show("Неккоректно введен возраст", "Предупреждение");
                return;
            }
            Sex sex;
            if (maleRadioButton.Checked)
                sex = Sex.Male;
            else if (femaleRadioButton.Checked)
                sex = Sex.Female;
            else 
            { 
                MessageBox.Show("Не указан пол гостя", "Предупреждение");
                return;
            }
            Selected = new Visitor(place.Floor.Hotel.GetNextVisitorId(), name, age, sex, DateTime.Now,pasport);
            Close();

        }
    }
}
