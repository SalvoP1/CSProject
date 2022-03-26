using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace CSProject
{

    public partial class MainWindow : Window
    {

        Tische[] Tische = new Tische[20];

        public MainWindow()
        {
            InitializeComponent();
            
            // Clock for Service Screen
            Task.Run(() =>
            {
                while (true)
                {
                    App.Current.Dispatcher.Invoke(() =>
                    {
                        this.Clock.Text = DateTime.Now.ToString("HH:mm");
                    });
                    Thread.Sleep(5000);
                }
            });
            

            // Initialisation of Tisch Object Array
            for (int i = 0; i < Tische.Length; i++)
            {
                Tische[i] = new Tische() { TischNr = i + 1 };
            }
        }



        private void ChangeToTableView(object sender, RoutedEventArgs e)
        {
            MainGrid.Visibility = Visibility.Collapsed;
            TableView.Visibility = Visibility.Visible;

            Button TischButton = (Button)sender;
            int Nr = Convert.ToInt32(TischButton.Content);

            TableView.LoadTable(Tische[Nr - 1]);
        }

        private void TableView_back(object sender, EventArgs e)
        {
            TableView.Visibility = Visibility.Collapsed;
            MainGrid.Visibility = Visibility.Visible;
        }

        private void OnTimedEvent(Object Source, System.Timers.ElapsedEventArgs e)
        {
            Clock.Text = DateTime.Now.ToString("HH:mm");
        }
    }
}
