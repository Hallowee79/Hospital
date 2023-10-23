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

namespace Hospital_Sanin_Polupan
{
    /// <summary>
    /// Логика взаимодействия для RegWindow.xaml
    /// </summary>
    public partial class RegWindow : Window
    {
        public RegWindow()
        {
            InitializeComponent();
        }

        private void NewRegistation_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }

        private void Authbutton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBLastName.Text))
            {
                MessageBox.Show("Поле Фамилия не заполнено");
                return;
            }

            if (string.IsNullOrWhiteSpace(TBFirstName.Text))
            {
                MessageBox.Show("Поле Имя не заполнено");
                return;
            }
            if (string.IsNullOrWhiteSpace(TBPhone.Text))
            {
                MessageBox.Show("Поле Телефон не заполнено");
                return;
            }
            if (string.IsNullOrWhiteSpace(TBAdress.Text))
            {
                MessageBox.Show("Поле Адрес не заполнено");
            }
            if (string.IsNullOrWhiteSpace(TBEmail.Text))
            {
                MessageBox.Show("Поле Почта не заполнено");
            }
            if (string.IsNullOrWhiteSpace(TBLogin.Text))
            {
                MessageBox.Show("Заполните логин");
                return;
            }
            if (string.IsNullOrWhiteSpace(TBPassword.Text))
            {
                MessageBox.Show("Заполните пароль");
                return;
            }

            Patient addPatient = new Patient();
            addPatient.Login = TBLogin.Text;
            addPatient.Password = TBPassword.Text;
            addPatient.LName = TBFirstName.Text;
            addPatient.FName = TBLastName.Text;
            if (TBMName.Text != string.Empty)
            {
                addPatient.MName = TBMName.Text;
            }
            addPatient.Phone = TBPhone.Text;
            if (R1.IsChecked == true)
            {
                addPatient.IDGender = 1;
            }
            else
            {
                addPatient.IDGender = 2;
            }
            addPatient.Address = TBAdress.Text;
            addPatient.Email = TBEmail.Text;
            addPatient.DateOfBirthday = Convert.ToDateTime(Data.Text);

            ClassHelper.EfClass.Context.Patient.Add(addPatient);
            ClassHelper.EfClass.Context.SaveChanges();
            MessageBox.Show("Пользоваталь успешно добавлен");
        }
    }
}
