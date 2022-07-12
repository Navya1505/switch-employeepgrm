using System;

namespace switchpgrm
{
    public static class Switchpgrm
    {
    public const int IS_PART_TIME = 1;
    public const int IS_FULL_TIME = 2;
    public const int EMP_RATE_PER_HOUR = 20;

       public static void Main(string[] args)
        {
        }
        public static void switchpgrm()
        { 
            int emphrs = 0;
            int empwage = 0;
           Random random = new Random();
         int empcheck = random.Next(0, 3);
                switch (empcheck)
                {
                    case IS_PART_TIME:
                        emphrs = 4;
                        break;
                    case IS_FULL_TIME:
                        emphrs = 8;
                        break;
                    default:
                        emphrs = 0;
                        break;
                }
                empwage = emphrs * EMP_RATE_PER_HOUR;
              
                Console.WriteLine("empwage:" + empwage);
        }
    }
}
