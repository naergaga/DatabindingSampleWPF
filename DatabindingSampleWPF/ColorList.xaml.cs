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

namespace DatabindingSampleWPF
{
    /// <summary>
    /// ColorList.xaml 的交互逻辑
    /// </summary>
    public partial class ColorList : Window
    {
        private ColorListDataContext DC => (ColorListDataContext)DataContext;

        public ColorList()
        {
            InitializeComponent();
        }

        private void AddToFavorites_Click(object sender, RoutedEventArgs e)
        {
            DC.AddSelectedColorToFavorites();
        }

        private void RemoveFromFavorites_Click(object sender, RoutedEventArgs e)
        {
            DC.RemoveFavoriteColor();
        }
    }
}
