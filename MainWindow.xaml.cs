using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bevasarlolista
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<string> lista = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            lb.ItemsSource = lista;
        }

        private void btnHozzadas_Click(object sender, RoutedEventArgs e)
        {
            Hozzaadas();
        }

        private void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Hozzaadas();
            }
        }

        private void Hozzaadas()
        {
            if (tb.Text.Length > 0)
            {
                lista.Add(tb.Text);
                lb.Items.Refresh();
                tb.Text = "";
                lblCounter.Content = lista.Count();
            }
        }

        private void btnTorles_Click(object sender, RoutedEventArgs e)
        {
            lista.Remove((string)lb.SelectedItem);
            lb.Items.Refresh();
            lblCounter.Content = lista.Count();
        }

        private void btnMindentTorles_Click(object sender, RoutedEventArgs e)
        {
            lista.Clear();
            lb.Items.Refresh();
            lblCounter.Content = lista.Count();
        }
    }
}