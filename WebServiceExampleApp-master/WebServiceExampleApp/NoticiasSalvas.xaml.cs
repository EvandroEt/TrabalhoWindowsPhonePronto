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
    public partial class NoticiasSalvas : PhoneApplicationPage
    {
        public Noticias Noti;
        public Noticias salva;
        public NoticiasSalvas()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            List<Noticias> noticias = Repository.NoticiasRepositorio.Get();
            lstSalvas.ItemsSource = noticias;
        }


        private void appBarDelete_Click(object sender, EventArgs e)
        {
            if (salva == null)
            {
                MessageBox.Show("Selecione a Noticia Para Excluir!");

            }else if(MessageBox.Show("Excluir Noticia " + salva.title + "?") == MessageBoxResult.OK){
                NoticiasRepositorio.delete(salva);
                atualizar();
            }
            
        }

        public void atualizar()
        {
            List<Noticias> noticia = NoticiasRepositorio.Get();
            lstSalvas.ItemsSource = noticia;
        }

        private void appBarDetalhes_Click(object sender, EventArgs e)
        {
            try
            {
                if (salva == null)
                {
                    MessageBox.Show("Não ha nada Selecionado!");
                }
                else
                {
                    NavigationService.Navigate(new Uri("/Navegador.xaml", UriKind.Relative));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Não ha nada Selecionado!");
            }
        }

        private void lstSalvasOnSelectionChange(object sender, SelectionChangedEventArgs e)
        {
            salva = (sender as ListBox).SelectedItem as Noticias;
            
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            Navegador page = e.Content as Navegador;
            if (page != null)
            {

                page.Noti = salva;
            }

        }
    }
}