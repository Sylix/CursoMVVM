using System.Windows;

namespace CursoMVVM
{
    /// <summary>
    /// Interaction logic for ObjetoBindingWindow.xaml
    /// </summary>
    public partial class ObjetoBindingWindow : Window
    {
        public ObjetoBindingWindow()
        {
            InitializeComponent();

            Pessoa eu = new Pessoa()
            {
                Nome = "Valério",
                Sobrenome = "Ferreira"
            };

            DataContext = eu;
        }
    }

    class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
    }
}