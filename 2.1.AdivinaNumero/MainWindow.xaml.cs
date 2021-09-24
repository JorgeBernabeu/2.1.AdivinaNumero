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

namespace _2._1.AdivinaNumero
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int NumeroAAdivinar { get; set; }
        
        public MainWindow()
        {

            InitializeComponent();

            GeneraNuevoNumeroAleatorio();

        }
        public int GeneraNuevoNumeroAleatorio()
        {
            Random rnd = new Random();

            NumeroAAdivinar = rnd.Next(0, 101);

            return NumeroAAdivinar;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (int.Parse(NombreTextBox.Text) == NumeroAAdivinar)
                TextoMostrado.Text = "Has Acertado! :D";

            if (int.Parse(NombreTextBox.Text) > NumeroAAdivinar)
                TextoMostrado.Text = "Te Has Pasado D:";

            if (int.Parse(NombreTextBox.Text) < NumeroAAdivinar)
                TextoMostrado.Text = "Te Has Quedado Corto :(";
        }

        private void ReiniciarButton_Click(object sender, RoutedEventArgs e)
        {

            TextoMostrado.Text = "";

            NombreTextBox.Text = "";

            GeneraNuevoNumeroAleatorio();

        }
    }
}
