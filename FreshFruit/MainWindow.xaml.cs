using FreshFruit.Controller;
using FreshFruit.Model;
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
using BucketController = FreshFruit.Controller.BucketController;

namespace FreshFruit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window 
    {
        Seller toni;
        private object listBoxBucket;

        public MainWindow()
        {
            InitializeComponent();

            Bucket keranjangBuah = new Bucket(2);
            BucketController bucketcontroller = new BucketController(keranjangBuah, this);

            toni = new Seller("Toni", bucketcontroller);

            listBoxBucket.ItemsSource = keranjangBuah.findAll();
        }

        private void OnButtonAddAnggurClicked(object sender, RoutedEventArgs e)
        {
            Fruit anggur = new Fruit("anggur");
            toni.addFruit(anggur);

            listBoxBucket.Items.Refresh();
        }

        private void OnButtonAddAppleClicked(object sender, RoutedEventArgs e)
        {
            Fruit Apel = new Fruit("Apel");
            toni.addFruit(Apel);

            listBoxBucket.Items.Refresh();
        }

        private void OnButtonAddBananaClicked(object sender, RoutedEventArgs e)
        {
            Fruit Pisang = new Fruit("Pisang");
            toni.addFruit(Pisang);

            listBoxBucket.Items.Refresh();
        }

        private void OnButtonAddOrangeClicked(object sender, RoutedEventArgs e)
        {
            Fruit Jeruk = new Fruit("Jeruk");
            toni.addFruit(Jeruk);

            listBoxBucket.Items.Refresh();
        }

        public void onSucced(string message)
        {
            listBoxBucket.Items.Refresh();
        }

        public void onFailed(string message)
        {
            MessageBox.Show(message);
        }
    }
}
