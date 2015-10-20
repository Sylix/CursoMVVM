using System.Windows;

namespace CursoMVVM
{
    /// <summary>
    /// Interaction logic for ColecaoBindingWindow.xaml
    /// </summary>
    public partial class ColecaoBindingWindow : Window
    {
        public ColecaoBindingWindow()
        {
            InitializeComponent();

            Estado sp = new Estado()
            {
                Municipios = new[] {"Santo André", "São Bernardo do Campo", "São Caetano", "São Paulo"}
            };

            DataContext = sp;
        }
    }

    class Estado
    {
        public string[] Municipios { get; set; }
    }
}