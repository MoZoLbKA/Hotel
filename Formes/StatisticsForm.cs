using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Hotel
{
    public partial class StaticsticsForm : Form
    {
        private decimal maxPrice;
        private decimal minPrice;
        private decimal avgPrice;
        private Hotel hotel;
        private decimal summ;
        private int countWorkers;
        public StaticsticsForm(Hotel company)
        {

            InitializeComponent();
            hotelChart.Series[0].Points[0].SetValueY(10000000);
            this.hotel = company;         
            
        }

        private void EmployersForm_Enter(object sender, EventArgs e)
        {
            
            CheckWorkers();
            hotelChart.Series[0].Points[0].SetValueY(maxPrice);
            hotelChart.Series[1].Points[0].SetValueY(minPrice);
            hotelChart.Series[2].Points[0].SetValueY(avgPrice);
            hotelChart.ChartAreas[0].AxisY.Maximum = (int)minPrice;
            hotelChart.ChartAreas[0].AxisY.Maximum = (int)maxPrice;
            label2.Text = $"Общая сумма цен комнат на данный момент : {summ}Р";
            label3.Text = $"Количество занятых комнат: {countWorkers}";
            label4.Text = $"Средняя цена за комнату: {Math.Round(avgPrice,2)}Р";
            label5.Text = $"Максимальная цена снимаемой комнаты: {maxPrice}Р";
        }
        private void CheckWorkers()
        {
            minPrice = 10000000;
            maxPrice = 0;
            summ=0;
            countWorkers=0;
            foreach (var departament in hotel.Floors)
            {
                if (departament != null)
                {
                    foreach (var worker in departament.rooms)
                    {
                        if (worker.Holder!=null &&worker.infoLabel != null)
                        {
                            summ += worker.Price;
                            countWorkers++;
                            minPrice = Math.Min(worker.Price, minPrice);
                            maxPrice = Math.Max(worker.Price, maxPrice);
                        }
                    }
                }
            }
            if (countWorkers != 0)
            {
                avgPrice=summ/countWorkers;

            }
            else if (countWorkers == 1)
            {
                minPrice = maxPrice;
                avgPrice = minPrice;
            }
            else
            {
                avgPrice = 0;
                minPrice = 0;
                maxPrice = 0;
            }
        }

       
    }
}
