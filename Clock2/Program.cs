namespace Clock2

{
    public class Clock
    {
        private int hour;//0-23 hours
        private int minute;//0-59 min
        private int minutesInDay = 24 * 60;

        public Clock(int hour, int minute)
        {
            this.hour = hour;
            this.minute = minute;
        }

        public int getInterval() // תשלים את המתודה
        {
            int minutesInDay = 60 * 24;
            int currTimeToMinutes = 60 * hour + minute;
            return minutesInDay - currTimeToMinutes;
        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            Clock seif1Example = new Clock(20, 45);// דוגמה לסעיף הראשון לראות שיצא התוצאה שנתנו בדוגמה
            Console.WriteLine(seif1Example.getInterval());
        }
    }
}