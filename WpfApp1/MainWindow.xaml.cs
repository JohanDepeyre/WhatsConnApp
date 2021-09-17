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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dictionary<string, string> tableauConnecteur = new Dictionary<string, string>();
        string goodAnswer;
        int bonBouton;
        int score = 0;
        int nombreQ = 0;
        public MainWindow()
        {
            InitializeComponent();

            //  { "Ethernet", "PCI-Express", "USB", "USB-C", "ThunderBolt" };
            tableauConnecteur.Add("Ethernet", "images/ethernet.png");
            tableauConnecteur.Add("PCI-Express", "images/pci.png");
            tableauConnecteur.Add("USB", "images/usb.png");
            tableauConnecteur.Add("USB-C", "images/usbc.png");
           
           

        }

        private void CmdGo_Click(object sender, RoutedEventArgs e)
        {
            GenererQuestion();
        }
        void GenererQuestion()
        {

            Random random = new Random();
            int nombreRandom = random.Next(3);
            goodAnswer = tableauConnecteur.ElementAt(nombreRandom).Value;
            LblConnecteur.Content = tableauConnecteur.ElementAt(nombreRandom).Key;
            EnableBouton();
            AfficherConnecteur();
            afficherScore();
            nombreQ++;
        }

        void AfficherConnecteur()
        {
            Dictionary<string, string> tableauConnecteurImage = new Dictionary<string, string>();
            tableauConnecteurImage = tableauConnecteur.ToDictionary(entry => entry.Key,
                                               entry => entry.Value);
            int nombreRandom = 0;
            string valueDic;
            Uri resourceUri;
            Random random = new Random();
            nombreRandom = random.Next(3);


            valueDic = tableauConnecteurImage.ElementAt(nombreRandom).Value;
             resourceUri = new Uri(valueDic, UriKind.Relative);
            if (goodAnswer == valueDic)
            {
                bonBouton = 1;
              
            }
            tableauConnecteurImage.Remove(tableauConnecteurImage.ElementAt(nombreRandom).Key);
            CmdImg1.Content = new Image
            {
                Source = new BitmapImage(resourceUri),
                VerticalAlignment = VerticalAlignment.Center
            };



            nombreRandom = random.Next(2);
            valueDic = tableauConnecteurImage.ElementAt(nombreRandom).Value;
            resourceUri = new Uri(valueDic, UriKind.Relative);
            if (goodAnswer == valueDic)
            {
                bonBouton = 2;
            }
            tableauConnecteurImage.Remove(tableauConnecteurImage.ElementAt(nombreRandom).Key);
            CmdImg2.Content = new Image
            {
                Source = new BitmapImage(resourceUri),
                VerticalAlignment = VerticalAlignment.Center
            };



            nombreRandom = random.Next(1);
            valueDic = tableauConnecteurImage.ElementAt(nombreRandom).Value;
            resourceUri = new Uri(valueDic, UriKind.Relative);
            if (goodAnswer == valueDic)
            {
                bonBouton = 3;
            }
            tableauConnecteurImage.Remove(tableauConnecteurImage.ElementAt(nombreRandom).Key);
            CmdImg3.Content = new Image
            {
                Source = new BitmapImage(resourceUri),
                VerticalAlignment = VerticalAlignment.Center
            };



            nombreRandom = random.Next(0);
            valueDic = tableauConnecteurImage.ElementAt(nombreRandom).Value;
            resourceUri = new Uri(valueDic, UriKind.Relative);
            if (goodAnswer == valueDic)
            {
                bonBouton = 4;
            }
            tableauConnecteurImage.Remove(tableauConnecteurImage.ElementAt(nombreRandom).Key);
            CmdImg4.Content = new Image
            {
                Source = new BitmapImage(resourceUri),
                VerticalAlignment = VerticalAlignment.Center
            };



        }

        private void CmdSuivant_Click(object sender, RoutedEventArgs e)
        {
            GenererQuestion();
        }

        private void CmdImg1_Click(object sender, RoutedEventArgs e)
        {
            if (bonBouton== 1)
            {
                LblSucces.Content = "Bravo";
                score++;
            }
            else
            {
                LblSucces.Content = "Faux";
            }
            DisableBouton();

        }

        private void CmdImg2_Click(object sender, RoutedEventArgs e)
        {
            if (bonBouton == 2)
            {
                LblSucces.Content = "Bravo";
                score++;
            }
            else
            {
                LblSucces.Content = "Faux";
            }
            DisableBouton();
        }

        private void CmdImg3_Click(object sender, RoutedEventArgs e)
        {
            if (bonBouton == 3)
            {
                LblSucces.Content = "Bravo";
                score++;
            }
            else
            {
                LblSucces.Content = "Faux";
            }
            DisableBouton();
        }

        private void CmdImg4_Click(object sender, RoutedEventArgs e)
        {
            if (bonBouton == 4)
            {
                LblSucces.Content = "Bravo";
                score++;
            }
            else
            {
                LblSucces.Content = "Faux";
            }
            DisableBouton();
        }

        void DisableBouton()
        {

            CmdImg1.IsEnabled = false;
            CmdImg1.IsEnabled = false;
            CmdImg1.IsEnabled = false;
            CmdImg1.IsEnabled = false;
        }
        void EnableBouton()
        {

            CmdImg1.IsEnabled = true;
            CmdImg1.IsEnabled = true;
            CmdImg1.IsEnabled = true;
            CmdImg1.IsEnabled = true;
        }
        void afficherScore()
        {
            LblPoint.Content = "Score: " + score + " sur " + nombreQ;
        }
    }
}
