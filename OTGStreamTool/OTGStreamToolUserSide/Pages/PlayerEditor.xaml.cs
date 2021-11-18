using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OTGStreamToolUserSide.Pages
{
    /// <summary>
    /// Interaction logic for PlayerEditor.xaml
    /// </summary>
    public partial class PlayerEditor : Page
    {
        public string comm1 { get; set; }
        public PlayerEditor()
        {
            InitializeComponent();
        }
    }
}
