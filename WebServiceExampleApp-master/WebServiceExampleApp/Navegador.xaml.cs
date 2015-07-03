using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using WebServiceExampleApp.Repository;

namespace WebServiceExampleApp
{
    public partial class Navegador : PhoneApplicationPage
    {
        public Objetos Not;
        public Noticias Noti;
        public Navegador()
        {
            InitializeComponent();

        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

            base.OnNavigatedTo(e);

            if (Not != null)
            {
                web.Source = new Uri(Not.link);

            }

            if (Noti != null)
            {
                web.Source = new Uri(Noti.link);
            }
            

        }
    }
}