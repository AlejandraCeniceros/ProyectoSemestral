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

            Pelicula pelicula1 = new Pelicula("Psycho", 1960, "Alfred Hitchcock", "Suspenso", "La secretaria de Phoenix, Marion Crane (Janet Leigh), se fuga después de robar $40,000 dólares de su empleador con el fin de huir con su novio...", 4);
            Pelicula pelicula2 = new Pelicula("El cubo", 1997, "Vinezo Natali", "terror","Seis extraños deben de mantenerse unidos para lograr sobrevivir en un raro rompecabezas lleno de fatales sorpresas.", 3);

            info.Add(new Info("Psycho", 1960, "Alfred Hitchcock", "Suspenso", "La secretaria de Phoenix, Marion Crane (Janet Leigh), se fuga después de robar $40,000 dólares de su empleador con el fin de huir con su novio...", 4));
        }

       
    }
}
