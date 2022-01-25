using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Diagnostics;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using OTGStreamToolUserSide;


namespace OTGStreamToolUserSide
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        public MainWindow()
        {
            InitializeComponent();
            Global.updatePackage.Player1Score = "0";
            Global.updatePackage.TournamentRound = "Tournament Round";
            Global.updatePackage.Player2Score = "0";
            ContentFrame.Content = new Pages.PlayerEditor();

            HostJSAPI();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }
        
        private void GoToPlayerEditor(object sender, RoutedEventArgs e)
        {
            
        }

        private static void HostJSAPI()
        {
            Global.process = new Process();
            Global.process.StartInfo.CreateNoWindow = true;

            Global.process.StartInfo.FileName = "app-win.exe";

            Global.process.Start();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Global.process != null)
                Global.process.Close();
        }
    }
}
