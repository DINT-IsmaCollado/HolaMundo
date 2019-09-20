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

namespace HolaMundo
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (NombreTextBox.Text != "")
                TextoTextBlock.Text = "Hola " + NombreTextBox.Text + "!";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NombreTextBox.Text = "";
            TextoTextBlock.Text = "Hola mundo!";
        }
    }
}
