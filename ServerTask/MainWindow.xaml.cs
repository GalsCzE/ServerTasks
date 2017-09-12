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
using ServerTask.Interfaces;
using ServerTask.Json;
using ServerTask.Properties;
using ServerTask.Task_Value;
using ServerTask.WebClient;
using System.Collections.ObjectModel;

namespace ServerTask
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Headers> _listvalue = new ObservableCollection<Headers>();

        public ObservableCollection<Headers> ListCollection
        {
            get { return _listvalue; }
            set { _listvalue = value; }
        }
        public MainWindow()
        {
            InitializeComponent();
            ListBox.ItemsSource = ListCollection;

        }

        public async Task GetHeadersListAsync()
        {
            await Task.Run(() =>
            {
                Console.WriteLine(Thread.CurrentTheard.IsBackground);
                IWebClient webClient = new TaskWeb();
            });
        }

        private void Task_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
