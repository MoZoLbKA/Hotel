using Hotel.Formes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Globalization;

namespace Hotel
{
    public partial class MainForm : Form
    {       
        List<Form> openForms;      
        delegate void ChangeOpacity();
        Form currentForm;
        Button currentButton;
        
        public Hotel Hotel { get; private set; }
        public MainForm()
        {         
            LoadFromSql();//test           
            InitializeComponent();
            openForms = new List<Form>()
            {
                new MyHotelForm(Hotel),
                new StaticsticsForm(Hotel),
                new SettingForm(Hotel,myHospitalButton)
            };
        }
        private void LoadFromSql()
        {
            List<Visitor> visitors = new List<Visitor>();
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=Hotel.db;Version=3;"))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(connection);
                command.CommandText = "SELECT * FROM Settings";

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    reader.Read();
                    string name = reader.GetString(1);
                    reader.Read();
                    string description = reader.GetString(1);
                    Hotel = new Hotel(1, name, description);
                    
                }                                           
                command.CommandText = "SELECT * FROM Floors";
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows) 
                    {
                        while (reader.Read())
                        {
                            int id = int.Parse(reader[0].ToString());
                            string name = (string)reader[1];
                            Hotel.AddFloor(new Floor(id, name));
                        }
                    }
                }
                command.CommandText = "SELECT * FROM Visitors";
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int id = int.Parse(reader[0].ToString());
                            string name = (string)reader[1];
                            int sex = int.Parse(reader[2].ToString());
                            int age = int.Parse(reader[3].ToString());
                            DateTime lastVisiting = DateTime.ParseExact(reader[4].ToString(),
                                "dd.MM.yyyy H:mm:ss", CultureInfo.InvariantCulture);
                            double pasport = double.Parse(reader[5].ToString().Replace('.',','));
                            visitors.Add(new Visitor(id, name, age, (Sex)sex, lastVisiting,pasport));
                        }
                    }
                }
                command.CommandText = "SELECT * FROM Rooms";
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {                        
                        while (reader.Read())
                        {
                            int id = int.Parse(reader[0].ToString());
                            string name = (reader[1].ToString());
                            int floorId = int.Parse(reader[2].ToString());
                            decimal price = decimal.Parse(reader[3].ToString());
                            string lastVisiting = reader[4].ToString();
                            int visitorId;
                            int count = int.Parse(reader[6].ToString());
                            
                            if (int.TryParse(reader[5].ToString(),out visitorId))
                            {
                                foreach (var Floor in Hotel.Floors)
                                {
                                    if (Floor.Id == floorId) 
                                    { 
                                        foreach (var item in visitors)
                                        {
                                            if(item.Id == visitorId)
                                            {
                                                Floor.AddRoom(new Room(id, name, item, price, lastVisiting,count)); //
                                                break;
                                            }
                                        }
                                    }
                                }                 
                            }
                            else
                            {
                                foreach (var depart in Hotel.Floors)
                                {
                                    if (depart.Id == floorId)
                                    {
                                        depart.AddRoom(new Room(id, name,null, price, lastVisiting,count)); //
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
                connection.Close();
            }
        }       
        
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            AddOpacity(null);
            currentForm = openForms[0];
            SetActiveButton(myHospitalButton);
            SetCurrentForm(openForms[0], myHospitalButton,true);                        
        }
        private void SetCurrentForm(Form form, object sender, bool check = false)
        {
            if (form != currentForm || check)
            {               
                currentForm.Hide();
                currentForm.Visible = false;
                mainPanel.Controls.Remove(currentForm);
                currentForm = form;
                currentForm.TopLevel = false;
                currentForm.Dock = DockStyle.Fill;
                currentForm.FormBorderStyle = FormBorderStyle.None;
                mainPanel.Controls.Add(currentForm);
                currentForm.BringToFront();
                AddOpacity(null);            
                SetActiveButton(sender);
                currentForm.Show();
                currentForm.Name = form.Name;
            }
        }
        private void myCompanyButton_Click(object sender, EventArgs e)
        {
            SetCurrentForm(openForms[0],sender);                   
        }

        private void workersButton_Click(object sender, EventArgs e)
        {
            SetCurrentForm(openForms[1],sender);                           
        }
        private void SetActiveButton(object sender)
        {
            if (currentButton != null)
            {
                SetDisableButton();
            }
            currentButton = sender as Button;         
            currentButton.Font = new Font(currentButton.Font.FontFamily, currentButton.Font.Size + 3);
            currentButton.ForeColor = Color.White;                      
        }
        private void SetDisableButton()
        {           
            currentButton.Font = new Font(currentButton.Font.FontFamily, currentButton.Font.Size - 3);
            currentButton.ForeColor = Color.Black;
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            SetCurrentForm(openForms[2], sender);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            ChangeOpacity change = new ChangeOpacity(Close);           
            DeleteOpacity(change);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void windowMaximizeButton_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                SetCurrentForm(currentForm, currentButton,true);               
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                SetCurrentForm(currentForm, currentButton, true);
            }
        }
        
        private void AddOpacity(ChangeOpacity method)
        {
            Opacity = 0.01;
            Timer timer = new Timer();
            timer.Tick += new EventHandler((sender1, e1) =>
            {
                if ((Opacity += 0.04) >= 1)
                {
                    timer.Stop();
                    if (method != null)
                        method();
                }
                
            });
            timer.Interval = 1;
            timer.Start();
        }
        private void DeleteOpacity(ChangeOpacity method)
        {
            Opacity = 1;
            Timer timer2 = new Timer();
            timer2.Tick += new EventHandler((sender2, e2) =>
            {
                if ((Opacity -= 0.05d) <= 0)
                {
                    timer2.Stop();
                    if (method != null)
                        method();
                }
            });
            timer2.Interval = 1;
            timer2.Start();
        }
        private  void windowMinimizeButton_Click(object sender, EventArgs e)
        {           
            ChangeOpacity change=new ChangeOpacity(ChangeToMinimize);
            void ChangeToMinimize() => WindowState = FormWindowState.Minimized;
            DeleteOpacity(change);                 
        }       
        private void MainForm_Activated(object sender, EventArgs e)
        {
            if (mainPanel.Width == 0 || mainPanel.Height == 0)
            {
                AddOpacity(null);               
            }
        }

        
    }
}
