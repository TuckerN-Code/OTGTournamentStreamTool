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
    /// Interaction logic for CommentatorEditor.xaml
    /// </summary>
    /// 
    public partial class CommentatorEditor : Page
    {
        //public string Comm1 { get; set; }
        public CommentatorEditor()
        {
            InitializeComponent();
            FillFromGlobal();
        }

        private void UpdateGlobalPackage()
        {
            Global.updatePackage.Comm1Name = Comm1Name.Text;
            Global.updatePackage.Comm2Name = Comm2Name.Text;
            Global.updatePackage.Comm1Twitter = Comm1Twitter.Text;
            Global.updatePackage.Comm2Twitter = Comm2Twitter.Text;
            Global.updatePackage.Comm1Prefix = Comm1Pre.Text;
            Global.updatePackage.Comm2Prefix = Comm2Pre.Text;
        }

        private void FillFromGlobal()
        {
            Comm1Name.Text = Global.updatePackage.Comm1Name;
            Comm1Twitter.Text = Global.updatePackage.Comm1Twitter;
            Comm2Name.Text = Global.updatePackage.Comm2Name;
            Comm2Twitter.Text = Global.updatePackage.Comm2Twitter;
            Comm1Pre.Text = Global.updatePackage.Comm1Prefix;
            Comm2Pre.Text = Global.updatePackage.Comm2Prefix;
        }

        private void PlayerPageNav_Click(object sender, RoutedEventArgs e)
        {
            UpdateGlobalPackage();
            this.NavigationService.Content = new Pages.PlayerEditor();
        }

        private void UpdateBotton_Click(object sender, RoutedEventArgs e)
        {
            UpdateGlobalPackage();
            ApiAccess api = new ApiAccess();
        }
    }
}
