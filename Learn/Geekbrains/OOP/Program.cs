using OOP.Model.Service;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var grandMother1 = new FamilyMember()
            {
                Name = "Мария",
                Surname = "Иванова",
                Birthday = new DateTime(1975, 8, 17),
                Gender = Gender.male
            };
            var grandFather1 = new FamilyMember()
            {
                Name = "Алексей",
                Surname = "Иванов",
                Birthday = new DateTime(1973, 5, 23),
                Gender = Gender.male
            };
            var grandMother2 = new FamilyMember()
            {
                Name = "Ольга",
                Surname = "Петрова",
                Birthday = new DateTime(1976, 8, 11),
                Gender = Gender.male
            };
            var grandFather2 = new FamilyMember()
            {
                Name = "Даниил",
                Surname = "Петров",
                Birthday = new DateTime(1972, 6, 12),
                Gender = Gender.male
            };
            var father = new FamilyMember() { 
                Name = "Иван", 
                Surname = "Иванов", 
                Birthday = new DateTime(1993, 5, 2),
                Gender = Gender.male,
                Mother = grandMother1,
                Father = grandFather1
            };
            var mother = new FamilyMember()
            {
                Name = "Дарья",
                Surname = "Иванова",
                Birthday = new DateTime(1995, 6, 2),
                Gender = Gender.female,
                Mother = grandMother2,
                Father = grandFather2
            };
            var child1 = new FamilyMember()
            {
                Name = "Михаил",
                Surname = "Иванов",
                Birthday = new DateTime(2005, 6, 3),
                Gender = Gender.male,
                Mother = mother,
                Father = father
            };
            var child2 = new FamilyMember()
            {
                Name = "Дарья",
                Surname = "Иванова",
                Birthday = new DateTime(2006, 8, 3),
                Gender = Gender.female,
                Mother = mother,
                Father = father
            };

            var service = new Service();
            service.AddPerson(
                grandFather1, 
                grandFather2, 
                grandMother1, 
                grandMother2,
                father,
                mother,
                child1,
                child2);

            var grandFathers = service.GetGrandFather(child2);
            foreach (var grandFather in grandFathers)
            {
                Console.WriteLine(grandFather);
            }

            Console.WriteLine(service.FindOldestFamilyMember(child2));
        }
    }
}
