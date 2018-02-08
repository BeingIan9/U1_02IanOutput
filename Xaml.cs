/*Ian Markham
 * Feb 8,2018
 * Output
 * User types a name and Hello name
 */
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

namespace U1_02IanOutput
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

        private void btnshowgreeting_Click(object sender, RoutedEventArgs e)
        {
            lblOutput.Content = "Hello, " + lblName.Text + " so I see you are " + lblAge.Text + " years old!";
        }

        private void lblName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
