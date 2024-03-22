using System;


namespace Properties
{
    public class TimePeriod
    {
        private int seconds;

        public double Hours
        {
            get { return seconds / 3600.0; }
            set { seconds = (int)(value * 3600); }
        }
        public TimePeriod(int seconds)
        {
            this.seconds = seconds;
        }
    }
}
