using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace ProyectoTercerParcial
{
    /// <summary>
    /// Interaction logic for Serie.xaml
    /// </summary>
    public partial class Serie : UserControl
    {

        public Serie()
        {
            InitializeComponent();                   
        }

        private void Tboxtitulo_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(tboxtitulo.Text == "")
            {
                tboxalerta.Visibility = Visibility.Visible; 
            }
            else
            {
                tboxalerta.Visibility = Visibility.Hidden;
            }

        }

        private void Tboxaño_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tboxaño.Text == "")
            {
                tboxalerta.Visibility = Visibility.Visible;
            }
            else
            {
                tboxalerta.Visibility = Visibility.Hidden;
            }
        }

        private void CbGenero_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void Tboxrating_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tboxrating.Text == "")
            {
                tboxalerta.Visibility = Visibility.Visible;
            }
            else
            {
                tboxalerta.Visibility = Visibility.Hidden;
            }
        }

        private void Tboxdescripcion_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tboxdescripcion.Text == "")
            {
                tboxalerta.Visibility = Visibility.Visible;
            }
            else
            {
                tboxalerta.Visibility = Visibility.Hidden;
            }
        }

        private void Tbxproduccion_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(tbxproduccion.Text == "")
            {
                tboxalerta.Visibility = Visibility.Visible;
            }
            else
            {
                tboxalerta.Visibility = Visibility.Hidden;
            }
        }

        private void Btnguardar_Click(object sender, RoutedEventArgs e)
        {
            if (tboxtitulo.Text == "" || tboxaño.Text == "" || cbGenero.SelectedItem == cbGenero.ItemsSource || tboxtemporada.Text == "" || 
                tboxrating.Text == "" || tboxdescripcion.Text == "" || tbxproduccion.Text == "")

            {
                tboxalerta.Visibility = Visibility.Visible;
            }

            else
            {
                gridserie.Children.Clear();
                tboxalerta.Visibility = Visibility.Hidden;
                btnguardar.Visibility = Visibility.Hidden;
                btncancelar.Visibility = Visibility.Hidden;
            }

            
            
        }

        private void Btncancelar_Click(object sender, RoutedEventArgs e)
        {
            gridserie.Children.Clear();
            btnguardar.Visibility = Visibility.Hidden;
            btncancelar.Visibility = Visibility.Hidden;
        }   
    }
}
