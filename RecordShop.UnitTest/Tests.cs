

namespace RecordShop.UnitTest
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using NUnit.Framework;
    using Moq;
    using RecordShop.Web;
    using RecordShop.Domain;

    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            ViewModelMapper mapper = new ViewModelMapper();
            Person p1 = new Person();
            p1.FirstName = "Fred";
            p1.LastName = "Flintstone";
            p1.UserName = "Freddy";
            p1.EmailAddress = "fred@bedrock.com";

            PersonViewModel p2 = new PersonViewModel();

            mapper.Map<Person, PersonViewModel>(p1, p2);

        }
    }
}
