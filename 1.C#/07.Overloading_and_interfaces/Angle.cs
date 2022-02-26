using System;
namespace Overloading_and_interfaces
{
    public class Angle
    {
        private int degrees = 0, minutes = 0, seconds = 0;

        public Angle()
        {
        }

        public Angle(int degrees, int minutes, int seconds)
        {
            Seconds = seconds;
            Minutes = minutes;
            Degrees = degrees;   
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
                else if (value >= 360 && (minutes != 0 || seconds !=0 ))
                {
                    degrees = 359;
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
                else if (value >= 60)
                {
                    minutes = 59;
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
                else if (seconds >= 60)
                {
                    seconds = 59;
                }
                else
                {
                    seconds = value;
                }
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
            temp.Seconds = angle1.seconds + angle2.seconds;
            temp.Minutes = angle1.minutes + angle2.minutes;
            temp.Degrees = angle1.degrees + angle2.degrees;
            return temp;
        }
    }
}
