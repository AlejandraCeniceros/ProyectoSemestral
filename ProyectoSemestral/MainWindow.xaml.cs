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
using System.Collections.ObjectModel;

namespace ProyectoSemestral
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Info> info = new ObservableCollection<Info>();
        public MainWindow()
        {
            InitializeComponent();

            info.Add(new Pelicula("Psycho", 1960, "Alfred Hitchcock", "Suspenso", "La secretaria de Phoenix, Marion Crane (Janet Leigh), se fuga después de robar $40,000 dólares de su empleador con el fin de huir con su novio...", 5));
            info.Add(new Pelicula("El cubo", 1997, "Vinezo Natali", "terror", "Seis extraños deben de mantenerse unidos para lograr sobrevivir en un raro rompecabezas lleno de fatales sorpresas.", 3));
            info.Add(new Serie("Stranger Thigs", 2016, "Matt Duffer", "suspenso", 3, "Cuando un niño desaparece, sus amigos, la familia y la policía se ven envueltos...", 4));
            info.Add(new Serie("how i meet your mother", 2005, "Craig Thomas", "comedia-drama", 9, "Ted toma acción para encontrar el amor verdadero quien es ayudado por su incondicional amigo Barney, infalible en conocer mujeres, conociendo finalmente a Robin.", 4));

            lstCosas.ItemsSource = info;

            Star1.Visibility = Visibility.Hidden;
            Star2.Visibility = Visibility.Hidden;
            Star3.Visibility = Visibility.Hidden;
            Star4.Visibility = Visibility.Hidden;
            Star5.Visibility = Visibility.Hidden;

        }

        //AGREGAR NUEVO
        private void btn_Agregar_Click(object sender, RoutedEventArgs e)
        {

         //  grd_Cosas.Children.Add(new); 

            grd_Cosas.Children.Clear();
            grd_Cosas.Children.Add(new Agregar());

            btn_Agregar.Visibility = Visibility.Hidden;
            ORD_menormayor.Visibility = Visibility.Hidden;
            ORD_menormayor.Visibility = Visibility.Hidden;
            BtnOrdenarAZ.Visibility = Visibility.Hidden;
            BtnOrdenarZA.Visibility = Visibility.Hidden;

            Guardar.Visibility = Visibility.Visible;
            Cancelar.Visibility = Visibility.Visible;
            Editar.Visibility = Visibility.Hidden;
            Eliminar.Visibility = Visibility.Visible;
        }

        // AGREGAR A LA LISTA / GUARDAR PUES
        private void agregar1_Click(object sender, RoutedEventArgs e)
        {
            var ya = ((Agregar)(grd_Cosas.Children[0]));
            if (ya.Btn_Pelicula.IsChecked == true)
            {
                info.Add(new Pelicula(ya.box_Titulo.Text, Convert.ToInt32(ya.box_Ano.Text), ya.Cbx_Genero.Text, ya.box_Director.Text, ya.box_Sinopsis.Text, Convert.ToInt32(ya.Cbx_Rating.Text)));
            }

            if (ya.Btn_Serie.IsChecked == true)
            {
                info.Add(new Serie(ya.box_Titulo.Text, Convert.ToInt32(ya.box_Ano.Text),ya.Cbx_Genero.Text,Convert.ToInt32( ya.Cbx_Rating.Text), Convert.ToInt32(ya.box_Temporadas.Text), ya.box_Productor.Text, ya.Box_Descripcion.Text));
            }

            grd_Cosas.Children.Clear();
            btn_Agregar.Visibility = Visibility.Visible;
            ORD_menormayor.Visibility = Visibility.Visible;
            ORD_menormayor.Visibility = Visibility.Visible;
            BtnOrdenarAZ.Visibility = Visibility.Visible;
            BtnOrdenarZA.Visibility = Visibility.Visible;

            Guardar.Visibility = Visibility.Hidden;
            Cancelar.Visibility = Visibility.Hidden;
            Eliminar.Visibility = Visibility.Hidden;

        }

           private void Cancelar_Click(object sender, RoutedEventArgs e)
        {
            grd_Cosas.Children.Clear();
            btn_Agregar.Visibility = Visibility.Visible;
            ORD_menormayor.Visibility = Visibility.Visible;
            ORD_menormayor.Visibility = Visibility.Visible;
            BtnOrdenarAZ.Visibility = Visibility.Visible;
            BtnOrdenarZA.Visibility = Visibility.Visible;
            
            Guardar.Visibility = Visibility.Hidden;
            Cancelar.Visibility = Visibility.Hidden;
            Editar.Visibility = Visibility.Hidden;
            Eliminar.Visibility = Visibility.Hidden;


        }
        private void lstCosas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lstCosas.SelectedIndex != -1)
            {

                /* btn_Agregar.Visibility = Visibility.Hidden;
                 ORD_menormayor.Visibility = Visibility.Hidden;
                 ORD_menormayor.Visibility = Visibility.Hidden;
                 BtnOrdenarAZ.Visibility = Visibility.Hidden;
                 BtnOrdenarZA.Visibility = Visibility.Hidden;

                 Guardar.Visibility = Visibility.Hidden;
                 Cancelar.Visibility = Visibility.Visible;
                 Editar.Visibility = Visibility.Visible;
                 Eliminar.Visibility = Visibility.Hidden;
                 */

                grd_Cosas.Children.Clear();
                grd_Cosas.Children.Add(new Visualizacion());
                btn_Agregar.Visibility = Visibility.Hidden;
                ORD_menormayor.Visibility = Visibility.Hidden;
                ORD_menormayor.Visibility = Visibility.Hidden;
                BtnOrdenarAZ.Visibility = Visibility.Hidden;
                BtnOrdenarZA.Visibility = Visibility.Hidden;

                Guardar.Visibility = Visibility.Hidden;
                Cancelar.Visibility = Visibility.Visible;
                Editar.Visibility = Visibility.Visible;
                Eliminar.Visibility = Visibility.Visible;

               var ver = ((Visualizacion)(grd_Cosas.Children[0]));
                var contenido = info[lstCosas.SelectedIndex];
                if (contenido.Tipo == "Pelicula")
                {
                    ver._Tipo.Text = contenido.Tipo;
                    ver.box_Titulo_V.Text = contenido.Titulo;
                    ver.box_Ano_V.Text = contenido.Ano.ToString();
                    ver.box_Director_V.Text = contenido.Director;
                    ver.Cbx_Genero_V.Text = contenido.Genero;
                    ver.box_Sinopsis_V.Text = contenido.Sinopsis;
                    ver.Cbx_Rating_V.Text = contenido.Rating.ToString();

                    ver.lbl_Temporadas_V.Visibility = Visibility.Hidden;
                    ver.box_Temporadas_V.Visibility = Visibility.Hidden;
                    ver.box_Productor_V.Visibility = Visibility.Hidden;
                    ver.Box_Descripcion_V.Visibility = Visibility.Hidden;
                    ver.lbl_Descripcion_V.Visibility = Visibility.Hidden;

                    if (contenido.Rating == 1)
                    {
                        ver.Star1_V.Visibility = Visibility.Visible;
                    }
                    if (contenido.Rating == 2)
                    {
                        ver.Star1_V.Visibility = Visibility.Visible;
                        ver.Star2_V.Visibility = Visibility.Visible;
                    }
                    if (contenido.Rating == 3)
                    {
                        ver.Star1_V.Visibility = Visibility.Visible;
                        ver.Star2_V.Visibility = Visibility.Visible;
                        ver.Star3_V.Visibility = Visibility.Visible;

                    }
                    if (contenido.Rating == 4)
                    {
                        ver.Star1_V.Visibility = Visibility.Visible;
                        ver.Star2_V.Visibility = Visibility.Visible;
                        ver.Star3_V.Visibility = Visibility.Visible;
                        ver.Star4_V.Visibility = Visibility.Visible;
                    }
                    if (contenido.Rating == 5)
                    {
                        ver.Star1_V.Visibility = Visibility.Visible;
                        ver.Star2_V.Visibility = Visibility.Visible;
                        ver.Star3_V.Visibility = Visibility.Visible;
                        ver.Star4_V.Visibility = Visibility.Visible;
                        ver.Star5_V.Visibility = Visibility.Visible;
                    }

                    ver.box_Titulo_V.IsEnabled = false;
                    ver.box_Ano_V.IsEnabled = false;
                    ver.box_Director_V.IsEnabled = false;
                    ver.Cbx_Genero_V.IsEnabled = false;
                    ver.Cbx_Rating_V.IsEnabled = false;

                }

                if (contenido.Tipo == "Serie")
                {
                    ver._Tipo.Text = contenido.Tipo;
                    ver.box_Titulo_V.Text = contenido.Titulo;
                    ver.box_Ano_V.Text = contenido.Ano.ToString();
                    ver.box_Director_V.Visibility = Visibility.Hidden;
                    ver.Cbx_Genero_V.Text = contenido.Genero;
                    ver.box_Sinopsis_V.Visibility = Visibility.Hidden;
                    ver.Cbx_Rating_V.Visibility = Visibility.Hidden;

                    ver.lbl_Temporadas_V.Visibility = Visibility.Hidden;
                    ver.box_Temporadas_V.Visibility = Visibility.Hidden;
                    ver.box_Productor_V.Visibility = Visibility.Hidden;
                    ver.Box_Descripcion_V.Visibility = Visibility.Hidden;
                    ver.lbl_Descripcion_V.Visibility = Visibility.Hidden;

                    if (contenido.Rating == 1)
                    {
                        ver.Star1_V.Visibility = Visibility.Visible;
                    }
                    if (contenido.Rating == 2)
                    {
                        ver.Star1_V.Visibility = Visibility.Visible;
                        ver.Star2_V.Visibility = Visibility.Visible;
                    }
                    if (contenido.Rating == 3)
                    {
                        ver.Star1_V.Visibility = Visibility.Visible;
                        ver.Star2_V.Visibility = Visibility.Visible;
                        ver.Star3_V.Visibility = Visibility.Visible;

                    }
                    if (contenido.Rating == 4)
                    {
                        ver.Star1_V.Visibility = Visibility.Visible;
                        ver.Star2_V.Visibility = Visibility.Visible;
                        ver.Star3_V.Visibility = Visibility.Visible;
                        ver.Star4_V.Visibility = Visibility.Visible;
                    }
                    if (contenido.Rating == 5)
                    {
                        ver.Star1_V.Visibility = Visibility.Visible;
                        ver.Star2_V.Visibility = Visibility.Visible;
                        ver.Star3_V.Visibility = Visibility.Visible;
                        ver.Star4_V.Visibility = Visibility.Visible;
                        ver.Star5_V.Visibility = Visibility.Visible;
                    }

                    ver.box_Titulo_V.IsEnabled = false;
                    ver.box_Ano_V.IsEnabled = false;
                    ver.box_Director_V.IsEnabled = false;
                    ver.Cbx_Genero_V.IsEnabled = false;
                    ver.Cbx_Rating_V.IsEnabled = false;

                }



            }


        }

       
    }
}
