using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appOOP
{
    class StudentCollege : Student
    {
        public StudentCollege (string Name)
        {
            this.Name = Name;
        }

        public StudentCollege()
        {
        }
        public void Talk()
        {
            base.Talk();
        }
    }
}
