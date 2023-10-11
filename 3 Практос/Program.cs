namespace _3_Практос
{
    internal class Program
    {   static int[] DO_1 = new int[] { 131, 262, 523, 1047 };
        static int[] RE_1 = new int[] { 147, 294, 587, 1175 };
        static int[] MI_0 = new int[] { 165, 330, 659, 1319 };
        static int[] FA_1 = new int[] { 175, 349, 699, 1397 };
        static int[] SO_1 = new int[] { 196, 392, 784, 1568 };
        static int[] LA_1 = new int[] { 220, 440, 880, 1760 };
        static int[] TI_0 = new int[] { 247, 494, 988, 1976 };
        static int[] DO_2 = new int[] { 139, 277, 554, 1109 };
        static int[] RE_2 = new int[] { 156, 311, 622, 1244 };
        static int[] FA_2 = new int[] { 185, 370, 740, 1480 };
        static int[] SO_2 = new int[] { 208, 415, 831, 1661 };
        static int[] LA_2 = new int[] { 233, 462, 932, 1865 };
        static void Main(string[] args) 
        {
            Console.WriteLine("Это моё крутецкое пианино, в пианине поддерживается 4 октавы, с 3 - 6, сейчас вы находитесь на 3 октаве, между ними можно переключаться.");
            while (true)
            {   ConsoleKeyInfo stop = Console.ReadKey(true);
                octavs_3();
                if (stop.Key == ConsoleKey.Escape) { break; }
                else if (stop.Key == ConsoleKey.F3) { octavs_3(); }
                else if (stop.Key == ConsoleKey.F4) { octavs_4(); }
                else if (stop.Key == ConsoleKey.F5) { octavs_5(); }
                else if (stop.Key == ConsoleKey.F6) { octavs_6(); }
            }
        }
        static void octavs_3()
            {   ConsoleKeyInfo stop = Console.ReadKey(true);
                if (stop.Key == ConsoleKey.D) { Console.Beep(DO_1[0], 200); }
                else if (stop.Key == ConsoleKey.R) { Console.Beep(DO_2[0], 200); }
                else if (stop.Key == ConsoleKey.F) { Console.Beep(RE_1[0], 200); }
                else if (stop.Key == ConsoleKey.T) { Console.Beep(RE_2[0], 200); }
                else if (stop.Key == ConsoleKey.G) { Console.Beep(MI_0[0], 200); }
                else if (stop.Key == ConsoleKey.Y) { Console.Beep(FA_1[0], 200); }
                else if (stop.Key == ConsoleKey.H) { Console.Beep(FA_2[0], 200); }
                else if (stop.Key == ConsoleKey.U) { Console.Beep(SO_1[0], 200); }
                else if (stop.Key == ConsoleKey.J) { Console.Beep(SO_2[0], 200); }
                else if (stop.Key == ConsoleKey.I) { Console.Beep(LA_1[0], 200); }
                else if (stop.Key == ConsoleKey.K) { Console.Beep(LA_2[0], 200); }
                else if (stop.Key == ConsoleKey.O) { Console.Beep(TI_0[0], 200); }
            }
        static void octavs_4()
            {
                ConsoleKeyInfo stop = Console.ReadKey(true); 
                if (stop.Key == ConsoleKey.D) { Console.Beep(DO_1[1], 200); }
                else if (stop.Key == ConsoleKey.R) { Console.Beep(DO_2[1], 200); }
                else if (stop.Key == ConsoleKey.F) { Console.Beep(RE_1[1], 200); }
                else if (stop.Key == ConsoleKey.T) { Console.Beep(RE_2[1], 200); }
                else if (stop.Key == ConsoleKey.G) { Console.Beep(MI_0[1], 200); }
                else if (stop.Key == ConsoleKey.Y) { Console.Beep(FA_1[1], 200); }
                else if (stop.Key == ConsoleKey.H) { Console.Beep(FA_2[1], 200); }
                else if (stop.Key == ConsoleKey.U) { Console.Beep(SO_1[1], 200); }
                else if (stop.Key == ConsoleKey.J) { Console.Beep(SO_2[1], 200); }
                else if (stop.Key == ConsoleKey.I) { Console.Beep(LA_1[1], 200); }
                else if (stop.Key == ConsoleKey.K) { Console.Beep(LA_2[1], 200); }
                else if (stop.Key == ConsoleKey.O) { Console.Beep(TI_0[1], 200); }
            }
        static void octavs_5()
        {
                ConsoleKeyInfo stop = Console.ReadKey(true);
                if (stop.Key == ConsoleKey.D) { Console.Beep(DO_1[2], 200); }
                else if (stop.Key == ConsoleKey.R) { Console.Beep(DO_2[2], 200); }
                else if (stop.Key == ConsoleKey.F) { Console.Beep(RE_1[2], 200); }
                else if (stop.Key == ConsoleKey.T) { Console.Beep(RE_2[2], 200); }
                else if (stop.Key == ConsoleKey.G) { Console.Beep(MI_0[2], 200); }
                else if (stop.Key == ConsoleKey.Y) { Console.Beep(FA_1[2], 200); }
                else if (stop.Key == ConsoleKey.H) { Console.Beep(FA_2[2], 200); }
                else if (stop.Key == ConsoleKey.U) { Console.Beep(SO_1[2], 200); }
                else if (stop.Key == ConsoleKey.J) { Console.Beep(SO_2[2], 200); }
                else if (stop.Key == ConsoleKey.I) { Console.Beep(LA_1[2], 200); }
                else if (stop.Key == ConsoleKey.K) { Console.Beep(LA_2[2], 200); }
                else if (stop.Key == ConsoleKey.O) { Console.Beep(TI_0[2], 200); }
        }
        static void octavs_6()
        {
                ConsoleKeyInfo stop = Console.ReadKey(true);
                if (stop.Key == ConsoleKey.D) { Console.Beep(DO_1[3], 200); }
                else if (stop.Key == ConsoleKey.R) { Console.Beep(DO_2[3], 200); }
                else if (stop.Key == ConsoleKey.F) { Console.Beep(RE_1[3], 200); }
                else if (stop.Key == ConsoleKey.T) { Console.Beep(RE_2[3], 200); }
                else if (stop.Key == ConsoleKey.G) { Console.Beep(MI_0[3], 200); }
                else if (stop.Key == ConsoleKey.Y) { Console.Beep(FA_1[3], 200); }
                else if (stop.Key == ConsoleKey.H) { Console.Beep(FA_2[3], 200); }
                else if (stop.Key == ConsoleKey.U) { Console.Beep(SO_1[3], 200); }
                else if (stop.Key == ConsoleKey.J) { Console.Beep(SO_2[3], 200); }
                else if (stop.Key == ConsoleKey.I) { Console.Beep(LA_1[3], 200); }
                else if (stop.Key == ConsoleKey.K) { Console.Beep(LA_2[3], 200); }
                else if (stop.Key == ConsoleKey.O) { Console.Beep(TI_0[3], 200); }
        }
    }
}