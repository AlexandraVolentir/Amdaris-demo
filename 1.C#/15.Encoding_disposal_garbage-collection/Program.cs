using System;
using System.Globalization;
using System.IO;
using System.Text;

namespace Encoding_disposal_garbagecollection
{
    class MainClass
    {
        public static void EmptyStrings()
        {
            // empty strings
            string str1 = "";
            Console.WriteLine("The string is empty: " + (string.Empty == str1));
            Console.WriteLine("The length of the string is 0 " + (str1.Length == 0));
            if (string.IsNullOrEmpty(str1))
            {
                Console.WriteLine("True: The string is null or empty");
            }
            Console.WriteLine();
        }

        public static void Searching()
        {
        }

        public static void Formatting()
        {
            // negative - left aligned (spaces to the right)
            // prositive - right aligned spaces to left
            string formattedString = "BankName={0,-10} Credit given={1,15:C}";
            Console.WriteLine(string.Format(formattedString, "Transilvania", 200000));
            Console.WriteLine();
        }

        public static void Comparing()
        {
            Console.WriteLine("encyclopædia".Equals("encyclopedia", StringComparison.InvariantCulture));
            Console.WriteLine("encyclopædia".Equals("encyclopedia", StringComparison.CurrentCulture));
            Console.WriteLine("encyclopædia".Equals("encyclopedia"));
            Console.WriteLine();
            Console.WriteLine(string.Compare("lil", "LIL", StringComparison.InvariantCultureIgnoreCase));
            Console.WriteLine(string.Compare("lil", "LIL", StringComparison.CurrentCulture));
            Console.WriteLine();
        }

        public static void UseTime()
        {
            var time = TimeSpan.FromDays(21) - TimeSpan.FromMilliseconds(1);
            Console.WriteLine(time.Days);
            Console.WriteLine(time.Hours);
            Console.WriteLine(time.Minutes);
            Console.WriteLine(time.Milliseconds);
            Console.WriteLine(time.Milliseconds);
            Console.WriteLine();

            DateTime date1 = new DateTime(2020, 4, 3, 7, 23, 44);
            DateTime date2 = DateTime.Now;
            DateTime date3 = DateTime.UtcNow;
            DateTime date4 = DateTime.Today;
            string stringOfDate = "5/1/2008 8:30:52 AM";
            DateTime date5 = DateTime.Parse(stringOfDate);
            Console.WriteLine(date1);
            Console.WriteLine(date2);
            Console.WriteLine(date5);
            Console.WriteLine();
        }

        public static void UseTimeSpan()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine($"Now - {now} ");
            TimeSpan duration = TimeSpan.FromDays(3);
            DateTime before = now.Subtract(duration);
            Console.WriteLine($"Before - {before}");
            DateTime after = now.Add(duration);
            Console.WriteLine($"After - {after}");
            Console.WriteLine();
        }

        public static void UseDateTimeOffset()
        {
            // implicit cast
            DateTimeOffset dt = new DateTime(2000, 2, 3);
            Console.WriteLine(dt);

            // if the DateTime has a DateTimeKind of Utc, the offset is zero
            // if DateTime has a DateTimeKind or Local or Unspecified(default),
            // than the offset is taken from the current timeozone

            var dateTime = new DateTime(2008, 5, 1, 8, 30, 52, DateTimeKind.Unspecified);
            Console.WriteLine(dateTime);

            DateTimeOffset offset = dateTime;// +03:00 hours
            Console.WriteLine(offset);

            DateTime localDateTime = DateTime.SpecifyKind(dateTime, DateTimeKind.Local);
            offset = localDateTime; // +03:00 
            Console.WriteLine(offset);

            DateTime utcDateTime = DateTime.SpecifyKind(dateTime, DateTimeKind.Utc);
            offset = utcDateTime; // +00:0
            Console.WriteLine(offset);

            // time zones


            Console.WriteLine();
        }

        public static void UseFormatProviders()
        {
            CultureInfo uk = CultureInfo.GetCultureInfo("en-GB");
            Console.WriteLine(3.ToString("C", uk));
            Console.WriteLine(3.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine();

            NumberFormatInfo f = new NumberFormatInfo();
            f.NumberGroupSeparator = " ";
            Console.WriteLine(12345.6789.ToString("N1", f));
            Console.WriteLine(12345.6789.ToString("N2", f));
            Console.WriteLine();
        }

        public static void UseDisposable()
        {
            // if Dispose() was not called - file stream remains open while the application is runnut

            //FileStream fs = new FileStream("file1", FileMode.Open);
            //var str = "dog";
            //var bytes = Encoding.ASCII.GetBytes(str);
            //var bytesCount = Encoding.ASCII.GetByteCount(str);
            //fs.Write(bytes, 0, bytesCount);
            //fs.Dispose();
            //Console.WriteLine();

            // using statement provides a syntactic shortcut for calling Disposable on objects that implement idisposible

            using (FileStream fs = new FileStream("file1.txt", FileMode.Open))
            {
                var str = "dog";
                var bytes = Encoding.ASCII.GetBytes(str);
                var bytesCount = Encoding.ASCII.GetByteCount(str);
                fs.Write(bytes, 0, bytesCount);
            }
            Console.WriteLine();
        }

        public static void UseTimeZone()
        {
            TimeZone localZone = TimeZone.CurrentTimeZone;
            Console.WriteLine(localZone);
            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            EmptyStrings();
            Formatting();
            Comparing();
            UseTime();
            UseTimeSpan();
            UseTimeZone();
            UseDateTimeOffset();
            UseFormatProviders();
            UseDisposable();
        }
    }
}
