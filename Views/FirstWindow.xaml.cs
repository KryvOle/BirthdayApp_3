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
using BirthdayApp.ViewModels;

namespace BirthdayApp.Views
{
    /// <summary>
    /// Логика взаимодействия для FirstWindow.xaml
    /// </summary>
    public partial class FirstWindow : UserControl
    {
        private FirstWindowViewModel _viewModel;
        public FirstWindow()
        {
            InitializeComponent();
            DataContext = _viewModel = new FirstWindowViewModel();
        }
    }
}
