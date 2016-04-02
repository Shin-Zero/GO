using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using GO.Test;
using GO.ViewModel;
using GO.Views;

namespace GO
{
	/// <summary>
	/// Interaction logic for Window1.xaml
	/// </summary>
	public partial class MainWindow : Window
    {
        private readonly ViewModelLocator _sericeLocator = new ViewModelLocator();
        public MainWindow()
		{
			InitializeComponent();
            //var chess = new ChessWindow();
            //chess.ShowDialog();
            var board = new GameWindow {DataContext = _sericeLocator.GameWindow};
            board.ShowDialog();
            Close();
		}
	}
}