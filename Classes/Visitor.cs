using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class Visitor
    {
        public double Passport { get; private set; }
        public int Id { get; private set; }
        public string Name { get; set; }
        public int Years { get; set; }
        public Sex Sex { get; set; }
        public DateTime DateOfVisit { get; set; }
        public Visitor(int Id, string Name, int Years, Sex Sex, DateTime dateOfVisit,double passport)
        {
            this.Id = Id;
            this.Name = Name;
            this.Years = Years;
            this.Sex = Sex;
            DateOfVisit = dateOfVisit;
            Passport = passport;

        }
        public override string ToString() => $"ФИО: {Name}|Возраст : {Years} лет|Пол: {Sex}|Дата засел.: {DateOfVisit.ToString("dd.MM.yyyy")}";
    }
    public enum Sex
    {
        Male, Female
    }
}
