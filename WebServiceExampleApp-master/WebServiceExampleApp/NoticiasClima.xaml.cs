using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.IO;
using System.Xml;
using System.ServiceModel.Syndication;
using Microsoft.Phone.Tasks;
using System.Xml.Linq;
using WebServiceExampleApp.Repository;

namespace WebServiceExampleApp
{
    public partial class NoticiasClima : PhoneApplicationPage
    {
        public Noticias not { get; set; }
        Objetos salva;
        public NoticiasClima()
        {
            InitializeComponent();
        }

        private void loadFeedButton_Click(object sender, RoutedEventArgs e)
        {
            progress.Visibility = System.Windows.Visibility.Visible;

            WebClient webClient = new WebClient();
            webClient.DownloadStringCompleted += new DownloadStringCompletedEventHandler(RssClient_DownloadStringCompleted);

            webClient.DownloadStringAsync(new Uri(@"http://www.climatempo.com.br/rss/regioes.xml"));

            progress.Visibility = System.Windows.Visibility.Collapsed;
        }

        void RssClient_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            try
            {
                var RssData = from rss in XElement.Parse(e.Result).Descendants("item")
                              select new Objetos
                              {

                                  title = rss.Element("title").Value,
                                  link = rss.Element("link").Value,
                                  description = rss.Element("description").Value,


                              };
                feedListBox.ItemsSource = RssData;
        }   
            catch (Exception)
            {
                MessageBox.Show("A Pagina não pode ser Carregada!");
                progress.Visibility = System.Windows.Visibility.Collapsed;
            }
        }

        private void Navigate(string pPage)
        {
            NavigationService.Navigate(new Uri(pPage, UriKind.Relative));
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            Navegador page = e.Content as Navegador;
            if (page != null)
            {
                
                page.Not = salva;
            }

        }

        private void feedListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

              salva = (sender as ListBox).SelectedItem as Objetos;
                  
        }

        private void appBarSave_Click(object sender, EventArgs e)
        {

            try
            {
                Noticias noticias = new Noticias
                {
                    title = salva.title,
                    description = salva.description,
                    link = salva.link
                };

                NoticiasRepositorio.create(noticias);
                MessageBox.Show("Noticia Salva!");
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione uma Noticia para Salva-la!");
            }

        }

        private void appBarFav_Click(object sender, EventArgs e)
        {
            Navigate("/NoticiasSalvas.xaml");
        }

        private void appBarDetalhes_Click(object sender, EventArgs e)
        {
            try
            {
                if (salva == null)
                {
                    MessageBox.Show("Não ha nada Selecionado");
                }
                else
                {
                    NavigationService.Navigate(new Uri("/Navegador.xaml", UriKind.Relative));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Não ha nada Selecionado");
            }
              
        }

    }
}