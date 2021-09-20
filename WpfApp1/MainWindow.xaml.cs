using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

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
            tableauConnecteur.Add("Display Port", "images/dp.png");
            tableauConnecteur.Add("HDMI Male", "images/hdmimale.png");
            tableauConnecteur.Add("VGA", "images/portvga.png");
            tableauConnecteur.Add("PS2", "images/ps2.png");
            tableauConnecteur.Add("RJ11", "images/rj11.png");
         
            

        }

        private void CmdGo_Click(object sender, RoutedEventArgs e)
        {
            GenererQuestion();
            CmdGo.Visibility = Visibility.Hidden;
            CmdSuivant.Visibility = Visibility.Visible;
            //CmdSuivant.IsEnabled = false;
        }
        void GenererQuestion()
        {

            Random random = new Random();
            int nombreRandom = random.Next(8);
            goodAnswer = tableauConnecteur.ElementAt(nombreRandom).Value;
            LblConnecteur.Content = tableauConnecteur.ElementAt(nombreRandom).Key;
            EnableBouton();
            AfficherConnecteur();
            //desactive le bouton tant que l'utilisateur n'a pas répondu
            CmdSuivant.IsEnabled = false;
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
            nombreRandom = random.Next(8);


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



            nombreRandom = random.Next(7);
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



            nombreRandom = random.Next(6);
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



            nombreRandom = random.Next(5);
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

            nombreRandom = random.Next(4);
            valueDic = tableauConnecteurImage.ElementAt(nombreRandom).Value;
            resourceUri = new Uri(valueDic, UriKind.Relative);
            if (goodAnswer == valueDic)
            {
                bonBouton = 5;
            }
            tableauConnecteurImage.Remove(tableauConnecteurImage.ElementAt(nombreRandom).Key);
            CmdImg5.Content = new Image
            {
                Source = new BitmapImage(resourceUri),
                VerticalAlignment = VerticalAlignment.Center
            };

            nombreRandom = random.Next(3);
            valueDic = tableauConnecteurImage.ElementAt(nombreRandom).Value;
            resourceUri = new Uri(valueDic, UriKind.Relative);
            if (goodAnswer == valueDic)
            {
                bonBouton = 6;
            }
            tableauConnecteurImage.Remove(tableauConnecteurImage.ElementAt(nombreRandom).Key);
            CmdImg6.Content = new Image
            {
                Source = new BitmapImage(resourceUri),
                VerticalAlignment = VerticalAlignment.Center
            };


            nombreRandom = random.Next(2);
            valueDic = tableauConnecteurImage.ElementAt(nombreRandom).Value;
            resourceUri = new Uri(valueDic, UriKind.Relative);
            if (goodAnswer == valueDic)
            {
                bonBouton = 7;
            }
            tableauConnecteurImage.Remove(tableauConnecteurImage.ElementAt(nombreRandom).Key);
            CmdImg7.Content = new Image
            {
                Source = new BitmapImage(resourceUri),
                VerticalAlignment = VerticalAlignment.Center
            };

            nombreRandom = random.Next(1);
            valueDic = tableauConnecteurImage.ElementAt(nombreRandom).Value;
            resourceUri = new Uri(valueDic, UriKind.Relative);
            if (goodAnswer == valueDic)
            {
                bonBouton = 8;
            }
            tableauConnecteurImage.Remove(tableauConnecteurImage.ElementAt(nombreRandom).Key);
            CmdImg8.Content = new Image
            {
                Source = new BitmapImage(resourceUri),
                VerticalAlignment = VerticalAlignment.Center
            };

            nombreRandom = random.Next(0);
            valueDic = tableauConnecteurImage.ElementAt(nombreRandom).Value;
            resourceUri = new Uri(valueDic, UriKind.Relative);
            if (goodAnswer == valueDic)
            {
                bonBouton = 9;
            }
            tableauConnecteurImage.Remove(tableauConnecteurImage.ElementAt(nombreRandom).Key);
            CmdImg9.Content = new Image
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
            var myValue = ((Button)sender).Tag;
            if (bonBouton== int.Parse((string)myValue))
            {
                LblSucces.Content = "Bravo";
                
                LblSucces.Foreground = Brushes.Green;
                score++;
            }
            else
            {
                LblSucces.Content = "Faux";
                LblSucces.Foreground = Brushes.Red;
            }
            DisableBouton();
            nombreQ++;
            
            afficherScore();
            if (nombreQ == 10)
            {
                MessageFin();
            }
            CmdSuivant.IsEnabled = true;

        }


        void DisableBouton()
        {

            CmdImg1.IsEnabled = false;
            CmdImg2.IsEnabled = false;
            CmdImg3.IsEnabled = false;
            CmdImg4.IsEnabled = false;
            CmdImg5.IsEnabled = false;
            CmdImg6.IsEnabled = false;
            CmdImg7.IsEnabled = false;
            CmdImg8.IsEnabled = false;
            CmdImg9.IsEnabled = false;
        }
        void EnableBouton()
        {

            CmdImg1.IsEnabled = true;
            CmdImg2.IsEnabled = true;
            CmdImg3.IsEnabled = true;
            CmdImg4.IsEnabled = true;
            CmdImg5.IsEnabled = true;
            CmdImg6.IsEnabled = true;
            CmdImg7.IsEnabled = true;
            CmdImg8.IsEnabled = true;
            CmdImg9.IsEnabled = true;
        }
        void afficherScore()
        {
            LblPoint.Content = "Score: " + score + " sur " + nombreQ;
        }
        void MessageFin()
        {
            MessageBoxResult result = MessageBox.Show("Votre score est de " + score + " sur " + nombreQ + " - Voulez vous rejouer ? ", "WhatConnector", MessageBoxButton.YesNo);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    score = 0;
                    nombreQ = 0;
                    LblConnecteur.Content = "";
                    LblPoint.Content = "";
                    LblSucces.Content = "";
                    CmdGo.Visibility = Visibility.Visible;
                    GenererQuestion();
                    break;
                case MessageBoxResult.No:
                   
                    break;
              
            }
        }
    }
}
