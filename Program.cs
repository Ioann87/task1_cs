using cs = System.Console;
using System;

namespace task1_cs
{
    public static class Globals
    {
        public const int DEGREES = 180;
        public const int MINUTE_PER_HOUR = 60;
    }

    public class Converter
    {
        double deg;
        double rad;

        public Converter()
        {
            deg = 0.0;
            rad = 0.0;
        }
        public void convert_to()
        {
            cs.WriteLine("1 - rad to deg; 2 - deg to rad: ");
            int choice = System.Convert.ToInt32(cs.ReadLine());
            switch (choice)
            {
                case 1:
                    cs.WriteLine("Enter rad: ");
                    convert_rad_to_deg(System.Convert.ToDouble(cs.ReadLine()));
                    break;
                case 2:
                    cs.WriteLine("Enter deg: ");
                    convert_deg_to_rad(System.Convert.ToDouble(cs.ReadLine()));
                    break;
            }
        }

        public void convert_deg_to_rad(double deg)
        {
            this.deg = deg;

            this.rad = (Math.PI / Globals.DEGREES) * deg;

            cs.WriteLine(this.rad + " radian");

            return;
        }
        public void convert_rad_to_deg(double rad)
        {
            this.rad = rad;

            this.deg = (Globals.DEGREES / Math.PI) * rad;

            cs.WriteLine(this.deg + " degrees");

            return;
        }

        public double get_deg() { return deg; }
        public double get_rad() { return rad; }
    }

    //Task 2
    public class NumberReverse
    {
        int number;
        int mirror;

        public NumberReverse()
        {
            number = 0;
            mirror = 0;
        }

        public void reflect()
        {
            cs.WriteLine("input a number: ");
            int number = System.Convert.ToInt32(cs.ReadLine());
            this.number = number;

            while (number != 0)
            {
                mirror += (number % 10);
                mirror *= 10;
                number /= 10;
            }
            mirror /= 10;

            cs.WriteLine("original: " + this.number);
            cs.WriteLine("mirror: " + this.mirror);

            return;
        }

        public int get_num() { return number; }
        public int get_mir() { return mirror; }

    }

    //Task 3
    public class Time
    {
        int full_minute;
        int hour;
        int minute;
        int second;

        public Time()
        {
            full_minute = 0;
            hour = 0;
            minute = 0;
            second = 0;
        }

        public void input_time()
        {
            cs.Write("H: ");
            hour = System.Convert.ToInt32(cs.ReadLine());
            cs.Write(" M: ");
            minute = System.Convert.ToInt32(cs.ReadLine());
            cs.Write(" S: ");
            second = System.Convert.ToInt32(cs.ReadLine());

            full_minute = hour * Globals.MINUTE_PER_HOUR + minute;

            cs.WriteLine("Time: " + hour + " : " + minute + " : " + second);
            cs.WriteLine("full minutes: " + full_minute);
            return;
        }

        public int get_full_minute() { return full_minute; }

    }
    //Task 4
    class Mean
    {
        int number;

        double geom;
        double arith;

        public Mean()
        {
            number = 0;

            geom = 0.0;
            arith = 0.0;

        }

        public void input()
        {
            cs.Write("input number: ");
            this.number = System.Convert.ToInt32(cs.ReadLine());
            int count = 0;

            while (number != 0)
            {
                arith += (number % 10);
                geom = arith;
                count++;
                number /= 10;
            }

            arith /= (double)count;

            geom = Math.Pow(geom, (1 / (double)count));

            cs.WriteLine("geometric mean: " + geom + "\narithmetic mean: " + arith);

            return;
        }

        public double get_geom() { return geom; }
        public double get_arith() { return arith; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter();
            converter.convert_to();

            NumberReverse numrev = new NumberReverse();
            numrev.reflect();

            Time time = new Time();
            time.input_time();

            Mean num = new Mean();
            num.input();
        }
    }
}
