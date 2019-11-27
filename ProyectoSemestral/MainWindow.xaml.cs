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

            Pelicula pelicula1 = new Pelicula("Psycho", 1960, "Alfred Hitchcock", "Suspenso", "La secretaria de Phoenix, Marion Crane (Janet Leigh), se fuga después de robar $40,000 dólares de su empleador con el fin de huir con su novio...", 5);
            Pelicula pelicula2 = new Pelicula("El cubo", 1997, "Vinezo Natali", "terror", "Seis extraños deben de mantenerse unidos para lograr sobrevivir en un raro rompecabezas lleno de fatales sorpresas.", 3);
            Serie serie1 = new Serie("Stranger Thigs", 2016, "Matt Duffer", "suspenso", 3, "Cuando un niño desaparece, sus amigos, la familia y la policía se ven envueltos...", 4);
            Serie serie2 = new Serie("how i meet your mother", 2005, "Craig Thomas", "comedia-drama", 9, "Ted toma acción para encontrar el amor verdadero quien es ayudado por su incondicional amigo Barney, infalible en conocer mujeres, conociendo finalmente a Robin.", 4);


            info.Add(pelicula1);
            info.Add(pelicula2);
            info.Add(serie1);
            info.Add(serie2);

        
        }
    }
}
