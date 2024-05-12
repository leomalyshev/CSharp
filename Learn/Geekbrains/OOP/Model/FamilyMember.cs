using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class FamilyMember
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Gender Gender { get; set; }
        public FamilyMember Mother { get; set; }
        public FamilyMember Father { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime DayOfDeath { get; set; }


        public override string ToString()
        {
            return $"Имя - {Name}, Фамилия - {Surname}, Дата рождения - {Birthday}";
        }
    }
}
