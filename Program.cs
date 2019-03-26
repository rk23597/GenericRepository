using GenericRepostiory.Model;
using GenericRepostiory.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepostiory
{
    class Program
    {
        static void Main(string[] args)
        {

           IRepository<worker> worker =new Repository<worker>();
           IRepository<manager> manager =new Repository<manager>();

           Console.WriteLine("-------- Worker Object ------\n");

           List<worker> workerList= worker.Get().ToList();
           workerList.ForEach(i => Console.Write("{0}\n", i.ToString()));

           Console.WriteLine("\n\n-------- Manager Object ------\n");

           List<manager> managerList = manager.Get().ToList();
           managerList.ForEach(i => Console.Write("{0}\n", i.ToString()));
           
            
            Console.Read();



        }
    }
}
