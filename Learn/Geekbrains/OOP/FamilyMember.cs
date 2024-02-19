using OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;

namespace OOP
{
    public enum Gender { male, female }
    public class FamilyMember
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public FamilyMember Mother { get; set; }
        public FamilyMember Father { get; set; }
        public FamilyMember? MarriedFamilyMember { get; set; }
        public Gender Sex { get; set; }
        void Info(int indent = 0)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{new String('-', indent)} Имя {this.Name}") ;

            if (MarriedFamilyMember != null)
            {
                sb.Append(MarriedFamilyMember.Sex == Gender.female
                    ? $", Жена - {MarriedFamilyMember.Name}"
                    : $", Муж - {MarriedFamilyMember.Name}");
            }
            Console.WriteLine(sb.ToString());


        }

        public virtual void Print(int indent = 0)
        {
            Info(indent);
        }

    }

    public class AdultFamilyMember : FamilyMember
    {
        public FamilyMember[] Children { get; set; }

        public override void Print(int indent = 0)
        {
            base.Print(indent);

            foreach (FamilyMember child in Children)
            {
                child.Print(indent * 2);
            }
        }
    }
}
