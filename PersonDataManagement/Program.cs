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
                Age = 18
            });
            li.Add(new Person()
            {
                SNN = 3,
                Name = "c",
                Address = "c",
                Age = 18
            });
            Operation operation = new Operation();
            operation.RetreiveTopTwoRecords(li);
        }
    }
}