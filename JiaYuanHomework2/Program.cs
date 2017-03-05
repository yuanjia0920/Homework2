using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiaYuanHomework2
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new List<User>();

            users.Add(new User { Name = "Dave", Password = "hello" });
            users.Add(new User { Name = "Steve", Password = "steve" });
            users.Add(new User { Name = "Lisa", Password = "hello" });
            
            users.Where(user => user.Password == "hello").ToList().ForEach(user => Console.WriteLine(user.Name));
            users.RemoveAll(user => user.Name.ToLower() == user.Password);
            users.Remove(users.FirstOrDefault(user => user.Password == "hello"));
            users.ForEach(x => { Console.WriteLine("Name={0}, Password={1}", x.Name, x.Password); });
                       
            Console.ReadLine();
        }
    }
}
