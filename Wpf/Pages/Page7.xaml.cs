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
    /// Логика взаимодействия для Page7.xaml
    /// </summary>
    public partial class Page7 : Page
    {
        public Page7()
        {
            InitializeComponent();
        }

        private void BtnTask11_Click(object sender, RoutedEventArgs e)
        {


            ArrayProcessor7 class1 = new ArrayProcessor7();

            MessageBox.Show($"Ответ = {class1.GetArrayAsString()} \n {class1.CalculateResult()}", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

        }
    }
}

