using FreshFruit.Controller;
using FreshFruit.model;
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

namespace FreshFruit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, BucketEventListener
    {
        Seller Arsandi;

        public MainWindow()
        {
            InitializeComponent();

            Bucket keranjangBuah = new Bucket(2);
            BucketController bucketController = new BucketController(keranjangBuah, this);

            Arsandi = new Seller("Arsandi", bucketController);

            listBoxBucket.ItemsSource = keranjangBuah.findAll();
        }

        public void onFailed(string message)
        {
            MessageBox.Show(message, "Warning");
        }

        public void onSucceed(string message)
        {
            listBoxBucket.Items.Refresh();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Fruit Anggur = new Fruit("Anggur");
            Arsandi.AddFruit(Anggur);
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            Fruit Apel = new Fruit("Apel");
            Arsandi.AddFruit(Apel);
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            Fruit Pisang = new Fruit("Pisang");
            Arsandi.AddFruit(Pisang);
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            Fruit Jeruk = new Fruit("Jeruk");
            Arsandi.AddFruit(Jeruk);
        }
    }
}
