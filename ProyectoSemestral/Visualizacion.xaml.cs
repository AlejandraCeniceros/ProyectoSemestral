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

namespace ProyectoSemestral
{
    /// <summary>
    /// Interaction logic for Visualizacion.xaml
    /// </summary>
    public partial class Visualizacion : UserControl
    {
        public Visualizacion()
        {
            InitializeComponent();
            box_Titulo_V.IsEnabled = false;
            box_Ano_V.IsEnabled = false;
            box_Director_V.IsEnabled = false;
            Cbx_Genero_V.IsEnabled = false;
            Cbx_Rating_V.IsEnabled = false;
            box_Productor_V.IsEnabled = false;
            box_Temporadas_V.IsEnabled = false;
            box_Sinopsis_V.IsEnabled = false;
            box_Descripcion_V.IsEnabled = false;

            
        }
    }
}
