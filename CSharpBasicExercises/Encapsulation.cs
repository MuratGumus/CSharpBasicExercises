using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vsdeneme2
{
    public class Encapsulation
    {
        private string name;

        public void setName(string setName)  
        {
            name = setName;  // Value her ne kadar private olsa da setName ile atama yaptığımız için bu value'ya erişebiliyoruz.
        }

        public string getName()
        {
            return name;
        }
    }
}
