using System;

namespace DatetimeNowUtcToday {
    class Program {
        static void Main(string[] args) {
            DateTime d1 = DateTime.Now;
            DateTime d2 = DateTime.UtcNow;
            DateTime d3 = DateTime.Today;
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
        }
    }
}
