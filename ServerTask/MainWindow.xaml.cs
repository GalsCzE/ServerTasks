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
using System.Threading;

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
            //await Task.Run(() =>
            //{
                Console.WriteLine(Thread.CurrentThread.IsBackground);
                IWebClient webClient = new TaskWeb();
                List<Headers> heads = webClient.GetHeadersListAsync().Result;

                if (heads != null && heads.Count != 0)
                {
                    ObservableCollection<Headers> hed = new ObservableCollection<Headers>(heads);

                await Dispatcher.InvokeAsync(() =>
                 {
                     MessageBox.Show("Připojeno");
                 });
                }
                else
                {
                    await Dispatcher.InvokeAsync(() =>
                    {
                        MessageBox.Show("Error!!");
                    });
                }
           // });
        }

        private void SetHeadersItemSource(ObservableCollection<Headers> hed)
        {
            _listvalue = hed;
            ListBox.ItemsSource = ListCollection;
        }

        private void Task_Click(object sender, RoutedEventArgs e)
        {
            GetHeadersListAsync();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
