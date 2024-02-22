using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP;

namespace OOP.Model.Service
{
    internal class Service
    {
        public List<FamilyMember> Family { get; set; }
        private List<FamilyMember> FamilyMembers { get; set; } = new List<FamilyMember>();

        public Service()
        {
            this.Family = new List<FamilyMember>();
        }

        public void AddPerson(params FamilyMember[] member)
        {
            Family.AddRange(member);
        }

        public List<FamilyMember> GetGrandFather(FamilyMember familyMember)
        {
            List<FamilyMember> grandFathers = new List<FamilyMember>();
            grandFathers.Add(familyMember.Father.Father);
            grandFathers.Add(familyMember.Mother.Father);

            return grandFathers;
        }

        public List<FamilyMember> GetGrandMother(FamilyMember familyMember)
        {
            List<FamilyMember> grandMother = new List<FamilyMember>();

            grandMother.Add(familyMember.Father.Mother);
            grandMother.Add(familyMember.Mother.Mother);

            return grandMother;
        }

        public FamilyMember FindOldestFamilyMember(FamilyMember familyMember)
        {
            var old = Family.Min(x => x.Birthday);
            return Family.FirstOrDefault(x => x.Birthday == old);
        }

        public List<FamilyMember> GetChild(FamilyMember familyMember)
        {
            return null;
        }
    }

    
}
