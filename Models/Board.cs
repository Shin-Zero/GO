using System;
using System.Collections.ObjectModel;
using System.Drawing;
using GalaSoft.MvvmLight;

namespace GO.Models
{
	/// <summary>
	/// Игровая доска.
	/// </summary>
	public class Board: ViewModelBase
	{
	    private ObservableCollection<Stone> _stones = new ObservableCollection<Stone>();

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
            Stones = new ObservableCollection<Stone>
            {
                new Stone {Position = new Point(0, 6), Type = StoneType.Black},
                new Stone {Position = new Point(1, 6), Type = StoneType.Black},
                new Stone {Position = new Point(2, 6), Type = StoneType.White},
                new Stone {Position = new Point(3, 6), Type = StoneType.Black},
                new Stone {Position = new Point(4, 6), Type = StoneType.White},
                new Stone {Position = new Point(5, 6), Type = StoneType.Black},
                new Stone {Position = new Point(6, 6), Type = StoneType.White},
                new Stone {Position = new Point(7, 6), Type = StoneType.Black},
                new Stone {Position = new Point(0, 7), Type = StoneType.White},
                new Stone {Position = new Point(1, 7), Type = StoneType.Black},
                new Stone {Position = new Point(2, 7), Type = StoneType.White},
                new Stone {Position = new Point(3, 7), Type = StoneType.Black},
                new Stone {Position = new Point(4, 7), Type = StoneType.White},
                new Stone {Position = new Point(5, 7), Type = StoneType.Black},
                new Stone {Position = new Point(6, 7), Type = StoneType.White},
                new Stone {Position = new Point(7, 7), Type = StoneType.Black},
                new Stone {Position = new Point(0, 1), Type = StoneType.White},
                new Stone {Position = new Point(1, 1), Type = StoneType.Black},
                new Stone {Position = new Point(2, 1), Type = StoneType.White},
                new Stone {Position = new Point(3, 1), Type = StoneType.Black},
                new Stone {Position = new Point(4, 1), Type = StoneType.White},
                new Stone {Position = new Point(5, 1), Type = StoneType.Black},
                new Stone {Position = new Point(6, 1), Type = StoneType.White},
                new Stone {Position = new Point(7, 1), Type = StoneType.Black},
                new Stone {Position = new Point(0, 0), Type = StoneType.White},
                new Stone {Position = new Point(1, 0), Type = StoneType.Black},
                new Stone {Position = new Point(2, 0), Type = StoneType.White},
                new Stone {Position = new Point(3, 0), Type = StoneType.Black},
                new Stone {Position = new Point(4, 0), Type = StoneType.White},
                new Stone {Position = new Point(5, 0), Type = StoneType.Black},
                new Stone {Position = new Point(6, 0), Type = StoneType.White},
                new Stone {Position = new Point(7, 0), Type = StoneType.Black}
            };
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
