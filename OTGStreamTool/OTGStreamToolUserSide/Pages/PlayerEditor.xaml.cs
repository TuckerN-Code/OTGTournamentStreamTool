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
        
        public PlayerEditor()
        {
            InitializeComponent();
            P1Losers.IsEnabled = false;
            P2Losers.IsEnabled = false;
        }

        public void On_Update()
        {
            if(cbx_TournamentRound.SelectedValue.ToString() == "Grand Finals")
            {
                P1Losers.IsEnabled = true;
                P2Losers.IsEnabled = true;
            }
            else
            {
                P1Losers.IsEnabled = false;
                P2Losers.IsEnabled = false;
            }
        }
    }
}
