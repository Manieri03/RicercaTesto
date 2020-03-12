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

namespace RicercaTesto
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Cerca_Click(object sender, RoutedEventArgs e)
        {
            {
                {
                    string stringa = txtstringa.Text;
                    string testo = txttesto.Text + ' ';

                    if (testo.Contains(stringa) == true)
                    {
                        int index = testo.IndexOf(stringa);
                        int lunghezza = testo.Length;
                        int indexstringa = index + stringa.Length;
                        int i = index - 1;
                        int j = indexstringa;

                        if (testo[index - 1] == ' ')
                        {
                            while (i > 0)
                            {
                                i--;
                                if (testo[i] == ' ')
                                {
                                    break;

                                }
                            }

                            while (j < testo.Length)
                            {

                                j++;
                                if (testo[j] == ' ')
                                {

                                    break;
                                }

                            }


                            string risultato = testo.Substring(i, j - i);
                            lblcerca.Content = $"...{risultato}...";
                            
                        }
                        else if (testo[index - 1] != ' ')
                        {
                            while (i > 0 || i > testo.IndexOf(' '))
                            {
                                i--;

                            }

                            while (j < testo.Length || j < testo.IndexOf(' '))
                            {
                                j++;

                            }




                        }
                        string risultato2 = testo.Substring(i, j - i);
                        lblcerca.Content = $"...{risultato2}...";
                        
                    }
                    else
                    {
                        lblcerca.Content = "La stringa da lei richiesta non è presente nel testo";
                    }
                }
            }
        }
    }
}
