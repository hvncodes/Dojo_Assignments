using System;

namespace IronNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("########################");
            Buffet b = new Buffet();
            Ninja st = new SweetTooth();
            Ninja sh = new SpiceHound();
            while (!st.IsFull)
            {
                IConsumable i = b.Serve();
                st.Consume(i);
            }
            Console.WriteLine("------------------------");
            while (!sh.IsFull)
            {
                IConsumable i = b.Serve();
                sh.Consume(i);
            }
            Console.WriteLine("------------------------");
            if (st.ConsumptionHistory.Count > sh.ConsumptionHistory.Count)
            {
                Console.WriteLine("SweetTooth consumed the most buffet items!");
            }
            else if (st.ConsumptionHistory.Count < sh.ConsumptionHistory.Count)
            {
                Console.WriteLine("SpiceHound consumed the most buffet items!");
            }
            else // tie
            {
                Console.WriteLine("SweetTooth and SpiceHound consumed the same # of buffet items!");
            }
            Console.WriteLine($"SweetTooth: {st.ConsumptionHistory.Count}. SpiceHound: {sh.ConsumptionHistory.Count}");
            Console.WriteLine("########################");
        }
    }
}
