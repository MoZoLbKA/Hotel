using Hotel.Formes;
using FontAwesome.Sharp;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Hotel.Classes;

namespace Hotel
{
    public partial class MyHotelForm : Form
    {            
        public Hotel company { get; private set; }    
        public MyHotelForm(Hotel company)
        {          
            InitializeComponent();   
            this.company = company;
            mainPanel.Controls.Add(company.Panel);               
        }           
        private void findTextBox_TextChanged(object sender, EventArgs e)
        {
            if((sender as TextBox).Text.Equals(""))
            {
                foreach (var departments in company.Floors)
                {
                    foreach (var worker in departments.rooms)
                    {
                        if (worker.infoLabel != null)
                        {
                            worker.ChangeColorForControl(worker.infoLabel, Color.FromArgb(255, 192, 192));
                        }
                    }
                }
            }
            else
            {
                CheckAllWorkers(company);
            }
            
        }
        private void CheckAllWorkers(Hotel company)
        {
            if (company != null)
            {
                foreach (var departments in company.Floors)
                {
                    foreach (var worker in departments.rooms)
                    {
                        if (worker.infoLabel != null)
                        {
                            if (worker.Holder.Name.ToLower().Contains(findTextBox.Text.ToLower()))
                            {
                                worker.ChangeColorForControl(worker.infoLabel, Color.Lime);
                            }
                            else
                            {
                                worker.ChangeColorForControl(worker.infoLabel, Color.FromArgb(255, 192, 192));
                            }
                        }
                    }
                }
            }
        }
        
        private void btnAddNewChapter_Click(object sender, EventArgs e)
        {
            FloorForm chapter = new FloorForm(company);
            if (chapter.ShowDialog()==DialogResult.OK)
            {
                Floor department;
                if (company.Floors.Count == 0)
                {
                    department= new Floor(1,chapter.FloorName);
                }
                else
                {
                    department = new Floor(company.Floors.Last().Id+1, chapter.FloorName);
                }
                company.AddFloor(department);

            }
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            
            if (moneyCheckBox.Checked)
            {
               
                foreach (  Floor dep in company.Floors)
                {
                    dep.rooms = dep.rooms.OrderByDescending(x => x, new PriceComparer()).ToList();
                    dep.RelocatePanels();
                }     
            }
             else if  (alhaCheckBox.Checked)
            {
                foreach( Floor dep in company.Floors)
                {
                    dep.rooms = dep.rooms.OrderByDescending(x=>x.Holder, new HolderComparer()).ToList();
                    dep.RelocatePanels();
                }
            }
             else if  (experianseCheckBox.Checked)
            {
                foreach(Floor dep in company.Floors)
                {
                    dep.rooms = dep.rooms.OrderByDescending(x => x.Holder, new YearsComparer()).ToList();
                    dep.RelocatePanels();
                }
            }    
        }
    }
    
}
