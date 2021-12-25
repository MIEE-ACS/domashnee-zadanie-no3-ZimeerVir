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

namespace dz3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, RoutedEventArgs e)
        {
            string first_text = tb_input.Text;
            string alfavit_RU = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            string alfavit_ru = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            string result = "";
            int step = 2;
            foreach (char letter in first_text) {
                if (Char.IsDigit(letter)) {
                    result = "Вводим только символы русского алфавита";
                    break;
                }
                
                if (Char.IsUpper(letter)) {
                    var place = alfavit_RU.IndexOf(letter.ToString());
                    int new_place = place + step;
                    result += alfavit_RU[new_place];
                }
                else
                {
                    var place = alfavit_ru.IndexOf(letter.ToString());
                    int new_place = place + step;
                    result += alfavit_ru[new_place];
                }
                
            }
            tb_output.Text = result;

        }
    }
}
