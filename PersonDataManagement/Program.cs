using System;
namespace PersonDataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            list.Add(new Person()
            {
                SNN = 1,
                Name = "a",
                Address = "a",
                Age = 18
            });
            list.Add(new Person()
            {
                SNN = 2,
                Name = "b",
                Address = "b",
                Age = 18
            });
            list.Add(new Person()
            {
                SNN = 3,
                Name = "c",
                Address = "c",
                Age = 18
            });
        }
    }
}