using System;
namespace Overloading_and_interfaces
{
    public class Angle
    {
        private int degrees, minutes, seconds;

        public Angle()
        {
            degrees = 0;
            minutes = 0;
            seconds = 0;
        }

        public Angle(int degrees, int minutes, int seconds)
        {
            Seconds = seconds;
            Minutes = minutes;
            Degrees = degrees;
            FixAngle();
        }

        public int Degrees
        {
            get
            {
                return degrees;
            }
            set
            {
                if (value < 0)
                {
                    degrees = 0;
                }
                else
                {
                    degrees = value;
                }
            }
        }

        public int Minutes
        {
            get
            {
                return minutes;
            }

            set
            {
                if (value < 0)
                {
                    minutes += 0;
                }
                else
                {
                    minutes = value;
                }
            }
        }

        public int Seconds
        {
            get { return seconds; }
            set
            {
                if (value < 0)
                {
                    seconds = 0;
                }
                else
                {
                    seconds = value;
                }
            }
        }

        public void FixAngle()
        {

            minutes += seconds / 60;
            seconds %= 60;
            degrees += minutes / 60;
            minutes %= 60;
            if (degrees == 360 && (minutes != 0 || seconds != 0))
            { degrees = 359; }
            if (degrees > 360)
            {
                degrees %= 360;
            }
        }

        public void ComputeAngle()
        {

            Console.WriteLine(degrees + "° " + minutes + "\' " + seconds + "\'\'");
        }

        public static Angle operator +
            (Angle angle1, Angle angle2)
        {
            Angle temp = new Angle();
            temp.Seconds = angle1.Seconds + angle2.Seconds;
            temp.Minutes = angle1.Minutes + angle2.Minutes;
            temp.Degrees = angle1.Degrees + angle2.Degrees;
            temp.FixAngle();
            return temp;
        }

        public static Angle operator -
            (Angle angle1, Angle angle2)
        {
            Angle temp = new Angle();
            temp.seconds = angle1.Seconds - angle2.Seconds;
            temp.minutes = angle1.Minutes - angle2.Minutes;
            temp.degrees = angle1.Degrees - angle2.Degrees;
            temp.FixAngle();
            return temp;
        }
    }
}
