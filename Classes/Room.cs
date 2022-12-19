using Hotel.Formes;
using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Collections.Generic;

using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;

namespace Hotel
{
    public class Room
    {
        private string name;
        private Visitor holder;
        private decimal price;
        private string dateOfVisiting;
        public int CountOfPlaces { get; private set; }//

        public Floor Floor { get; set; }
        public Panel Panel { get; private set; }
        public  Label infoLabel { get; private set; }

        public int Id { get; private set; }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value!= null && value.Length > 18)
                {
                    MessageBox.Show("Превышен максимальный лимит символов(18)", "Предупреждение");
                }
                else
                {
                    name = value;
                    
                    if (Panel == null)
                    {
                        Panel = new Panel();
                        Panel.BorderStyle = BorderStyle.FixedSingle;
                        Panel.Location = new Point(12, 12);
                        Panel.Size = new Size(220, 120);
                    }
                    Label nameLabel = Panel.GetChildAtPoint(new Point(0, 0), GetChildAtPointSkip.None) as Label;
                    if (nameLabel == null)
                    {
                        nameLabel = new Label();
                        nameLabel.TextAlign = ContentAlignment.MiddleCenter;
                        nameLabel.AutoSize = false;
                        nameLabel.BorderStyle = BorderStyle.FixedSingle;
                        
                        nameLabel.ForeColor = Color.Black;
                        nameLabel.BackColor = Color.FromArgb(255, 192, 192);                       
                        nameLabel.Font = new Font("Comic Sans MS", 7);
                        nameLabel.Location = new Point(0, 0);
                        nameLabel.Size = new Size(140, 23);
                        nameLabel.Tag = this;
                        nameLabel.DoubleClick += ShowInfo;
                        Panel.Controls.Add(nameLabel);
                    }
                    nameLabel.Text = value;
                }
            }
        }
        public Visitor Holder
        {
            get
            {
                return holder;
            }
            set
            {
                holder = value;
                if (Panel == null)
                {
                    Panel = new Panel();
                    Panel.BorderStyle = BorderStyle.FixedSingle;
                    Panel.Location = new Point(12, 12);
                    Panel.Size = new Size(220, 120);
                }

                Label occupiedInfo = Panel.GetChildAtPoint(new Point(140, 0), GetChildAtPointSkip.None) as Label;
                if (occupiedInfo == null)
                {
                    occupiedInfo = new Label();
                    occupiedInfo.TextAlign = ContentAlignment.MiddleCenter;
                    occupiedInfo.AutoSize = false;
                    
                    occupiedInfo.BackColor = Color.Green;
                    occupiedInfo.Font = new Font("Comic Sans MS",8);
                    occupiedInfo.Location = new Point(140, 0);
                    occupiedInfo.Size = new Size(80, 23);
                    occupiedInfo.Tag = this;
                    occupiedInfo.DoubleClick += ShowInfo;
                    Panel.Controls.Add(occupiedInfo);
                }

                if (holder == null)
                {
                    occupiedInfo.BackColor = Color.Lime;
                    occupiedInfo.Text = "Не занято";
                    Control deleteInfo = Panel.GetChildAtPoint(new Point(0, 23), GetChildAtPointSkip.None);
                    if (deleteInfo != null)
                    {
                        Panel.Controls.Remove(deleteInfo);
                    }
                    IconButton button = new IconButton();
                    button.Location = new Point(0, 23);
                    button.Size = new Size(220, 95);
                    button.Font = new Font("Comic Sans MS", 16);
                    
                    button.Text = "Добавить гостя";
                    button.IconChar = IconChar.PlusCircle;
                    button.IconColor = Color.Black;
                    button.IconFont = IconFont.Auto;
                    button.IconSize = 60;
                    button.TextAlign = ContentAlignment.TopRight;
                    button.TextImageRelation = TextImageRelation.ImageBeforeText;
                    button.BackColor = Color.FromArgb(255, 192, 192);
                    button.ForeColor = Color.Black;
                    button.FlatAppearance.BorderSize = 0;
                    button.FlatStyle = FlatStyle.Flat;
                    button.Tag = this;
                    button.Click += OnAddClick;
                    Panel.Controls.Add(button);
                }
                else
                {
                    occupiedInfo.Text = "Занято";
                    occupiedInfo.BackColor = Color.Red;
                    Control deleteBtn = Panel.GetChildAtPoint(new Point(0, 23), GetChildAtPointSkip.None);
                    if (deleteBtn != null)
                    {
                        Panel.Controls.Remove(deleteBtn);
                    }
                    infoLabel = new Label();
                    infoLabel.Text = $"ФИО: {holder.Name}\nВозраст: {holder.Years}\nПосещение:{dateOfVisiting}\nЦена:{price}₽";
                    infoLabel.Location = new Point(0, 23);
                    infoLabel.ForeColor = Color.Black;
                    infoLabel.BackColor = Color.FromArgb(255, 192, 192);
                    infoLabel.Size = new Size(220, 95);
                    infoLabel.Tag = this;
                    infoLabel.DoubleClick += ShowInfo;
                    Panel.Controls.Add(infoLabel);
                }
            }
        }
        public void ChangeColorForControl(Control control,Color color)
        {
            control.BackColor = color;
        }
        public void ChangeColorToDefault(Control control)
        {
            control.BackColor = Color.FromArgb(255, 192, 192);
        }
        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                if (Panel == null)
                {
                    Panel = new Panel();
                    
                    Panel.BorderStyle = BorderStyle.FixedSingle;
                    Panel.Location = new Point(12, 12);
                    Panel.Size = new Size(220, 120);
                }
                price = value;
                if (holder != null)
                {
                    Label infoLabel = Panel.GetChildAtPoint(new Point(0, 23), GetChildAtPointSkip.None) as Label;
                    if (infoLabel == null)
                    {
                        infoLabel = new Label();
                        infoLabel.Text = $"ФИО: {holder.Name}\nВозраст: {holder.Years}\nПосещение:{dateOfVisiting}\nЦена:{price}₽";
                        infoLabel.Location = new Point(0, 23);
                        infoLabel.BackColor = Color.FromArgb(255, 192, 192);
                        infoLabel.Size = new Size(220, 95);
                        infoLabel.Tag = this;
                        infoLabel.DoubleClick += ShowInfo;
                        Panel.Controls.Add(infoLabel);
                    }
                    else
                    {
                        infoLabel.Text = $"ФИО: {holder.Name}\nВозраст: {holder.Years}\nПосещение:{dateOfVisiting}\nЦена:{price}₽";
                    }
                }
            }
        }
        public string DateOfVisiting
        {
            get
            {
                return dateOfVisiting;
            }
            set
            {
                dateOfVisiting = value;
                if (Panel == null)
                {
                    Panel = new Panel();
                    
                    Panel.BorderStyle = BorderStyle.FixedSingle;
                    Panel.Location = new Point(12, 12);
                    Panel.Size = new Size(220, 120);
                }
                if (holder != null)
                {
                    Label infoLabel = Panel.GetChildAtPoint(new Point(0, 23), GetChildAtPointSkip.None) as Label;
                    if (infoLabel == null)
                    {
                        infoLabel = new Label();
                        infoLabel.Text = $"ФИО: {holder.Name}\nВозраст: {holder.Years}\nПосещение:{dateOfVisiting}\nЦена:{price}₽";
                        infoLabel.Location = new Point(0, 23);
                        
                        infoLabel.Size = new Size(220, 95);
                        infoLabel.Tag = this;
                        infoLabel.DoubleClick += ShowInfo;
                        Panel.Controls.Add(infoLabel);
                    }
                    else
                    {
                        infoLabel.Text = $"ФИО: {holder.Name}\nВозраст: {holder.Years}\nПосещение:{dateOfVisiting}\nЦена:{price}₽";
                    }
                }
            }
        }
        
        public Room(int Id, string Name, Visitor Holder, decimal price, string lastVisiting,int count)
        {
            this.Id = Id;
            this.Name = Name;
            this.Holder = Holder;
            this.Price = price;
            this.DateOfVisiting = lastVisiting;
            CountOfPlaces = count;
        }
        private static void ShowInfo(object sender, EventArgs e)
        {
            Control senderControl = sender as Control;
            if (senderControl == null)
            {
                return;
            }
            Room place = senderControl.Tag as Room;
            if (place == null)
            {
                return;
            }
            new EditRoom(place).ShowDialog();
        }
        //
        private  void OnAddClick(object sender, EventArgs e)
        {
            Control senderControl = sender as Control;
            if (senderControl == null)
            {
                return;
            }
            Room place = senderControl.Tag as Room;
            if (place == null)
            {
                return;
            }
            
            AddNewVisitorForm form = new AddNewVisitorForm(place);
            form.ShowDialog();
            if (form.Selected == null)
            {                
                return;
            }
            place.Holder = form.Selected;
            dateOfVisiting = form.Selected.DateOfVisit.ToString();
            using (SQLiteConnection connection = new SQLiteConnection("Data Source = Hotel.db;Version=3;"))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(connection);
                command.CommandText = $"Insert into Visitors(Id,FullName,Sex,Age,LastVisiting,Pasport) values(@Id,@Name,@Sex,@Years,@LastVisiting,@Pasport)";
                command.Parameters.Add("@Id", DbType.Int32).Value = place.Holder.Id;
                command.Parameters.Add("@Name", DbType.String).Value = form.Selected.Name;
                command.Parameters.Add("@Sex", DbType.Int32).Value = (int)form.Selected.Sex;
                command.Parameters.Add("@Years", DbType.Int32).Value = form.Selected.Years;
                command.Parameters.Add("@LastVisiting", DbType.DateTime).Value = form.Selected.DateOfVisit;
                command.Parameters.Add("@Pasport", DbType.Double).Value = form.Selected.Passport;
                command.ExecuteNonQuery();
                command.CommandText = "UPDATE Rooms SET VisitorId=@VisitId where Id=@Id";
                command.Parameters.Add("@Id", DbType.Int32).Value = place.Id;
                command.Parameters.Add("@VisitId", DbType.Int32).Value = place.Holder.Id;
                command.ExecuteNonQuery();
                connection.Close();
            }
            EditRoom.EditRoomInfo(place);
        }
    }
}
