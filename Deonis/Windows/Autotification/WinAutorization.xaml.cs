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
using System.Windows.Shapes;

namespace Deonis.Windows.Autotification
{
    /// <summary>
    /// Логика взаимодействия для WinAutorization.xaml
    /// </summary>
    public partial class WinAutorization : Window
    {
        public WinAutorization()
        {
            InitializeComponent();

            Rect.MouseDown += delegate { this.DragMove(); };
        }
    }
}
