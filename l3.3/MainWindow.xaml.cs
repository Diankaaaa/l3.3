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

namespace l3._3
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                double res, result = 0;
                //res - хранит промежуточный результат
                //result - конечный результат

                double num = 3;
                double st = 2; //Степень числа

                //Переменные для вычисления факториала
                double f = 1;
                double n = 1; 

                //Получаем от пользователя значения
                double x = double.Parse(Input.Text);
                double p = double.Parse(K.Text); //Колчество итераций

                for (int i = 0; i < p; i++)
                {
                    //Вычисление факториала
                    f *= n;
                    ++n;

                    res = (num * Math.Pow(x, st)) / f;

                    st += 2;
                    num += 2;

                    result += res;
                }

                result += 1;
                Output.Text = result.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
