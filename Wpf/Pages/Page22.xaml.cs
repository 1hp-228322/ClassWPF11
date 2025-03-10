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
using ClassWPF11;
using ClassWPF11.Classes;

namespace Wpf.Pages
{
    /// <summary>
    /// Логика взаимодействия для Page22.xaml
    /// </summary>
    public partial class Page22 : Page
    {
        public Page22()
        {
            InitializeComponent();
        }

        private void BtnTask11_Click(object sender, RoutedEventArgs e)
        {


            //double G = Math.Exp(2 * Convert.ToDouble(TbY.Text)) + Math.Sin(Convert.ToDouble(Tbf.Text)) / Math.Log10(3.8 * Convert.ToDouble(TbY.Text) + Convert.ToDouble(Tbf.Text));
            ArrayProcessor1 class1 = new ArrayProcessor1();

            MessageBox.Show($"Ответ = {class1.CountEvenNumber()}", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

        }
    }
}
