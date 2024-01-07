using System.Collections;
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

namespace WpfApp9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            listView.Items.Add("a");
            listView.Items.Add("a");
            listView.Items.Add("a");
            listView.Items.Add("a");
            listView.Items.Add("a");
            listView.Items.Add("a");
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
           listView.Items.Add(txtEntry.Text);
          txtEntry.Clear();
            

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
           // int index = listView.SelectedIndex; bittalab uchirsa buladi
            var item = listView.SelectedItems;
            var result = MessageBox.Show($"uchib ketyapti {item.Count} ta ","Sure?" ,MessageBoxButton.YesNo);

            if(result == MessageBoxResult.Yes)
            {
                var arrayList = new ArrayList(item);
                foreach( var item2 in arrayList)
                {
                    listView.Items.Remove(item2);
                }

            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            listView.Items.Clear();
        }
    }
}