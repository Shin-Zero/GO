using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using System.Linq;

namespace GO.Models
{
	/// <summary>
	/// Игровая доска.
	/// </summary>
	public class Board: ViewModelBase
	{
	    private ObservableCollection<Stone> _stones = new ObservableCollection<Stone>();
	    private StoneType _currentType = StoneType.Black;
	    private double approximation; //величина приближения при проверки позиции клика
	    private double border; // ширина "неигровой" границы доски
	    private double line; // толщина линий
	    private double square; //расстояние между линиями (размер пустых квадратов)
	    private List<Stone> _checkedStones; 

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
	    
	    private int _boardSize;
	    public int BoardSize
	    {
	    	get {return _boardSize;}
	    	set
	    	{
	    		_boardSize = value;
	    		RaisePropertyChanged(()=> BoardSize);
	    	}
	    }

	   	private int _stoneSize;
	    public int StoneSize
	    {
	    	get {return _stoneSize;}
	    	set
	    	{
	    		_stoneSize = value;
	    		RaisePropertyChanged(()=> StoneSize);
	    	}
	    }
	    
	    private int _blackStonesCount;
	    public int BlackStonesCount 
	    {
	    	get { return _blackStonesCount; }
	    	set {
	    		_blackStonesCount = value;
	    		RaisePropertyChanged(()=>BlackStonesCount);
	    	}
	    }
	    
	    private double _blackScore;
	    public double BlackScore 
	    {
	    	get { return _blackScore; }
	    	set {
	    		_blackScore = value;
	    		RaisePropertyChanged(()=>BlackScore);
	    	}
	    }
	    
	    private double _whiteScore;
	    public double WhiteScore 
	    {
	    	get { return _whiteScore; }
	    	set {
	    		_whiteScore = value;
	    		RaisePropertyChanged(()=>WhiteScore);
	    	}
	    }
	    
	    private int _whiteStonesCount;
	    public int WhiteStonesCount 
	    {
	    	get { return _whiteStonesCount; }
	    	set {
	    		_whiteStonesCount = value;
	    		RaisePropertyChanged(()=>WhiteStonesCount);
	    	}
	    }
	    
        public Board()
		{
            CreateBoard(19,19);
            BoardSize = 400;
            StoneSize = 20;
            WhiteScore+=6.5;
            approximation = BoardSize*0.03; //величина приближения при проверки позиции клика
	    	border = 0.03; // ширина "неигровой" границы доски
	   	 	line = 0.002; // толщина линий
	    	square = 0.05; //расстояние между линиями (размер пустых квадратов)
		}
        
        public bool CheckDame(Stone stone)
        {
            if (_checkedStones.Contains(stone))
                return false;
            _checkedStones.Add(stone);
        	var possibleDame = 4;
        	if((stone.Position.X + BoardSize*(square+line+border) > BoardSize) || (stone.Position.X - BoardSize*(square+line + border) < 0))
        		possibleDame-=1;
        	if((stone.Position.Y + BoardSize*(square+line + border) > BoardSize) || (stone.Position.Y - BoardSize*(square+line + border) < 0))
        		possibleDame-=1;
        	var r = Stones.Where((s) => 
        	                     (
        	                     	(
                                        (s.Position.X == stone.Position.X + BoardSize*(square+line)) ||
        	                     	    (s.Position.X == stone.Position.X - BoardSize*(square+line))
                                    ) &&
                                    s.Position.Y == stone.Position.Y
                                  ) ||
        		                 (
        	                     	(
                                    (s.Position.Y == stone.Position.Y + BoardSize*(square+line)) || 
        	                     	(s.Position.Y == stone.Position.Y - BoardSize*(square+line))
                                    ) &&
                                    s.Position.X == stone.Position.X
        	                     )
        	                    ).Count();
        	if(r < possibleDame)
        		return true;
        	//if(!Stones.Any((s) => ((s.Position.X < stone.Position.X + BoardSize*(square+line)) && (s.Position.X > stone.Position.X - BoardSize*(square+line))) && ((s.Position.Y < stone.Position.Y + BoardSize*(square+line)) && (s.Position.Y > stone.Position.Y - BoardSize*(square+line)))))
        	//	return true;
        	var sameTypeStones = Stones.Where(s=>
        	                                  (s.Type == stone.Type) && 
        	                                  (
        	                                  	(((s.Position.X < stone.Position.X + BoardSize*(square+line) + approximation) && (s.Position.X > stone.Position.X + BoardSize*(square+line) - approximation)) ||
        	                                  	 ((s.Position.X < stone.Position.X - BoardSize*(square+line) + approximation) && (s.Position.X > stone.Position.X - BoardSize*(square+line)- approximation)))
        	                                  	&&
        	                                  	(((s.Position.Y < stone.Position.Y + BoardSize*(square+line) + approximation) && (s.Position.Y > stone.Position.Y + BoardSize*(square+line) - approximation)) ||
        	                                  	 ((s.Position.Y < stone.Position.Y - BoardSize*(square+line) + approximation) && (s.Position.Y > stone.Position.Y - BoardSize*(square+line)- approximation)))
        	                                   )
        	                                 );
        	foreach(var s in sameTypeStones)
        		if(CheckDame(s))
        			return true;
        	return false;
        }

	    public void AddStone(object sender, MouseButtonEventArgs args)
	    {
	        var pos = args.GetPosition((Canvas) sender);

	        var approximatedXHigh = pos.X - (pos.X-BoardSize*border)%(BoardSize*(square+line)) + BoardSize*(square+line);
	        var approximatedXLow = pos.X - (pos.X-BoardSize*border)%(BoardSize*(square+line));
	        var approximatedYHigh = pos.Y - (pos.Y-BoardSize*border)%(BoardSize*(square+line)) + BoardSize*(square+line);
	        var approximatedYLow = pos.Y - (pos.Y-BoardSize*border)%(BoardSize*(square+line));
	        if(approximatedXHigh>BoardSize)
	        	approximatedXHigh = approximatedXLow;
	        if(approximatedYHigh>BoardSize)
	        	approximatedYHigh = approximatedYLow;
	        var xDifHigh = approximatedXHigh - pos.X;
	        var xDifLow = pos.X - approximatedXLow;
	        var yDifHigh = approximatedYHigh - pos.Y;
	        var yDifLow = pos.Y - approximatedYLow;
	        var x = (xDifHigh > xDifLow ? approximatedXLow : approximatedXHigh ) - StoneSize/2; //X координата установки камня
	        var y = (yDifHigh > yDifLow ? approximatedYLow : approximatedYHigh ) - StoneSize/2; //Y координата установки камня
	        
	        //Проверка на наличие камня в околокликовой позиции
	        if(!Stones.Any((s) => 
            ((s.Position.X < x + approximation) && (s.Position.X > x - approximation)) && ((s.Position.Y < y + approximation) && (s.Position.Y > y - approximation))))
	        {
	        	var newStone = new Stone {Position = new Point(x,y),Type = _currentType};
                _checkedStones = new List<Stone>();
	        	//Проверка наличия дамэ (точки свободы)
	        	if(CheckDame(newStone)){
		        	Stones.Add(newStone);
		        	switch(_currentType)
		        	{
		        		case(StoneType.Black):
		        			_currentType = StoneType.White;
		        			BlackStonesCount++;
		        			break;
		        		case(StoneType.White):
		        			_currentType=StoneType.Black;
		        			WhiteStonesCount++;
		        			break;
		        	}
	        	}
	        	//_currentType = _currentType == StoneType.Black ? StoneType.White : StoneType.Black;
	        }
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
