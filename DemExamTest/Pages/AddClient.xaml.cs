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
using DemExamTest.Model;
namespace DemExamTest.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddClient.xaml
    /// </summary>
    public partial class AddClient : Page
    {
        public AddClient()
        {
            InitializeComponent();
            gen.ItemsSource = GenderMass;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Client client = new Client()
            {
                LastName = LastName.Text.ToString(),
                FirstName = FirstName.Text.ToString(),
                Patronymic = Patronymic.Text.ToString(),
                Birthday = (DateTime)Birthday.SelectedDate,
                RegistrationDate = (DateTime)RegistrationDate.SelectedDate,
                Email = Email.Text.ToString(),
                Phone = Phone.Text.ToString(),
                GenderCode ="2",
                PhotoPath = ""
            };
            barhatnie_brovkiEntities.GetContext().Client.Add(client);
            barhatnie_brovkiEntities.GetContext().SaveChanges();
            MessageBox.Show("Данные успешно сохранены!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Information);

        }
        public string[] GenderMass { get; set; } =
        {
            "Мужчина",
            "Женщина"

        };
    }
}
