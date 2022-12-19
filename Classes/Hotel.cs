using Hotel.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Hotel
{
    public class Hotel
    {
        public int Id { get; private set;}
        public string Name { get; set;}
        public decimal Budget { get; set;}
        public string Description { get; set; }
        public List<Floor> Floors { get; private set; }
        public Panel Panel { get; private set; }


        public Hotel(int Id, string Name, string Description)
        {
            this.Id = Id;
            this.Name = Name;
            this.Description = Description;
            Floors = new List<Floor>();
       
            //Panel
            Panel = new Panel();
            Panel.AutoScroll = true;
            Panel.Dock = DockStyle.Fill;
            
        }

        
       
        public void AddFloor(Floor floor)
        {
            //Добавляем такие методы, так как нет событий для departments.Add
            Panel.Controls.Add(floor.Panel);
            Floors.Add(floor);
            floor.Hotel = this;      
        }

        public void RemoveFloor(Floor floor)
        {
            using (SQLiteConnection connection = new SQLiteConnection("Data Source = Hotel.db;Version=3;"))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(connection);
                command.CommandText = "Delete from Floors where Id=@id";
                command.Parameters.Add("@id", System.Data.DbType.Int32).Value = floor.Id;               
                command.ExecuteNonQuery();
                command.CommandText = "Delete from Rooms where FloorId=@id";
                command.ExecuteNonQuery();
                command.CommandText = "Delete from Visitors where Id=@WorkedId";
                for (int i = 0; i < floor.rooms.Count; i++)
                {
                    if (floor.rooms[i].Holder != null)
                    {
                        command.Parameters.Add("@WorkedId", System.Data.DbType.Int32).Value = floor.rooms[i].Holder.Id;
                        command.ExecuteNonQuery();
                    }
                }
                connection.Close();
            }
            //Добавляем такие методы, так как нет событий для departments.Remove
            Panel.Controls.Remove(floor.Panel);
            Floors.Remove(floor);
            floor.Hotel = null;

        }

        public int GetNextRoomId()
        {
            List<Room> places = new List<Room>();
            Floors.ForEach(x => places.AddRange(x.rooms));
            if (places.Count == 0)
            {
                return 0;
            }
            else
            {
                return places.Max(x => x.Id) + 1;
            }
        }

        public int GetNextVisitorId()
        {
            List<Visitor> visitors = new List<Visitor>();
            List<Room> rooms = new List<Room>();
            Floors.ForEach(x => rooms.AddRange(x.rooms));
            foreach (Room room in rooms)
            {
                if (room.Holder != null)
                {
                    visitors.Add(room.Holder);
                }
            }
            if (visitors.Count == 0)
            {
                return 0;
            }
            else
            {
                return visitors.Max(x => x.Id) + 1;
            }
        }
        public void Resize()
        {
            foreach (var floor in Floors)
            {
                floor.OnPanelSizeChanged();
            }
        }
        public int CheckRoomsCount()
        {
            int count = 0;
            if (this != null)
            {
                foreach (var departments in Floors)
                {
                    foreach (var place in departments.rooms)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
    public enum MoneyType
    {
        Dollar,
        Ruble,
        Euro
    }

