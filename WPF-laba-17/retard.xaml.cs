using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.IO;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF_laba_17
{
    /// <summary>
    /// Логика взаимодействия для retard.xaml
    /// </summary>
    public partial class retard : Window
    {
        public retard()
        {
            InitializeComponent();
        }

        public int count;

        private void Dima(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFD = new()
            {
                Filter = "txt files (*.txt)|*.txt"
            };

            if (saveFD.ShowDialog() == true)
            {
                using (StreamWriter writer = new(saveFD.FileName))
                {
                    foreach (string i in tb1.Text.Split(' '))
                    {
                        if (!string.IsNullOrWhiteSpace(i))
                        {
                            writer.WriteLine(i.TrimEnd('r'));
                            count += 1;
                        };
                    }
                }
                MessageBox.Show("Запись выполнена успешно");
            }
        }

        private void Istomin(object sender, RoutedEventArgs e)
        {

        }
    }
}