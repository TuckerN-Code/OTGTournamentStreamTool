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
using OTGStreamToolBackEnd;

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
            Fill_TournamentRound();
            FillFromGlobal();
            
            
        }

        private void LeavePage()
        {
            this.NavigationService.Content = new Pages.CommentatorEditor();
        }

        private void Fill_TournamentRound()
        {
            cbx_TournamentRound.Items.Add("Friendlies");
            cbx_TournamentRound.Items.Add("Winners");
            cbx_TournamentRound.Items.Add("Losers");
            cbx_TournamentRound.Items.Add("Top 8 Qualifier");
            cbx_TournamentRound.Items.Add("Winners Quarterfinals");
            cbx_TournamentRound.Items.Add("Winners Semifinals");
            cbx_TournamentRound.Items.Add("Winners Finals");
            cbx_TournamentRound.Items.Add("Losers Quarterfinals");
            cbx_TournamentRound.Items.Add("Losers Finals");
            cbx_TournamentRound.Items.Add("Grand Finals");
            cbx_TournamentRound.SelectedIndex = 1;
        }

        private void FillFromGlobal()
        {
            cbx_TournamentRound.Text = Global.updatePackage.TournamentRound;
            tbx_Player1Name.Text = Global.updatePackage.Player1Tag;
            tbx_Player2Name.Text = Global.updatePackage.Player2Tag;
            tbx_Player1Twitter.Text = Global.updatePackage.Player1Twitter;
            tbx_Player2Twitter.Text = Global.updatePackage.Player2Twitter;
            tbx_Player1Prefix.Text = Global.updatePackage.Player1Prefix;
            tbx_Player2Prefix.Text = Global.updatePackage.Player2Prefix;
            tbx_Player1Pronouns.Text = Global.updatePackage.Player1Pronouns;
            tbx_Player2Pronouns.Text = Global.updatePackage.Player2Pronouns;
            tbx_Player1Score.Text = Global.updatePackage.Player1Score;
            tbx_Player2Score.Text = Global.updatePackage.Player2Score;
            tbx_Player1Name.Text = Global.updatePackage.Player1Tag;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CheckForGrands();
            UpdatePackage();
            ApiAccess access = new ApiAccess(Global.updatePackage);
        }


        private void UpdatePackage()
        {
            
            Global.updatePackage.Player1Tag = tbx_Player1Name.Text;
            if(P1Losers.IsChecked == true)
            {
                Global.updatePackage.Player1Tag += " [L]";
            }
            Global.updatePackage.Player2Tag = tbx_Player2Name.Text;
            if(P2Losers.IsChecked == true)
            {
                Global.updatePackage.Player2Tag += " [L]";
            }    
            Global.updatePackage.Player1Prefix = tbx_Player1Prefix.Text;
            Global.updatePackage.Player2Prefix = tbx_Player2Prefix.Text;
            Global.updatePackage.Player1Twitter = tbx_Player1Twitter.Text;
            Global.updatePackage.Player2Twitter = tbx_Player2Twitter.Text;
            Global.updatePackage.Player1Pronouns = tbx_Player1Pronouns.Text;
            Global.updatePackage.Player2Pronouns = tbx_Player2Pronouns.Text;
            Global.updatePackage.Player1Score = tbx_Player1Score.Text;
            Global.updatePackage.Player2Score = tbx_Player2Score.Text;
            Global.updatePackage.TournamentRound = cbx_TournamentRound.Text;

        }
        private void CheckForGrands()
        {
            if (cbx_TournamentRound.SelectedItem == null)
            {
                cbx_TournamentRound.SelectedIndex = 1;
            }
            if (cbx_TournamentRound.SelectedValue.ToString() == "Grand Finals")
            {
                P1Losers.IsEnabled = true;
                P2Losers.IsEnabled = true;
            }
            else
            {
                P1Losers.IsEnabled = false;
                P1Losers.IsChecked = false;
                P2Losers.IsEnabled = false;
                P2Losers.IsChecked = false;
            }
            
        }
    }
}
