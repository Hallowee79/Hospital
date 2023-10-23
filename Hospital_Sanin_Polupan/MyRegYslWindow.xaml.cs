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
using static Hospital_Sanin_Polupan.ClassHelper.EfClass;
using static Hospital_Sanin_Polupan.ClassHelper.PatientDataClass;

namespace Hospital_Sanin_Polupan
{
    /// <summary>
    /// Логика взаимодействия для MyRegYslWindow.xaml
    /// </summary>
    public partial class MyRegYslWindow : Window
    {
        public MyRegYslWindow()
        {
            InitializeComponent();
            CmbProcedure.ItemsSource = Context.MedicalService.ToList();
            CmbProcedure.SelectedIndex = 0;
            CmbProcedure.DisplayMemberPath = "TitleServise";
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow1 mainWindow1 = new MainWindow1();
            mainWindow1.Show();
            this.Hide();
        }

        private void BtnRegProcedur_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            var userAuth = Context.MedicalService.ToList().
            Where(i => i.TitleServise == Convert.ToString(CmbProcedure.Text)).FirstOrDefault();
            int b = userAuth.ID;
            double bb = Convert.ToDouble(userAuth.Cost);
            int bbb = random.Next(1, 35);
            DateTime dateTime = new DateTime();
            dateTime = Datee.SelectedDate.Value.Date;
            Appointment appointment = new Appointment();
            appointment.IDMedicalService = b;
            appointment.IDEmployee = bbb;
            appointment.DateServise = dateTime;
            Context.Appointment.Add(appointment);
            Context.SaveChanges();
            var app = Context.Appointment.ToList().Where(i => i.DateServise == dateTime&& i.IDMedicalService == b&& i.IDEmployee == bbb).FirstOrDefault();
            int bbbb = app.ID;
            Order order = new Order();
            order.IDAppointment = bbbb;
            order.IDPatient = a;
            order.TotalPrice = Convert.ToDecimal(bb);
            Context.Order.Add(order);
            Context.SaveChanges();
            MessageBox.Show("Вы записались на услугу");
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
