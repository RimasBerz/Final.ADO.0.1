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

namespace FinalADO
{
    public partial class PortalWindow : Window
    {
        public PortalWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            new MainWindow().ShowDialog();
            this.Show();
        }
        #region
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           // пространство для будущей курсовой
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            // пространство для будущей курсовой
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            // пространство для будущей курсовой
        }
        #endregion
    }
}
