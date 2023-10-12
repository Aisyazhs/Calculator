using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorBangunDatar
{
    public class Persegi
    {
        public double s;

        public double LuasPersegi(double s)
        {
            return s * s;
        }
        public double KelilingPersegi(double s)
        {
            return 4 * s;
        }
    }

    public class PersegiPanjang
    {
        public double p, l;

        public double LuasPersegiPanjang(double p, double l)
        {
            return p * l;
        }
        public double KelilingPersegiPanjang(double p, double l)
        {
            return 2 * (p + l);
        }
    }

    public class Lingkaran
    {
        public double r, d;

        public double LuasLingkaran(double r)
        {
            return 3.14 * r * r;
        }
        public double KelilingLingkaran(double d)
        {
            return 3.14 * d;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double s = Double.Parse(args[0]);
            double p = Double.Parse(args[0]);
            double l = Double.Parse(args[1]);
            double r = Double.Parse(args[0]);
            double d = Double.Parse(args[1]);

            Persegi ps = new Persegi();
            PersegiPanjang pp = new PersegiPanjang();
            Lingkaran lk = new Lingkaran();

            double lp = ps.LuasPersegi(s);
            double kp = ps.KelilingPersegi(s);
            double lpp = pp.LuasPersegiPanjang(p, l);
            double kpp = pp.KelilingPersegiPanjang(p, l);
            double llk = lk.LuasLingkaran(r);
            double klk = lk.KelilingLingkaran(d);

            Console.WriteLine("Luas Persegi {0} dan Keliling Persegi {1}", lp, kp);
            Console.WriteLine("Luas Persegi Panjang {0} dan Keliling Persegi Panjang {1}", lpp, kpp);
            Console.WriteLine("Luas Lingkaran {0} dan Keliling Lingkaran {1}", llk, klk);
        }
    }
}


