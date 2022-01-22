﻿using System;
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
    /// Interaction logic for SetSlugBox.xaml
    /// </summary>
    public partial class SetSlugBox : Window
    {
        public SetSlugBox()
        {
            InitializeComponent();
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            Global.TournamentSlug = SlugTextBox.Text;
            this.Close();
        }
    }
}
