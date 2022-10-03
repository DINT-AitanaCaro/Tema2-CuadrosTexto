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

namespace Tema2_CuadrosTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            nombreTextBox.Tag = ayudaNombreTextBlock;
            apellidoTextBox.Tag = ayudaApellidoTextBlock;
        }

        private void NombreApellido_TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox t = (TextBox)sender;
            TextBlock tbl = (TextBlock)t.Tag;
            if (e.Key == Key.F1)
            {
                if (tbl.IsVisible)
                    tbl.Visibility = Visibility.Hidden;
                else
                    tbl.Visibility = Visibility.Visible;
            }
        }
        private void Edad_TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox t = (TextBox)sender;
            if (e.Key == Key.F2)
            {
                if (int.TryParse(edadTextBox.Text, out _)) ayudaEdadTextBlock.Visibility = Visibility.Hidden;
                else ayudaEdadTextBlock.Visibility = Visibility.Visible;
            }
        }
    }
}
