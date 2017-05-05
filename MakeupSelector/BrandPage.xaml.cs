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

namespace MakeupSelector
{
    /// <summary>
    /// Interaction logic for ProductPage.xaml
    /// </summary>
    public partial class BrandPage : Page
    {
        MainWindow mainWindow;
        public BrandPage(String category, MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            MainClass create = new MainClass();
           
            List<MakeupProduct> products = create.getData(category);
            List<string> brands = new List<string>();

            foreach(MakeupProduct makeupProduct in products){
                brands.Add(makeupProduct.brand);
            }

            var unique_brands = new HashSet<string>(brands);

            DaftarBrandMakeup.Items.Clear();
            DaftarBrandMakeup.ItemsSource = unique_brands;
        }

        private void DaftarBrandMakeup_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MainClass create = new MainClass();
            create.saveBrand((String) DaftarBrandMakeup.SelectedItem);
            mainWindow.setPageToProductPage();
        }
    }
}
