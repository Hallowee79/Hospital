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
    /// Логика взаимодействия для MainWindow1.xaml
    /// </summary>
    public partial class MainWindow1 : Window
    {
        public MainWindow1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MyDataWindow myDataWindow = new MyDataWindow();
            myDataWindow.Show();
            this.Hide();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            MyHistoryWindow myHistoryWindow = new MyHistoryWindow();
            myHistoryWindow.Show();
            this.Hide();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MyRegYslWindow myRegYslWindow = new MyRegYslWindow();
            myRegYslWindow.Show();
            this.Hide();
        }

        private void Btnpred_Click(object sender, RoutedEventArgs e)
        {
            MyPredWindow myPredWindow = new MyPredWindow();
            myPredWindow.Show();
            this.Hide();
        }
    }
}
