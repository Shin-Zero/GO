using System;
using System.ComponentModel;
using GO.Annotations;

namespace GO.Models
{
	/// <summary>
	/// Чаша для хранения камней.
	/// </summary>
	public class Bowl: INotifyPropertyChanged
	{
		public Bowl()
		{
		}

	    public event PropertyChangedEventHandler PropertyChanged;

	    [NotifyPropertyChangedInvocator]
	    protected virtual void RaisePropertyChanged(string propertyName)
	    {
	    	if(PropertyChanged != null)
	    		PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
	    }
	}
}