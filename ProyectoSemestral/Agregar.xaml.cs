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
using System.Windows.Shapes;


namespace ProyectoSemestral
{
    /// <summary>
    /// Interaction logic for Agregar.xaml
    /// </summary>
    public partial class Agregar : Window
    {
        public Agregar()
        {
            InitializeComponent();
            Btn_Pelicula.IsChecked = true;
        }

        private void Btn_Pelicula_Checked(object sender, RoutedEventArgs e)
        {
            if (Btn_Pelicula.IsChecked == true)
            {
               
                lbl_Temporadas.Visibility = Visibility.Hidden;
                box_Temporadas.Visibility = Visibility.Hidden;
            }


        }

        private void Btn_Serie_Checked(object sender, RoutedEventArgs e)
        {
            if(Btn_Serie.IsChecked == true){
                
                lbl_Temporadas.Visibility = Visibility.Visible;
                box_Temporadas.Visibility = Visibility.Visible;
;        }
    }
}
