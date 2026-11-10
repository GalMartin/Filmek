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

namespace Filmek
{
    public class Filmadatok
    {
        public string Cim { get; set; }
        public string Mufaj { get; set; }
        public int Hossz { get; set; }
        public double Ertekeles { get; set; }


        public Filmadatok(string cim, string mufaj, int hossz, double ertekeles)
        {
            Cim = cim;
            Mufaj = mufaj;
            Hossz = hossz;
            Ertekeles = ertekeles;
        }
    }


    public partial class MainWindow : Window
    {
        List<Filmadatok> Filmek = new List<Filmadatok>();
        public MainWindow()
        {
            InitializeComponent();


            Filmek = new List<Filmadatok>
            {
                new Filmadatok("Csillagok háborúja", "sci-fi", 121, 8.6),
                new Filmadatok("Titanic", "dráma", 195, 7.8),
                new Filmadatok("A Gyűrűk Ura", "fantasy", 201, 8.8),
                new Filmadatok("Mátrix", "sci-fi", 136, 8.7),
                new Filmadatok("Shrek", "animáció", 90, 7.9)
            };
        }

        private void betoltes(object sender, RoutedEventArgs e)
        {
            datagrid.ItemsSource = Filmek;
            datagrid.Items.Refresh();
        }

        private void hanyfilm(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"A listában {Filmek.Count} film található.");
        }
    }
}