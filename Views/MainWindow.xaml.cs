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
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GO.Annotations;
using GO.Models;
using WPFSpark;
using Timer = System.Timers.Timer;

namespace GO
{
	/// <summary>
	/// Interaction logic for Window1.xaml
	/// </summary>
	public partial class MainWindow: SparkWindow, INotifyPropertyChanged
	{
        private readonly ViewModelLocator _sericeLocator = new ViewModelLocator();

        #region Enums

        public enum AppMode
        {
            SprocketControl,
            ToggleSwitch,
            FluidWrapPanel,
            SparkWindow,
            FluidPivotPanel,
            FluidProgressBar,
            FluidStatusBar,
            GameBoard
        }

        enum SplitViewMenuWidth
        {
            Narrow = 48,
            Wide = 240
        }

        #endregion

        #region Fields

        Timer timer1 = new Timer(70);
        Timer timer2 = new Timer(70);

        bool isBGWorking = false;
        BackgroundWorker bgWorker;
        private Random _rnd = new Random();
        private Brush[] _brushes;

        #endregion

        #region Dependency Properties

        #region CurrentAppMode

        /// <summary>
        /// CurrentAppMode Dependency Property
        /// </summary>
        public static readonly DependencyProperty CurrentAppModeProperty =
            DependencyProperty.Register("CurrentAppMode", typeof(AppMode), typeof(MainWindow),
                new FrameworkPropertyMetadata(AppMode.SprocketControl));

        /// <summary>
        /// Gets or sets the CurrentAppMode property. This dependency property 
        /// indicates the current application mode.
        /// </summary>
        public AppMode CurrentAppMode
        {
            get { return (AppMode)GetValue(CurrentAppModeProperty); }
            set { SetValue(CurrentAppModeProperty, value); }
        }

        #endregion

        #region AppTitle

        /// <summary>
        /// AppTitle Dependency Property
        /// </summary>
        public static readonly DependencyProperty AppTitleProperty =
            DependencyProperty.Register("AppTitle", typeof(string), typeof(MainWindow),
                new FrameworkPropertyMetadata(string.Empty));

        /// <summary>
        /// Gets or sets the AppTitle property. This dependency property 
        /// indicates the title to be displayed based on user selection.
        /// </summary>
        public string AppTitle
        {
            get { return (string)GetValue(AppTitleProperty); }
            set { SetValue(AppTitleProperty, value); }
        }

        #endregion

        #endregion

	    private Board _gameBoardPanel;
        public Board GameBoardPanel
	    {
	        get { return _gameBoardPanel; }
            set
            {
                _gameBoardPanel = value;
                RaisePropertyChanged(nameof(GameBoardPanel));
            }
	    }

        public MainWindow()
		{
			InitializeComponent();

            _brushes = new Brush[] {
                                        new SolidColorBrush((Color)ColorConverter.ConvertFromString("#4cd964")),
                                        new SolidColorBrush((Color)ColorConverter.ConvertFromString("#007aff")),
                                        new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ff9600")),
                                        new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ff2d55")),
                                        new SolidColorBrush((Color)ColorConverter.ConvertFromString("#5856d6")),
                                        new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ffcc00")),
                                        new SolidColorBrush((Color)ColorConverter.ConvertFromString("#8e8e93")),
                                      };

            SizeChanged += (o, a) =>
            {
                switch (WindowState)
                {
                    case WindowState.Maximized:
                        SplitViewMenu.Width = (int)SplitViewMenuWidth.Wide;
                        break;

                    case WindowState.Normal:
                        SplitViewMenu.Width = (int)SplitViewMenuWidth.Narrow;
                        break;
                }

                RootGrid.ColumnDefinitions[0] = new ColumnDefinition { Width = new GridLength(SplitViewMenu.Width) };
                RootGrid.InvalidateVisual();
            };

            // Enable the tooltip for SplitView menu buttons only if the SplitView width is narrow
            SplitViewMenu.SizeChanged += (o, a) =>
            {
                var isNarrowMenu = (int)SplitViewMenu.Width == (int)SplitViewMenuWidth.Narrow;
                ToolTipService.SetIsEnabled(GBButton, isNarrowMenu);
            };
            
            Loaded += (s, e) =>
            {
                DataContext = this;
                GBButton.IsChecked = true;
            };

            GameBoardPanel = _sericeLocator.GameWindow;
        }

        // -------------------------------------------------------------------------------------
        // SplitView Menu
        // -------------------------------------------------------------------------------------

        #region SplitView Menu

        private int GetColumnZeroWidth()
        {
            // determine how wide column zero should be based on window size
            // if window is maximized, column zero width is equal to current menu width.
            // if window is normal, column zero width is equal to narrow menu width
            return WindowState == WindowState.Maximized
                       ? (int)SplitViewMenu.Width
                       : (int)SplitViewMenuWidth.Narrow;

        }

        private void OnMenuButtonClicked(object sender, RoutedEventArgs e)
        {
            // toggle menu width
            SplitViewMenu.Width = (int)SplitViewMenu.Width == (int)SplitViewMenuWidth.Narrow
                                      ? (int)SplitViewMenuWidth.Wide
                                      : (int)SplitViewMenuWidth.Narrow;

            // reset column width in the column definition based on window size
            RootGrid.ColumnDefinitions[0].Width = new GridLength(GetColumnZeroWidth());
        }
        
        private void OnFluidPivotPanel(object sender, RoutedEventArgs e)
        {
            SplitViewMenu.Width = GetColumnZeroWidth();
            CurrentAppMode = AppMode.FluidPivotPanel;
            AppTitle = Enum.GetName(typeof(AppMode), CurrentAppMode);
        }

        private void OnGameBoard(object sender, RoutedEventArgs e)
        {
            SplitViewMenu.Width = GetColumnZeroWidth();
            CurrentAppMode = AppMode.GameBoard;
            AppTitle = Enum.GetName(typeof(AppMode), CurrentAppMode);
        }

        #endregion

        private void OnPlayButtonClick(object sender, RoutedEventArgs e)
	    {
            //var chess = new ChessWindow();
            //chess.ShowDialog();
            //var board = new GameWindow { DataContext = _sericeLocator.GameWindow };
            //board.ShowDialog();
            //Close();
            GameBoardGrid.DataContext = _sericeLocator.GameWindow;
	    }
        private void Canvas_OnMouseUp(object sender, MouseButtonEventArgs e)
        {
            ((sender as Canvas).DataContext as Board).AddStone(sender, e);
        }

	    public event PropertyChangedEventHandler PropertyChanged;

	    [NotifyPropertyChangedInvocator]
	    protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
	    {
	        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	    }
	}
}