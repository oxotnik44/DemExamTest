using DemExamTest.Model;
using DemExamTest.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
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

namespace DemExamTest
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          
        }

        private void addClient_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void service_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void clientAdd_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void BtnAuth_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void auth_Click(object sender, RoutedEventArgs e)
        {
            if(firstName.Text == "" && lastName.Text == "")
            {
                MessageBox.Show("фыв");
            }
            else
            {
                var client = barhatnie_brovkiEntities.GetContext().Client.FirstOrDefault(p=>p.FirstName == firstName.Text && p.LastName==lastName.Text);
                if(client != null)
                {
                    MessageBox.Show("кайф");

                    Main main = new Main();
                    main.Show();
                    Close();
                }
               
            }
           
        }
    }
}
