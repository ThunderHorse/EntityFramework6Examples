using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateSimpleModel_2_1
{
    public class PeopleRepository : IDisposable
    {
        private IContextManager _contextManager;

        public PeopleRepository()
        {
            _contextManager = new ContextManager();
        }

        internal PeopleRepository(IContextManager contextManager)
        {
            _contextManager = contextManager;
        }

        internal void AddPeople()
        {
            using (var context = _contextManager.GetContextManager())
            {
                var person = new Person
                {
                    FirstName = "Robert",
                    MiddleName = "Allen",
                    LastName = "Doe",
                    PhoneNumber = "867-5309"
                };

                context.People.Add(person);

                person = new Person
                {
                    FirstName = "John",
                    MiddleName = "K.",
                    LastName = "Smith",
                    PhoneNumber = "824-3031"
                };

                context.People.Add(person);

                person = new Person
                {
                    FirstName = "Billy",
                    MiddleName = "Albert",
                    LastName = "Minor",
                    PhoneNumber = "907-2212"
                };

                context.People.Add(person);

                person = new Person
                {
                    FirstName = "Kathy",
                    MiddleName = "Anne",
                    LastName = "Ryan",
                    PhoneNumber = "722-0038"
                };

                context.People.Add(person);

                context.SaveChanges();
            }
        }

        internal void OutputPeople()
        {
            using (var context = _contextManager.GetContextManager())
            {
                foreach (var person in context.People)
                {
                    Console.WriteLine("{0} {1} {2}, Phone: {3}",
                        person.FirstName,
                        person.MiddleName,
                        person.LastName,
                        person.PhoneNumber);
                }
            }

            Console.Read();
        }

        public void Dispose()
        {
            //Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
