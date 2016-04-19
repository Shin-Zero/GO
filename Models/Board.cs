using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using GalaSoft.MvvmLight;

namespace GO.Models
{
	/// <summary>
	/// Игровая доска.
	/// </summary>
	public class Board: ViewModelBase
	{
	    private ObservableCollection<Stone> _stones = new ObservableCollection<Stone>();
	    private StoneType _currentType = StoneType.Black;

	    public ObservableCollection<Stone> Stones
	    {
	        get { return _stones; }
	        set
	        {
	            _stones = value;
	            RaisePropertyChanged(() => Stones);
	        }
	    }

	    public BoardPosition[,] Positions;

        public Board()
		{
            CreateBoard(19,19);
            //Stones = new ObservableCollection<Stone>
            //{
            //    new Stone {Position = new Point(0, 600), Type = StoneType.Black},
            //    new Stone {Position = new Point(100, 600), Type = StoneType.Black},
            //    new Stone {Position = new Point(200, 600), Type = StoneType.White},
            //    new Stone {Position = new Point(300, 600), Type = StoneType.Black},
            //    new Stone {Position = new Point(400, 600), Type = StoneType.White},
            //    new Stone {Position = new Point(500, 600), Type = StoneType.Black},
            //    new Stone {Position = new Point(600, 600), Type = StoneType.White},
            //    new Stone {Position = new Point(700, 600), Type = StoneType.Black},
            //    new Stone {Position = new Point(0, 700), Type = StoneType.White},
            //    new Stone {Position = new Point(100, 700), Type = StoneType.Black},
            //    new Stone {Position = new Point(200, 700), Type = StoneType.White},
            //    new Stone {Position = new Point(300, 700), Type = StoneType.Black},
            //    new Stone {Position = new Point(400, 700), Type = StoneType.White},
            //    new Stone {Position = new Point(500, 700), Type = StoneType.Black},
            //    new Stone {Position = new Point(600, 700), Type = StoneType.White},
            //    new Stone {Position = new Point(700, 700), Type = StoneType.Black},
            //    new Stone {Position = new Point(0, 100), Type = StoneType.White},
            //    new Stone {Position = new Point(100, 100), Type = StoneType.Black},
            //    new Stone {Position = new Point(200, 100), Type = StoneType.White},
            //    new Stone {Position = new Point(300, 100), Type = StoneType.Black},
            //    new Stone {Position = new Point(400, 100), Type = StoneType.White},
            //    new Stone {Position = new Point(500, 100), Type = StoneType.Black},
            //    new Stone {Position = new Point(600, 100), Type = StoneType.White},
            //    new Stone {Position = new Point(700, 100), Type = StoneType.Black},
            //    new Stone {Position = new Point(0, 0), Type = StoneType.White},
            //    new Stone {Position = new Point(100, 0), Type = StoneType.Black},
            //    new Stone {Position = new Point(200, 0), Type = StoneType.White},
            //    new Stone {Position = new Point(300, 0), Type = StoneType.Black},
            //    new Stone {Position = new Point(400, 0), Type = StoneType.White},
            //    new Stone {Position = new Point(500, 0), Type = StoneType.Black},
            //    new Stone {Position = new Point(600, 0), Type = StoneType.White},
            //    new Stone {Position = new Point(700, 0), Type = StoneType.Black}
            //};
		}

	    public void AddStone(object sender, MouseButtonEventArgs args)
	    {
	        var pos = args.GetPosition((Canvas) sender);
	        var x = pos.X - pos.X%100;
	        var y = pos.Y - pos.Y%100;
            Stones.Add(new Stone {Position = new Point(x,y),Type = _currentType});
	        _currentType = _currentType == StoneType.Black ? StoneType.White : StoneType.Black;
	    }

	    private void CreateBoard(int x, int y)
	    {
            Positions = new BoardPosition[x, y];
        }

	    public void CreateBoard9X9()
	    {
	        CreateBoard(9,9);
	    }

        public void CreateBoard13X13()
        {
            CreateBoard(13,13);
        }

        public void CreateBoard17X17()
        {
            CreateBoard(17,17);
        }
    }
}
