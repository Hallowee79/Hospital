using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using static Hospital_Sanin_Polupan.ClassHelper.EfClass;
using static Hospital_Sanin_Polupan.ClassHelper.PatientAcauntClass;
using static Hospital_Sanin_Polupan.ClassHelper.PatientDataClass;
namespace Hospital_Sanin_Polupan

{
    /// <summary>
    /// Логика взаимодействия для MyDataWindow.xaml
    /// </summary>
    public partial class MyDataWindow : Window
    {
        public MyDataWindow()
        {
            InitializeComponent();
            GetListService();
        }
        private void GetListService()
        {
            var pati = Context.Patient.ToList();
            var client = pati.FirstOrDefault(i => (i.ID == a));
            FIO.Text = client.LName.ToString() + " " + client.FName.ToString() + " " + client.MName.ToString();
            Birthday.Text = client.DateOfBirthday.ToString();
            Phone.Text = client.Phone.ToString();
            if (client.IDGender == 1)
            {
                Gender.Text = "Мужчина";
            }
            else
            {
                Gender.Text = "Женщина";
            }
            Addres.Text = client.Address.ToString();
            EMail.Text = client.Email.ToString();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow1 mainWindow1 = new MainWindow1();
            mainWindow1.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {


            MyDataRedactorWindow myDataRedactorWindow = new MyDataRedactorWindow();
            myDataRedactorWindow.Show();
            this.Hide();
        }
    }
}
