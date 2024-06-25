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

namespace pz1_penkina
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
            user.email = textBox2.Text;
            user.password = textBox3.Text;
            MessageBox.Show($"Ваше имя: {user.name}\nВаша почта: {user.email}\nВаш пароль: {user.password}\nСпасибо за регистрацию!", "Регистрация прошла успешно!");
        }
    }
    struct User
    {
        public string name;
        public string email;
        public string password;

    }
}

