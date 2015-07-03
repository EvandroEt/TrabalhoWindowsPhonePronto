using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace WebServiceExampleApp
{
    public partial class Inicio : PhoneApplicationPage
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void appBarquestionmark_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Sobre.xaml", UriKind.Relative));
        }
    }
}