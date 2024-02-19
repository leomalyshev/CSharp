namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AdultFamilyMember grandFather = new AdultFamilyMember() { Mother = null, Name = "Боб" };
            
            AdultFamilyMember mother = new AdultFamilyMember() { Father = grandFather, Mother = null, Name = "Юлия", Sex = Gender.female};
            AdultFamilyMember father = new AdultFamilyMember() { Father = grandFather, Mother = null, Name = "Сергей", Sex = Gender.male};
            
            FamilyMember son1 = new FamilyMember() { Mother = mother, Father = father, Name = "Василий" };
            FamilyMember son2 = new FamilyMember() { Mother = mother, Father = father, Name = "Илья" };
            FamilyMember son3 = new FamilyMember() { Mother = mother, Father = father, Name = "Артём" };

            grandFather.Children = new FamilyMember[] { father, mother };
            mother.Children = new FamilyMember[] { son1, son2, son3 };
            father.Children = new FamilyMember[] { son1, son2, son3 };

            mother.MarriedFamilyMember = father;
            father.MarriedFamilyMember = mother;

            grandFather.Print(2);
            Console.ReadLine();
        }
    }
}
