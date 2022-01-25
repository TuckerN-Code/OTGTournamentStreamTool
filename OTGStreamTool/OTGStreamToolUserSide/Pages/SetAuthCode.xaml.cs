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

namespace OTGStreamToolUserSide.Pages
{
    /// <summary>
    /// Interaction logic for SetAuthCode.xaml
    /// </summary>
    public partial class SetAuthCode : Window
    {
        public SetAuthCode()
        {
            InitializeComponent();
            AuthTextBox.Text = Properties.Settings.Default.SmashGGAuthCode;
        }
        private void Update_Click(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.SmashGGAuthCode = AuthTextBox.Text;
            this.Close();
        }
    }
}
