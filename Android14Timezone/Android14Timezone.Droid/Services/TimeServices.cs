using System;
using Android14Timezone.Droid;
using Java.Util;
using Xamarin.Forms;
using TimeZone = Java.Util.TimeZone;

[assembly: Dependency(typeof(TimeServices))]
namespace Android14Timezone.Droid
{
    public class TimeServices : ITimeServices
    {
        public String ToLocalTime(long unix)
        {
            Date date = new Date(unix);
            return date.ToString();
        }
    }
}