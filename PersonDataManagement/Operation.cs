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

        private void Display(List<Person> result)
        {
            foreach (var item in result)
            {
                Console.WriteLine(item.Name+" | " +item.Address+ " | "+item.Age );
            }
        }
    }
}