using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace W3TestApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class Service1 : ITestContract
    {
        int counter = 0;

        List<User> users = new List<User>()
        {
            new User(){ Id=0, Name = "Bob", Description="First test user" },
            new User(){ Id=1, Name = "Tom", Description="Second test user"},
            new User(){ Id=2, Name = "Sandra", Description="Third test user"}
        };

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public User GetNumberOfExecutionTimes(int id)
        {
            foreach (User u in users)
            {
                if (u.Id == id)
                {
                    u.Count++;
                    return u;
                }
            }

            return null;
        }
    }
}
