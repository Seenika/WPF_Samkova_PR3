﻿using System;
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

namespace WPF_Samkova_PR3
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

        private void Pusk_Click(object sender, RoutedEventArgs e)
        {
            //Получение исходных данных из TextBox
            double x = Convert.ToDouble(X.Text);
            double y = Convert.ToDouble(Y.Text);
            double z = Convert.ToDouble(Z.Text);

            //Ввод исходных данных в окно результатов
            Itog.Text = "Результаты работы программы ст. Самовой К.С." + Environment.NewLine;
            Itog.Text = "Вариант 14" + Environment.NewLine;
            Itog.Text = "" + X.Text + Environment.NewLine;
            Itog.Text = "" + Y.Text + Environment.NewLine;
            Itog.Text = "" + Z.Text + Environment.NewLine;

        }
    }
}
