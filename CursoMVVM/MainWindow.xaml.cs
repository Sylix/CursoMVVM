using System.Windows;

namespace CursoMVVM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Componentes_Click(object sender, RoutedEventArgs e)
        {
            var dlg = new ComponentesBindingWindow();
            dlg.ShowDialog();
        }

        private void Objetos_Click(object sender, RoutedEventArgs e)
        {
            var dlg = new ObjetoBindingWindow();
            dlg.ShowDialog();
        }

        private void Colecoes_Click(object sender, RoutedEventArgs e)
        {
            var dlg = new ColecaoBindingWindow();
            dlg.ShowDialog();
        }
    }
}