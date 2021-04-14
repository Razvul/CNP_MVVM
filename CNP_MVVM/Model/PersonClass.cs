using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CNP_MVVM.Utilities;

namespace CNP_MVVM.Model
{
    public class PersonClass
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public GenderEnums Sex { get; set; }
        public long CNP { get; set; }
    }
}
