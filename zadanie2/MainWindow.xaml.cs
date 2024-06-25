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

namespace pz2_penkina
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            User user = new User();
            user.name = textBox1.Text;
            user.surname = textBox2.Text;
            user.phone = textBox3.Text;
            user.email = textBox4.Text;
            MessageBox.Show($"Ваше имя: {user.name}\nВаша фамилия: {user.email}\nВаш номер телефона: {user.phone}\nВаша почта: {user.email}", "Данные успешно занесены!");

        }
        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
    struct User
    {
        public string name;
        public string surname;
        public string phone;
        public string email;
    }

}

