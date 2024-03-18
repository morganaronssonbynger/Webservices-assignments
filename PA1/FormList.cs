using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA1
{
    static class FormList
    {
        private static Customer customerForm = new Customer();
        private static Account accountForm = new Account();

        public static Customer CustomerForm { get => customerForm; set => customerForm = value; }
        public static Account AccountForm { get => accountForm; set => accountForm = value; }
    }
}
