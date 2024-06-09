namespace Моделирование_системы_домашнего_отопления
{
    public class TClock
    {
        public int Minute0 { get; }

        public int Minute1 { get; }

        public int Hour0 { get; }

        public int Hour1 { get; }  

        public TClock(int _minute)
        {
            Hour1 = ((_minute / 60) % 24) % 10;
            Hour0 = ((_minute / 60) % 24) / 10;
            Minute1 = ((_minute) % 60) % 10;
            Minute0 = ((_minute) % 60) / 10;
        }

        public string GetTime()
        {
            return $"{Hour0}{Hour1}:{Minute0}{Minute1}";
        }

        public int GetMinute()
        {
            return Minute0;
        }
    }
}
