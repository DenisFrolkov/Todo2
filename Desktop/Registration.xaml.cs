using System.Windows;
using Desktop.Repository;
using Entities.Models;

namespace Desktop
{
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Button_Register(object sender, RoutedEventArgs e)
        {
            var user = "Такой пользователь уже существует"; 
            var Name = Validator.ValidName(TextBoxName.Text);
            var Email = Validator.ValidEmail(TextBoxEmail.Text);
            var Password = Validator.ValidPass(TextBoxPassword.Text);
            var Repeat = Validator.ValidRepeat(TextBoxPassword.Text, TextBoxRepeat.Text);
            if (Name != null)
            {
                MessageBox.Show(Name);
            }
            if (Email != null)
            {
                MessageBox.Show(Email);
            }
            if (Password != null)
            {
                MessageBox.Show(Password);
            }
            if (Repeat != null)
            {
                MessageBox.Show(Repeat);
            }

            if (Name == null && Email == null && Password == null && Repeat == null)
            {
                var loginUser = UserRepository.RegistrationUser(new UserModel(TextBoxName.Text, TextBoxEmail.Text, TextBoxPassword.Text));
                if (loginUser != null)
                {
                    var wind = new MainEmpty();
                    wind.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show(user);  
                }
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            var wind = new MainWindow();
            wind.Show();
            Hide();
        }
    }
}