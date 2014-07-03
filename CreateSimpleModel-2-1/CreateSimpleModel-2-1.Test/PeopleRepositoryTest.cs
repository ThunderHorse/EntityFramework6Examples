using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Rhino.Mocks;
using CreateSimpleModel_2_1;

namespace CreateSimpleModel_2_1.Test
{
    [TestFixture]
    public class PeopleRepositoryTest
    {
        private IContextManager _mockContextManager;

        [SetUp]
        public void setup()
        {
            _mockContextManager = MockRepository.GenerateStub<IContextManager>();
        }

        [Test]
        public void FirstTest()
        {
            //TODO: You are here
            //_mockContextManager.Stub()

            using (var peopleRepo = new PeopleRepository(_mockContextManager))
            {
                peopleRepo.AddPeople();
            }
        }
    }
}
