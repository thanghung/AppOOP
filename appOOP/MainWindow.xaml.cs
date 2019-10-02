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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<Student> st1 = new List<Student>();
            st1.Add(new Student("huy"));
            st1.Add(new Student("hung"));
            st1.Add(new Student("khoa"));
            st1.Add(new Student("ngan"));
            st1.Add(new Student("nhi"));
            st1.Add(new Student("tran"));


            foreach (Student item in st1)
            {
                // Ten = Ten + item.ten + "\n";
                txbten.Items.Add(item.StudentName);
            }

            for (int i = 1; i <= st1.Count; i++)
                txbstt.Items.Add(i.ToString());
                
        }

    }
}
