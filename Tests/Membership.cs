using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;

namespace Tests
{
    class Membership
    {
        public dynamic Register(string password, string email, string userName)
        {
            dynamic result = new ExpandoObject();
            result.Success = false;
            return result;
        }
    }
}
