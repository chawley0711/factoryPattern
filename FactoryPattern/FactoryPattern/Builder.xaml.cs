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
using System.Windows.Shapes;

namespace FactoryPattern
{
    /// <summary>
    /// Interaction logic for Builder.xaml
    /// </summary>
    public partial class Builder : Window
    {
        public Builder()
        {
            InitializeComponent();
            List<string> list = new List<string>();
            list.Add("Button");
            list.Add("Label");
            list.Add("Text Box");
            foreach(string s in list)
            {
                drpComponents.Items.Add(s);
            }
            
        }

        private void drpComponents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
