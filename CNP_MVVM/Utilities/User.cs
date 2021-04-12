using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNP_MVVM.Utilities
{
    class User
    {
        public string Id { get; set; }
        public string DisplayValue { get; set; }
        public Person Person { get; set; }
        public AddressClass Address { get; set; }
    }
}
