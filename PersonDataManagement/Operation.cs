using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace PersonDataManagement
{
    internal class Operation
    {
        public void RetreiveTopTwoRecords(List<Person> list)
        {
            var result = list.Where(x => x.Age < 60).Take(2).ToList();
            Display(result);
        }
        public void RetreiveAgeInBetween(List<Person> list)
        {
            var result = list.Where(x => x.Age>13 && x.Age < 18).Take(2).ToList();
            Display(result);
        }
        public void AverageAge(List<Person> list)
        {
            var result = list.Average(x => x.Age);
            Console.WriteLine("the average age is :" + result);
        }
        public void RetriveDetailsByName(List<Person> list)
        {
            Console.WriteLine("ENter your name");
            string name = Console.ReadLine();
            var result = list.Where(x => x.Name == name);
            Display(result.ToList());
        }
        public void SkipAge(List<Person> list)
        {
            var result = list.OrderBy(x=>x.Age).Skip(list.Count(x => x.Age < 60));
            Display(result.ToList());
        }
        public void DeletePerson(List<Person> list)
        {
            Console.WriteLine("ENter your name");
            string name = Console.ReadLine();
            var result = list.Find(x=>x.Name==name);
            list.Remove(result);
            Display(list);
        }

        private void Display(List<Person> result)
        {
            foreach (var item in result)
            {
                Console.WriteLine(item.Name+" | " +item.Address+ " | "+item.Age );
            }
        }
    }
}