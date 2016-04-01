using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GO.ViewModel;

namespace GO.Views
{
    /// <summary>
    /// Interaction logic for GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        private readonly ViewModelLocator _sericeLocator = new ViewModelLocator();
        public GameWindow()
        {
            InitializeComponent();
            DataContext = _sericeLocator.GameWindow;
        }
    }
}
