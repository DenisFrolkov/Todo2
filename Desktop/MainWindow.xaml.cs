﻿using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Desktop.Repository;
using Entities.Models;

namespace Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Manager.CurrentWindow = this;
        }

        private void ButtonEnter(object sender, RoutedEventArgs e)
        {
            var user = "Неверно введены логин или пароль";
            var loginUser = UserRepository.LoginUser(new UserModel("", TextBoxEmail.Text, TextBoxPassword.Text));
            if (loginUser != null)
            {
                var wind = new MainEmpty();
                wind.Show();
                Hide();

                //Manager.CurrentWindow.Show();
                //this.Close();
            }
            else
            {
                MessageBox.Show(user);  
            }
        }

        private void ButtonRegist(object sender, RoutedEventArgs e)
        {
            var wind = new Registration();
            wind.Show();
            Manager.CurrentWindow.Hide();

            //Back

            Manager.CurrentWindow.Show();
            this.Close();
        }
    }
}