namespace Manicomio.SwosPlayerFinder.Core
{
    public class ValueParser
    {
        public int GetValue(byte value)
        {
            if (value == 0) { return 0; }
            if (value == 1) { return 25; }
            if (value == 2) { return 30; }
            if (value == 3) { return 40; }
            if (value == 4) { return 50; }
            if (value == 5) { return 65; }
            if (value == 6) { return 75; }
            if (value == 7) { return 85; }
            if (value == 8) { return 100; }
            if (value == 9) { return 110; }
            if (value == 10) { return 130; }
            if (value == 11) { return 150; }
            if (value == 12) { return 160; }
            if (value == 13) { return 180; }
            if (value == 14) { return 200; }
            if (value == 15) { return 250; }
            if (value == 16) { return 300; }
            if (value == 17) { return 350; }
            if (value == 18) { return 450; }
            if (value == 19) { return 500; }
            if (value == 20) { return 550; }
            if (value == 21) { return 600; }
            if (value == 22) { return 650; }
            if (value == 23) { return 700; }
            if (value == 24) { return 750; }
            if (value == 25) { return 800; }
            if (value == 26) { return 850; }
            if (value == 27) { return 950; }
            if (value == 28) { return 1000; }
            if (value == 29) { return 1100; }
            if (value == 30) { return 1300; }
            if (value == 31) { return 1500; }
            if (value == 32) { return 1600; }
            if (value == 33) { return 1800; }
            if (value == 34) { return 1900; }
            if (value == 35) { return 2000; }
            if (value == 36) { return 2250; }
            if (value == 37) { return 2750; }
            if (value == 38) { return 3000; }
            if (value == 39) { return 3500; }
            if (value == 40) { return 4500; }
            if (value == 41) { return 5000; }
            if (value == 42) { return 6000; }
            if (value == 43) { return 7000; }
            if (value == 44) { return 8000; }
            if (value == 45) { return 9000; }
            if (value == 46) { return 10000; }
            if (value == 47) { return 12000; }
            if (value == 48) { return 15000; }
            if (value == 49) { return 16000; }
            return 0;
        }
    }
}