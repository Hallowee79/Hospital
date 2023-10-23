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
using static Hospital_Sanin_Polupan.ClassHelper.PatientDataClass;

namespace Hospital_Sanin_Polupan
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

        private void TBLogin_MouseEnter(object sender, MouseEventArgs e)
        {
            if (TBLogin.Text == "Логин")
            {
                TBLogin.Text = "";
            }

        }

        private void TBLogin_MouseLeave(object sender, MouseEventArgs e)
        {
            if (TBLogin.Text == "")
            {
                TBLogin.Text = "Логин";
            }
        }

        private void TBPassword_MouseEnter(object sender, MouseEventArgs e)
        {
            if (TBPassword.Text == "Пароль")
            {
                TBPassword.Text = "";
            }
        }

        private void TBPassword_MouseLeave(object sender, MouseEventArgs e)
        {
            if (TBPassword.Text == "")
            {
                TBPassword.Text = "Пароль";
            }
        }

        private void NewRegistation_Click(object sender, RoutedEventArgs e)
        {
            RegWindow regWindow = new RegWindow();
            regWindow.Show();
            this.Hide();
        }

        private void Authbutton_Click(object sender, RoutedEventArgs e)
        {
            var userAuth = ClassHelper.EfClass.Context.Patient.ToList().
               Where(i => i.Login == TBLogin.Text && i.Password == TBPassword.Text).FirstOrDefault();
            a = userAuth.ID;
            if (userAuth != null)
            {
                MainWindow1 mainWindow1 = new MainWindow1();
                mainWindow1.Show();
                this.Close();
            }
        }
    }
}
