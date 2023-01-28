using System.Windows;

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
            var Name = Validator.ValidName(TextBoxName.Text);
            var Email = Validator.ValidEmail(TextBoxEmail.Text);
            var Password = Validator.ValidPass(TextBoxPass.Text);
            var Repeat = Validator.ValidRepeat(TextBoxPass.Text, TextBoxRepeat.Text);
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

            if (Name == null || Email == null || Password == null || Repeat == null)
            {
                var wind = new MainEmpty();
                wind.Show();
                Manager.CurrentWindow.Close();
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            var wind = new MainWindow();
            wind.Show();
            Manager.CurrentWindow.Hide();
            
            Manager.CurrentWindow.Show();
            this.Close();
        }
    }
}