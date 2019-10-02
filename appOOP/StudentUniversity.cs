using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace appOOP
{
    class StudentUniversity : Student
    {
         public StudentUniversity (string Name)
        {
            this.Name = Name;
        }

         public StudentUniversity()
        {
        }
        public void Talk()
        {
            base.Talk();
        }
    }
}
