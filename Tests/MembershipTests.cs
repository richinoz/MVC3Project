using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MVC3ProjectShare.Controllers;
using MVC3ProjectShare.Models;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class MembershipTests
    {        
        [Test]
        public void valid_email_and_password_should_register_successfully()
        {
            var membership = new Membership();

            var result = membership.Register("password","test@test.com", "test");

            Assert.False(result.Success);
            
        }
    }
}
