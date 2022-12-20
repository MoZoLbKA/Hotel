using Hotel.Formes;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Hotel
{
    public class Floor
    {
        private const int margin = 6;
        private string name;
        private int lastCountInLine = 0;
        public List<Room> rooms { get;  set; }
        public string lastTimeVisited = DateTime.Now.ToString();
        public Hotel Hotel { get; set; }
        public Panel Panel { get; set; }
        public int Id { get; private set; }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                if (Panel == null)
                {
                    Panel = new Panel();
                    Panel.AutoSize = true;
                    Panel.Size = new Size(0, 300);
                    Panel.BorderStyle = BorderStyle.Fixed3D;
                    Panel.Dock = DockStyle.Top;
                }
                Panel namePanel = Panel.GetChildAtPoint(new Point(0, 0), GetChildAtPointSkip.None) as Panel;
                if (namePanel == null)
                {
                    namePanel = new Panel();
                    namePanel.Size = new Size(0, 23);
                    namePanel.Dock = DockStyle.Top;
                    Panel.Controls.Add(namePanel);

                    IconButton buttonAdd = new IconButton();
                    buttonAdd.BackColor = Color.Chartreuse;
                    buttonAdd.Dock = DockStyle.Right;
                    buttonAdd.FlatAppearance.BorderSize = 0;
                    buttonAdd.FlatStyle = FlatStyle.Flat;
                    buttonAdd.IconChar = IconChar.Plus;
                    buttonAdd.IconColor = Color.Black;
                    buttonAdd.IconFont = IconFont.Auto;
                    buttonAdd.IconSize = 18;
                    buttonAdd.ImageAlign = ContentAlignment.BottomCenter;
                    buttonAdd.Size = new Size(23, 23);
                    buttonAdd.Click += OnAddClick;
                    namePanel.Controls.Add(buttonAdd);
                    namePanel.SizeChanged += OnPanelSizeChanged;
                    namePanel.Font = new Font("Comic Sans MS", 9);

                    IconButton buttonDelete = new IconButton();
                    buttonDelete.BackColor = Color.Red;
                    buttonDelete.Dock = DockStyle.Right;
                    buttonDelete.FlatAppearance.BorderSize = 0;
                    buttonDelete.FlatStyle = FlatStyle.Flat;
                    buttonDelete.IconChar = IconChar.Plus;
                    buttonDelete.IconColor = Color.Black;
                    buttonDelete.IconFont = IconFont.Auto;
                    buttonDelete.IconSize = 19;
                    buttonDelete.ImageAlign = ContentAlignment.BottomCenter;
                    buttonDelete.Rotation = 45D;
                    buttonDelete.Click += OnDeleteClick;
                    buttonDelete.Size = new Size(23, 23);
                    namePanel.Controls.Add(buttonDelete);

                    Label nameLabelCreate = new Label();///TextBOX with 2 events DubleClick and Leave
                    nameLabelCreate.AutoSize = false;
                    nameLabelCreate.Name = "nameLabel";
                    nameLabelCreate.ForeColor = Color.Black;
                    nameLabelCreate.BackColor = Color.FromArgb(255, 192, 192);
                    nameLabelCreate.Location = new Point(0, 0);
                    nameLabelCreate.Size = new Size(23, 23);
                    nameLabelCreate.BorderStyle = BorderStyle.None;
                    nameLabelCreate.TextAlign = ContentAlignment.MiddleCenter;
                    nameLabelCreate.Dock = DockStyle.Fill;
                    nameLabelCreate.Text = value;
                    namePanel.Controls.Add(nameLabelCreate);
                }
                else
                {
                    Control foundControl = namePanel.Controls.Cast<Control>().FirstOrDefault(x => x.Name == "nameLabel");
                    if (foundControl == null || !(foundControl is Label))
                    {
                        Label nameLabel = new Label();
                        nameLabel.AutoSize = false;
                        nameLabel.Font = new Font("Comic Sans MS", 9);
                        nameLabel.Font = new Font("Comic Sans MS", 9);
                        nameLabel.Name = "nameLabel";
                        nameLabel.Location = new Point(0, 0);
                        nameLabel.Size = new Size(23, 23);
                        nameLabel.TextAlign = ContentAlignment.MiddleCenter;
                        nameLabel.BackColor = Color.White;
                        nameLabel.Dock = DockStyle.Fill;
                        namePanel.Controls.Add(nameLabel);
                        nameLabel.Text = value;
                    }
                    else
                    {
                        (foundControl as Label).Text = value;
                    }
                }
                
            }
        }
        public Floor(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
            rooms = new List<Room>();
        }
        public void AddRoom(Room room)
        {
            //Добавляем такие методы, так как нет событий для places.Add
            if (rooms.Count == 0)
            {
                room.Panel.Location = new Point(margin, 23 + margin);
            }
            else
            {
                Room lastPlace = rooms.Last();
                int freeSpace = Panel.Width - margin * 3 - lastPlace.Panel.Location.X - lastPlace.Panel.Width;
                if (freeSpace >= room.Panel.Width)
                {
                    room.Panel.Location = new Point(lastPlace.Panel.Location.X + lastPlace.Panel.Width + margin, lastPlace.Panel.Location.Y);
                }
                else
                {
                    room.Panel.Location = new Point(margin, lastPlace.Panel.Location.Y + lastPlace.Panel.Height + margin);
                }
            }
            if (Panel != null)
            {
                Panel.Controls.Add(room.Panel);
                room.Floor = this;
                rooms.Add(room);
            }
        }
        public void RemovePlace(Room room)
        {
            //Добавляем такие методы, так как нет событий для places.Remove
            if (room.Holder != null)
            {
                using (SQLiteConnection connection = new SQLiteConnection("Data Source = Hotel.db;Version=3;"))
                {
                    connection.Open();
                    SQLiteCommand command = new SQLiteCommand(connection);
                    command.CommandText = "Delete from Visitors where Id=@id";
                    command.Parameters.Add("@id", System.Data.DbType.Int32).Value = room.Holder.Id;
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            Panel.Controls.Remove(room.Panel);
            rooms.Remove(room);
            room.Floor = null;
            RelocatePanels();
        }
        public void OnDeleteClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить этот этаж?", "Предупреждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Hotel.RemoveFloor(this);
                OnPanelSizeChanged();
            }
        }

        public void OnAddClick(object sender, EventArgs e)
        {
            AddNewRoomForm form = new AddNewRoomForm(Hotel);
            if (form.ShowDialog() == DialogResult.OK)
            {
                Room room = form.room;
                using (SQLiteConnection connection = new SQLiteConnection("Data Source = Hotel.db;Version=3;"))
                {
                    connection.Open();
                    SQLiteCommand command = new SQLiteCommand(connection);
                    command.CommandText = $"Insert into Rooms(Id,Name,FloorId,Price,LastVisiting,VisitorId,Count,Type) values(@id,@Name,@floorId,@price,@lastVisiting,@visitorId,@count,@type)";
                    command.Parameters.Add("Id", DbType.Int32).Value = room.Id;
                    command.Parameters.Add("floorId", DbType.Int32).Value = this.Id;
                    command.Parameters.Add("Name", DbType.String).Value = room.Name;
                    command.Parameters.Add("price", DbType.Decimal).Value = 0;
                    command.Parameters.Add("lastVisiting", DbType.String).Value = lastTimeVisited;
                    command.Parameters.Add("visitorId", DbType.Int32).Value = null;
                    command.Parameters.Add("count", DbType.Int32).Value = room.CountOfPlaces;
                    command.Parameters.Add("type", DbType.Int32).Value = room.Type;
                    command.ExecuteNonQuery();
                    connection.Close();

                }
                AddRoom(room);
            }
        }

        public void OnPanelSizeChanged(object sender = null, EventArgs e = null)
        {
            if (rooms.Count == 0)
            {
                return;
            }
            int amountFit = (Panel.Width - margin) / (220 + margin);

            if (amountFit == 0)
            {
                return;
            }
            if (lastCountInLine == amountFit)
            {
                return;
            }
            float lineAmount = (float)rooms.Count / amountFit;
            if (lineAmount % 1 > 0)
            {
                lineAmount++;
            }
            int intLineAmount = (int)lineAmount;
            for (int y = 0; y < intLineAmount; y++)
            {
                for (int x = 0; x < amountFit; x++)
                {
                    int index = amountFit * y + x;
                    if (index >= rooms.Count)
                    {
                        break;
                    }
                    rooms[amountFit * y + x].Panel.Location = new Point(margin + (220 + margin) * x, 23 + margin + (120 + margin) * y);
                }
            }
            lastCountInLine = amountFit;
        }
        public void RelocatePanels()
        {
            if (rooms.Count == 0)
            {
                return;
            }
            int amountFit = (Panel.Width - margin) / (220 + margin);
            float lineAmount = (float)rooms.Count / amountFit;
            if (lineAmount % 1 > 0)
            {
                lineAmount++;
            }
            int intLineAmount = (int)lineAmount;
            for (int y = 0; y < intLineAmount; y++)
            {
                for (int x = 0; x < amountFit; x++)
                {
                    int index = amountFit * y + x;
                    if (index >= rooms.Count)
                    {
                        break;
                    }
                    rooms[amountFit * y + x].Panel.Location = new Point(margin + (220 + margin) * x, 23 + margin + (120 + margin) * y);
                }
            }
        }
    }
}
