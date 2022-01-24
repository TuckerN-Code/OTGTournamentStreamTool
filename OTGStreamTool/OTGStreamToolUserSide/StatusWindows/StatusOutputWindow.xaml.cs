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

namespace OTGStreamToolUserSide.StatusWindows
{
    /// <summary>
    /// Interaction logic for StatusOutputWindow.xaml
    /// </summary>
    public partial class StatusOutputWindow : Window
    {
        public StatusOutputWindow(string str)
        {
            InitializeComponent();
            StatusText.Text = str;
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
