using System;
using System.Drawing;
using GalaSoft.MvvmLight;

namespace GO.Models
{
	/// <summary>
	/// Камни. Специальные фишки двух цветов для игры.
	/// </summary>
    public class Stone: ViewModelBase
	{
	    private StoneType _type;

	    public StoneType Type
	    {
	        get { return _type; }
	        set
	        {
	            _type = value;
	            RaisePropertyChanged(() => Type);
	        }
	    }

	    private Point _position;

	    public Point Position
	    {
	        get { return _position; }
	        set
	        {
	            _position = value;
	            RaisePropertyChanged(() => Position);
	        }
	    }
	}
}
