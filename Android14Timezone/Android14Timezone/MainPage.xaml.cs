using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android14Timezone;
using Xamarin.Forms;

namespace Android14Timezone
{
    public partial class MainPage : ContentPage
    {
        private string localTime;
        public string LocalTime
        {
            get { return localTime; }
            set 
            {
                localTime = value;
                OnPropertyChanged(nameof(LocalTime));
            }
        }

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }
        
        async void OnButtonClicked(object sender, EventArgs args)
        {
            DateTime selectedDate = _datePicker.Date; 
            TimeSpan selectedTime = _timePicker.Time; 
            DateTime date = new DateTime(selectedDate.Year, selectedDate.Month, selectedDate.Day,
                selectedTime.Hours, selectedTime.Minutes, selectedTime.Seconds, DateTimeKind.Utc);
            ITimeServices service = DependencyService.Get<ITimeServices>();
            LocalTime = service.ToLocalTime(new DateTimeOffset(date).ToUnixTimeMilliseconds()); 
        }
    }
}