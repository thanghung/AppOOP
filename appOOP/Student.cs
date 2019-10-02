using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace appOOP
{
    class Student
    {
        protected string Name;
        public string ten;
        public string StudentName
        {    
            get { return Name; }   
            set { Name = value; }
        }

        public Student (string Name)
        {
            this.Name = Name;
        }

        public Student()
        {
        }
        public virtual void Talk()
        {
               ten = "Hello " + Name + "\n";
        }
    }
}
