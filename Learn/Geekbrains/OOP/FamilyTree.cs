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
    public class FamilyTree
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public FamilyTree Mother { get; set; }
        public FamilyTree Father { get; set; }
        public FamilyTree? MarriedFamilyMember { get; set; }
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

    public class AdultFamilyMember : FamilyTree
    {
        public FamilyTree[] Children { get; set; }

        public override void Print(int indent = 0)
        {
            base.Print(indent);

            foreach (FamilyTree child in Children)
            {
                child.Print(indent * 2);
            }
        }
    }
}
