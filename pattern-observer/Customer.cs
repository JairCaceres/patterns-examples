using pattern_observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_observer
{
    public class Customer : IObserver
    {
        private string _name;
        private string _email;

        public Customer(string name, string email)
        {
            _name = name;
            _email = email;
        }

        public void Update(string promotion)
        {
            Console.WriteLine($"Sending email to {_name} at {_email}: New promotion: {promotion}");
        }
    }
}
