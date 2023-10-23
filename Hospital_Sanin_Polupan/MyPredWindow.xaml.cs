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
    /// Логика взаимодействия для MyPredWindow.xaml
    /// </summary>
    public partial class MyPredWindow : Window
    {
        public static DateTime LoclData = new DateTime();
        public class item
        {
            public string Column1{ get; set;}
            public string Column2 { get; set; }
            public string Column3 { get; set; }
        }
        
        public MyPredWindow()
        {
            InitializeComponent();
            LoclData = DateTime.UtcNow;
            item itemm = new item();
            var or = Context.Order.ToList().
            Where(i => i.IDPatient == a).FirstOrDefault();
            int b = or.IDAppointment;
            var app = Context.Appointment.ToList().Where(i => i.ID == b).FirstOrDefault();
            if (app.Employee == null)
            {
                MessageBox.Show("Вы не записаны на приём");
                MainWindow1 mainWindow1 = new MainWindow1();
                mainWindow1.Show();
                this.Hide();
            }
            else
            {
                int bbb = app.IDEmployee;
                int bb = app.IDMedicalService;
                var ms = Context.MedicalService.ToList().Where(i => i.ID == bb).FirstOrDefault();
                var em = Context.Employee.ToList().Where(i => i.ID == bbb).FirstOrDefault();
                itemm.Column3 = em.LName.ToString() + " " + em.FName.ToString() + " " + em.MName.ToString();
                itemm.Column2 = ms.TitleServise;
                itemm.Column1 = Convert.ToString(app.DateServise);
                DataGrid.Items.Add(itemm);
            }
           
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow1 mainWindow1 = new MainWindow1();
            mainWindow1.Show();
            this.Hide();
        }
    }
}
