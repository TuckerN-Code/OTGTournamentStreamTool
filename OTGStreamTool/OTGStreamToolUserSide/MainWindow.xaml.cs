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
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using OTGStreamToolUserSide;
using APITest;

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
            ContentFrame.Content = new Pages.PlayerEditor();
            //HostApi();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }
        
        private void GoToPlayerEditor(object sender, RoutedEventArgs e)
        {
            
        }

        private static async Task HostApi()
        {
           await Task.Run(() => APITest.Program.Main(Global.args));    
        }



    }
}
