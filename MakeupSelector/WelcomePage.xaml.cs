using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace MakeupSelector
{
    /// <summary>
    /// Interaction logic for WelcomePage.xaml
    /// </summary>
    public partial class WelcomePage : Page
    {
        String category;
        MainWindow mainWindow;
        public WelcomePage(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            this.category = "blush";
            mainWindow.setPageToProductPage(this.category);
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            this.category = "eyebrow";
            mainWindow.setPageToProductPage(this.category);
            
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            this.category = "foundation";
            mainWindow.setPageToProductPage(this.category);
        }

        private void RadioButton_Checked_3(object sender, RoutedEventArgs e)
        {
            this.category = "lipstick";
            mainWindow.setPageToProductPage(this.category);
        }
        
    }
}
