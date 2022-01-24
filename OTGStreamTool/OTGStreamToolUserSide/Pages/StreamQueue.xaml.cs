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
    /// Interaction logic for SmashGG.xaml
    /// </summary>
    public partial class StreamQueue : Window
    {
        private PlayerEditor m_player;
        public StreamQueue(PlayerEditor player)
        {
            InitializeComponent();
            Global.TournamentSlug = "";
            Global.SmashGGAuth = "";
            m_player = player;
        }

        private void FillFromStreamQueue(TournamentType tournament)
        {
            try
            {

                List<StreamSetInfo> streams = new List<StreamSetInfo>();
                foreach (StreamQueueType streamQueue in tournament.streamQueue)
                {
                    foreach (SetsType set in streamQueue.sets)
                    {
                        StreamSetInfo setInfo = new StreamSetInfo();
                        setInfo.Player1Name = set.slots[0].entrant.participants[0].gamerTag;
                        setInfo.Player2Name = set.slots[1].entrant.participants[0].gamerTag;
                        setInfo.P1Pre = set.slots[0].entrant.participants[0].prefix;
                        setInfo.P2Pre = set.slots[1].entrant.participants[0].prefix;
                        setInfo.StreamName = streamQueue.stream.streamName;
                        streams.Add(setInfo);
                    }
                }
                ic_Sets.ItemsSource = streams;

            }
            catch (Exception ex)
            {
                StatusWindows.StatusOutputWindow win = new StatusWindows.StatusOutputWindow("Unable to retrive stream queue");
                win.Show();
            }
        }


        private void UpdateFromSmashGG()
        {
            try
            {
                SmashGG smashGG = new SmashGG();
                FillFromStreamQueue(Task<TournamentType>.Run(() => smashGG.getStreamPlayers(Global.TournamentSlug, Global.SmashGGAuth)).Result);
            }
            catch (Exception ex)
            {
                StatusWindows.StatusOutputWindow win = new StatusWindows.StatusOutputWindow("Unable to connect to smash.gg");
                win.Show();
            }
            
        }

        private void SelectSet_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            StreamSetInfo setInfo = button.DataContext as StreamSetInfo;
            m_player.tbx_Player1Name.Text = setInfo.Player1Name;
            m_player.tbx_Player2Name.Text = setInfo.Player2Name;
            m_player.tbx_Player1Prefix.Text = setInfo.P1Pre;
            m_player.tbx_Player2Prefix.Text = setInfo.P2Pre;
            this.Close();
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            UpdateFromSmashGG();
        }

        private void SetSlug(object sender, RoutedEventArgs e)
        {
            SetSlugBox box = new SetSlugBox();
            box.Show();
        }

        private void AuthToken_Click(object sender, RoutedEventArgs e)
        {
            SetAuthCode code = new SetAuthCode();
            code.Show();
        }
    }
    internal class StreamSetInfo
    {
        public string Player1Name { get; set; }
        public string Player2Name { get; set; }
        public string P1Pre { get; set; }
        public string P2Pre { get; set; }
        public string StreamName { get; set; }
    }
}
