using System;
namespace PersonDataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> li = new List<Person>();
            li.Add(new Person()
            {
                SNN = 1,
                Name = "a",
                Address = "a",
                Age = 18
            });
            li.Add(new Person()
            {
                SNN = 2,
                Name = "b",
                Address = "b",
                Age = 27
            });
            li.Add(new Person()
            {
                SNN = 3,
                Name = "c",
                Address = "c",
                Age = 45
            }); li.Add(new Person()
            {
                SNN = 4,
                Name = "d",
                Address = "d",
                Age = 15
            }); li.Add(new Person()
            {
                SNN = 5,
                Name = "e",
                Address = "e",
                Age = 67
            }); li.Add(new Person()
            {
                SNN = 6,
                Name = "f",
                Address = "f",
                Age = 65
            }); li.Add(new Person()
            {
                SNN = 7,
                Name = "g",
                Address = "g",
                Age = 32
            });
            Operation operation = new Operation();
            operation.RetreiveTopTwoRecords(li);
            operation.RetreiveAgeInBetween(li);
            operation.AverageAge(li);
            operation.RetriveDetailsByName(li);
            operation.SkipAge(li);
            operation.DeletePerson(li);
        }
    }
}