using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using wap_Project.Entities;

namespace wap_Project.ViewModel
{
	internal class MainFormViewModel : INotifyPropertyChanged
	{
		#region Properties
		#region ID
		private Guid _id;
		public Guid Id
		{
			get { return _id; }
			set
			{
				if (_id == value)
					return;
				_id = value;

				//If we use [CallerMemberName] in the OnPropertyChanged method
				//OnPropertyChanged();
				//If we don't use the [CallerMemberName] in the OnPropertyChanged method
				OnPropertyChanged("Id");
			}
		}
		#endregion

		#region ClientId
		private Guid _client_id;
		public Guid ClientID
		{
			get { return _client_id; }
			set
			{
				if (_client_id == value)
					return;
				_client_id = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region StartDate
		private DateTime _start_date;

		public DateTime StartDate
		{
			get { return _start_date; }
			set
			{
				if (_start_date == value)
					return;
				_start_date = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region EndDate
		private DateTime _end_date;

		public DateTime EndDate
		{
			get { return _end_date; }
			set
			{
				if (_end_date == value)
					return;
				_end_date = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region RoomID
		private int _room_id;

		public int RoomID
		{
			get { return _room_id; }
			set
			{
				if (_room_id == value)
					return;
				_room_id = value;
				OnPropertyChanged();
			}
		}
		#endregion

		public BindingList<Booking> Bookings { get; set; }
		#endregion

		public MainFormViewModel()
		{
			Bookings = new BindingList<Booking>();
			_id = Guid.NewGuid();
		}

		#region Methods
		public void AddBooking()
		{
			Bookings.Add(new Booking(ClientID, StartDate, EndDate, RoomID));
			//LastName = FirstName = string.Empty;
			//BirthDate = DateTime.Today;
		}
		#endregion

		#region INotifyPropertyChanged
		public event PropertyChangedEventHandler PropertyChanged;

		// [CallerMemberName] - Allows you to obtain the method or property name of the caller to the method. https://msdn.microsoft.com/en-us/library/system.runtime.compilerservices.callermembernameattribute%28v=vs.110%29.aspx
		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			if (PropertyChanged != null)
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}
		#endregion
	}
}
