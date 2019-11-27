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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<ClPadre> clpadre = new ObservableCollection<ClPadre>();
        ObservableCollection<Pelicula1> pelicula1 = new ObservableCollection<Pelicula1>();
        ObservableCollection<Serie1> serie1 = new ObservableCollection<Serie1>();

        public MainWindow()
        {
            InitializeComponent();

            Pelicula1 pelA = new Pelicula1("Avengers", 2012, "5", "Accion", "La union de las fuerzas de los heroes mas poderosos", "Hermanos Russo", "MARVEL");
            Serie1 serA = new Serie1("Atypical", 2019, "5", "Comedia", "La vida cotidiana de un autista", "Unknown", "3", "NETFLIX");

            clpadre.Add(pelA);
            clpadre.Add(serA);
            listdatos.ItemsSource = clpadre;
        }

        private void CbSEPE_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            grdagregar.Children.Clear();
        }
        
        private void Btnaceptar_Click(object sender, RoutedEventArgs e)
        {
            btneditar.Visibility = Visibility.Hidden;
            btneliminar.Visibility = Visibility.Hidden;
            btncancelar1.Visibility = Visibility.Hidden;
            btnaceptar1.Visibility = Visibility.Hidden;
            

            switch (cbSEPE.SelectedIndex)
            {
                case 0:
                    grdagregar.Children.Add(new Serie());
                    break;
                case 1:
                    grdagregar.Children.Add(new Pelicula());
                    break;
                default:
                    break;
            }                   
        }

        private void Listdatos_SelectionChanged(object sender, SelectionChangedEventArgs e) 
        {
            if(listdatos.SelectedIndex != -1)
            {
                grdagregar.Children.Clear();
                grdagregar.Children.Add(new Vista());
                btneditar.Visibility = Visibility.Visible;
                btneliminar.Visibility = Visibility.Visible;
                btncancelar1.Visibility = Visibility.Visible;

                var elemvista = ((Vista) (grdagregar.Children[0]));
                var plistdatos = clpadre[listdatos.SelectedIndex];

                if (cbSEPE.SelectedItem == "Pelicula")
                {
                    elemvista.tboxtitulo.Text = plistdatos.Titulo;
                    elemvista.tboxaño.Text = plistdatos.Año.ToString();
                    elemvista.tboxrating.Text = plistdatos.Rating.ToString();
                    elemvista.cbgenero.Text = plistdatos.Genero;                  
                    elemvista.tboxdescripcion.Text = plistdatos.Descripcion;
                    elemvista.tbxdir.Text = plistdatos.Director;
                    elemvista.tboxtemp.Visibility = Visibility.Hidden;

                    elemvista.tboxtitulo.IsEnabled = false;
                    elemvista.tboxaño.IsEnabled = false;
                    elemvista.tbxdir.IsEnabled = false;
                    elemvista.cbgenero.IsEnabled = false;
                    elemvista.tboxdescripcion.IsEnabled = false;
                    elemvista.tboxrating.IsEnabled = false;                   
                }

                if(cbSEPE.SelectedItem == "Serie")
                {
                    elemvista.tboxtitulo.Text = plistdatos.Titulo;
                    elemvista.tboxaño.Text = plistdatos.Año.ToString();
                    elemvista.cbgenero.Text = plistdatos.Genero;
                    elemvista.tboxrating.Text = plistdatos.Rating.ToString();
                    elemvista.tboxdescripcion.Text = plistdatos.Descripcion;
                    elemvista.tbxdir.Text = plistdatos.Director;
                    elemvista.tboxtemp.Text = plistdatos.Temp;
                    elemvista.tboxtitulo.IsEnabled = false;
                    elemvista.tboxaño.IsEnabled = false;
                    elemvista.tbxdir.IsEnabled = false;
                    elemvista.cbgenero.IsEnabled = false;
                    elemvista.tboxdescripcion.IsEnabled = false;
                    elemvista.tboxrating.IsEnabled = false;
                }
            }
          
        }

        private void Btndes_Click(object sender, RoutedEventArgs e)
        {          
        }

        private void Btnasc_Click(object sender, RoutedEventArgs e)
        {
            int gap, i;
            gap = clpadre.Count / 2;
            while (gap > 0)
            {
                for (i = 0; i < clpadre.Count; i++)
                {
                    if (gap + i < clpadre.Count && clpadre[i].Año < clpadre[gap + i].Año)
                    {
                        var temp = clpadre[i];
                        clpadre[i] = clpadre[gap + i];
                        clpadre[gap + i] = temp;
                    }
                }
                gap--;
            }
        }

        private void Btnaz_Click(object sender, RoutedEventArgs e)
        {
            bool change;
            do
            {
                change = false;
                for (int i = 0; i < (clpadre.Count - 1); i++)
                {
                    if (string.Compare(clpadre[i].Titulo, clpadre[i + 1].Titulo) > 0)
                    {
                        var temp = clpadre[i];
                        clpadre[i] = clpadre[i + 1];
                        clpadre[i + 1] = temp;
                        change = true;
                    }
                }
            } while (change == true);
        }

        private void Btnza_Click(object sender, RoutedEventArgs e)
        {
            bool change;
            do
            {
                change = false;
                for (int i = 0; i < (clpadre.Count - 1); i++)
                {
                    if (string.Compare(clpadre[i].Titulo, clpadre[i + 1].Titulo) < 0)
                    {
                        var temp = clpadre[i];
                        clpadre[i] = clpadre[i + 1];
                        clpadre[i + 1] = temp;
                        change = true;
                    }
                }
            } while (change == true);
        }

        private void Btndes_Click_1(object sender, RoutedEventArgs e)
        {
            int gap, i;
            gap = clpadre.Count / 2;
            while (gap > 0)
            {
                for (i = 0; i < clpadre.Count; i++)
                {
                    for (i = 0; i < clpadre.Count; i++)
                    {
                        if (gap + i < clpadre.Count && clpadre[i].Año > clpadre[gap + i].Año)
                        {
                            var temp = clpadre[i];
                            clpadre[i] = clpadre[gap + i];
                            clpadre[gap + i] = temp;
                        }
                    }
                }
            }
        }

        private void Btneditar_Click(object sender, RoutedEventArgs e)
        {
            btneditar.Visibility = Visibility.Hidden;
            btnaceptar1.Visibility = Visibility.Visible;

            var elemvista = ((Vista)(grdagregar.Children[0]));

            elemvista.tboxtitulo.IsEnabled = true;
            elemvista.tboxaño.IsEnabled = true;
            elemvista.cbgenero.IsEnabled = true;           
            elemvista.tboxrating.IsEnabled = true;
            elemvista.tboxdescripcion.IsEnabled = true;
            elemvista.tbxdir.IsEnabled = true;
            elemvista.tboxtemp.IsEnabled = true;

        }

        private void Btnaceptar1_Click(object sender, RoutedEventArgs e)
        {          
            var elemvista = ((Vista)(grdagregar.Children[0]));
            var plistdatos = clpadre[listdatos.SelectedIndex];

            plistdatos.Titulo = elemvista.tboxtitulo.Text;
            plistdatos.Año = Convert.ToInt32(elemvista.tboxaño.Text);
            plistdatos.Rating = elemvista.tboxrating.Text;
            plistdatos.Genero = elemvista.cbgenero.Text;                      
            plistdatos.Descripcion = elemvista.tboxdescripcion.Text;
            plistdatos.Produccion = elemvista.tbxdir.Text;
            listdatos.Items.Refresh();
            elemvista.tboxtitulo.IsEnabled = false;
            elemvista.tboxaño.IsEnabled = false;
            elemvista.tboxrating.IsEnabled = false;
            elemvista.cbgenero.IsEnabled = false;
            elemvista.tboxdescripcion.IsEnabled = false;
            elemvista.tbxdir.IsEnabled = false;
            
        }

        private void Btneliminar_Click(object sender, RoutedEventArgs e)
        {
            clpadre.RemoveAt(listdatos.SelectedIndex);
        }

        private void Btncancelar1_Click(object sender, RoutedEventArgs e)
        {
            grdagregar.Children.Clear();
            btneditar.Visibility = Visibility.Hidden;
            btneliminar.Visibility = Visibility.Hidden;
            btnaceptar1.Visibility = Visibility.Hidden;
            btncancelar1.Visibility = Visibility.Hidden;
        }
    }
}
