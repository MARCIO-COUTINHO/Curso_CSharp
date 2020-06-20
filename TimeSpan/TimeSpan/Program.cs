using System;

namespace TimeSpan {
    class Program {
        static void Main(string[] args) {
            TimeSpan t1 = new TimeSpan(0, 1, 30);
            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);
        }
    }
}
