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
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox t = (TextBox)sender;
            string tag = (string)t.Tag;
            if (e.Key == Key.F1)
            {
                if (tag.Equals("nombre"))
                {
                    if (ayudaNombreTextBlock.IsVisible)
                        ayudaNombreTextBlock.Visibility = Visibility.Hidden;
                    else
                        ayudaNombreTextBlock.Visibility = Visibility.Visible;
                }
                else
                {
                    if (ayudaApellidoTextBlock.IsVisible)
                        ayudaApellidoTextBlock.Visibility = Visibility.Hidden;
                    else
                        ayudaApellidoTextBlock.Visibility = Visibility.Visible;
                }
            }
            else if(e.Key == Key.F2 && t.Tag.Equals("edad"))
            {
                if (int.TryParse(edadTextBox.Text,out _)) ayudaEdadTextBlock.Visibility = Visibility.Hidden;
                else ayudaEdadTextBlock.Visibility = Visibility.Visible;
            }
        }
    }
}
