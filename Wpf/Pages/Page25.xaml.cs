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
    /// Логика взаимодействия для Page25.xaml
    /// </summary>
    public partial class Page25 : Page
    {
        public Page25()
        {
            InitializeComponent();
        }

        private void BtnTask11_Click(object sender, RoutedEventArgs e)
        {

            ArrayProcessor25 class1 = new ArrayProcessor25();

            MessageBox.Show($"Ответ = {class1.CountEvenNumber()}", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

        }
    }
}

