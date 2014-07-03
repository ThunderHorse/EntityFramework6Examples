using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateSimpleModel_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Only call if no entries in db yet.
             * In later lessons we will first check the db context
             * to see if the record exist 
            */
            //PeopleRepository.AddPeople();

            var _contextManager = new ContextManager();

            using (var peopleRepo = new PeopleRepository(_contextManager))
            {
                peopleRepo.OutputPeople();
            }
        }
    }
}
