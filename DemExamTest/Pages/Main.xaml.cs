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
using System.Windows.Shapes;

namespace DemExamTest.Pages
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        public Main()
        {
            InitializeComponent();
        }

        private void frame_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {

        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            AddClient addClient = new AddClient();
            frame.Content = addClient;
        }

        private void Order_Click(object sender, RoutedEventArgs e)
        {
            Order order = new Order();
            frame.Content = order;
        }

        private void View_Click(object sender, RoutedEventArgs e)
        {
            View view = new View();
            frame.Content = view;
        }
    }
}
