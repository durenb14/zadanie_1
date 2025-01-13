using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Практическая работа №1");
            double M, t;
            Console.WriteLine("Введите значение - t");
            t = Convert.ToDouble(Console.ReadLine());
            M = 3 * Math.Pow(t, 2) + 3 * Math.Pow(t, 5) + 4.9;
            Console.WriteLine($"M={M}");

            Console.WriteLine("Практическая работа №2");
            double K, p, e, y;
            Console.WriteLine("Введите значение - p");
            p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - e");
            e = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение -y");
            y = Convert.ToDouble(Console.ReadLine());
            K = (Math.Log(Math.Pow(p, 2) + Math.Pow(y, 3))) + Math.Pow(e, p);
            Console.WriteLine($"K={K}");

            Console.WriteLine("Практическая работа №3");
            double G, n, y2;
            Console.WriteLine("Введите значение - n");
            n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - y2");
            y2 = Convert.ToDouble(Console.ReadLine());
            G = n * (y2 + 3.5) + Math.Sqrt(y2);
            Console.WriteLine($"G={G}");

            Console.WriteLine("Практическая работа №4");
            double D, a, t2;
            Console.WriteLine("Введите значение - a");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - t2");
            t2 = Convert.ToDouble(Console.ReadLine());
            D = 9.8 * Math.Pow(a, 2) + 5.52 * Math.Cos(Math.Pow(t2, 5));
            Console.WriteLine($"D={D}");

            Console.WriteLine("Практическая работа №5");
            double L, x;
            Console.WriteLine("Введите значение - x");
            x = Convert.ToDouble(Console.ReadLine());
            L = 1.51 * Math.Cos(Math.Pow(x, 2)) + 2 * Math.Pow(x, 3);
            Console.WriteLine($"L={L}");

            Console.WriteLine("Практическая работа №6");
            double M1, y3, e2, x2;
            Console.WriteLine("Введите значение - y3");
            y3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - e2");
            e2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - x2");
            x2 = Convert.ToDouble(Console.ReadLine());
            M1 = Math.Cos(2) * y3 + 3.6 * Math.Pow(e2, x2);
            Console.WriteLine($"M1={M1}");

            Console.WriteLine("Практическая работа №7");
            double N, m;
            Console.WriteLine("Введите значение - m");
            m = Convert.ToDouble(Console.ReadLine());
            N = Math.Pow(m, 2) + 2.8 * Math.Abs(m) + 0.55;
            Console.WriteLine($"N={N}");

            Console.WriteLine("Практическая работа №8");
            double T, y4;
            Console.WriteLine("Введите значение - y4");
            y4 = Convert.ToDouble(Console.ReadLine());
            T = Math.Sqrt(Math.Abs(6 * Math.Pow(y4, 2) - 0.1 * y + 4));
            Console.WriteLine($"T={T}");

            Console.WriteLine("Практическая работа №9");
            double V, y5, x3;
            Console.WriteLine("Введите значение - y5");
            y5 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - x3");
            x3 = Convert.ToDouble(Console.ReadLine());
            V = Math.Log(y5 + 0.95) + Math.Sin(Math.Pow(x3, 4));
            Console.WriteLine($"V={V}");

            Console.WriteLine("Практическая работа №10");
            double U, e3, y6, k, x4;
            Console.WriteLine("Введите значение - e3");
            e3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - y6");
            y6 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - k");
            k = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - x4");
            x4 = Convert.ToDouble(Console.ReadLine());
            U = Math.Pow(e3, y6) + 7.355 * Math.Pow(k, 2) + Math.Pow(Math.Sin(x4), 2);
            Console.WriteLine($"U={U}");

            Console.WriteLine("Практическая работа №11");
            double S, y7, x5;
            Console.WriteLine("Введите значение - y7");
            y7 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - x5");
            x5 = Convert.ToDouble(Console.ReadLine());
            S = 9.756 * Math.Pow(y7, 7) + 2 * Math.Tan(x5);
            Console.WriteLine($"S={S}");

            Console.WriteLine("Практическая работа №12");
            double K2, t3, x6;
            Console.WriteLine("Введите значение - t3");
            t3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - x6");
            x6 = Convert.ToDouble(Console.ReadLine());
            K2 = 7 * Math.Pow(t3, 2) + 3 * Math.Sin(Math.Pow(x6, 3)) + 9.2;
            Console.WriteLine($"K2={K2}");

            Console.WriteLine("Практическая работа №13");
            double E, y8;
            Console.WriteLine("Введите значение - y8");
            y8 = Convert.ToDouble(Console.ReadLine());
            E = Math.Sqrt(Math.Abs(3 * Math.Pow(y8, 2) + 0.5 * y + 4));
            Console.WriteLine($"E={E}");

            Console.WriteLine("Практическая работа №14");
            double R, y9, e4, x7;
            Console.WriteLine("Введите значение - y9");
            y9 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - e4");
            e4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - x7");
            x7 = Convert.ToDouble(Console.ReadLine());
            R = Math.Abs(Math.Sqrt(Math.Pow(Math.Sin(y9), 2) + 6.835) + Math.Pow(e4, x7));
            Console.WriteLine($"R={R}");

            Console.WriteLine("Практическая работа №15");
            double H, y10;
            Console.WriteLine("Введите значение - y10");
            y10 = Convert.ToDouble(Console.ReadLine());
            H = Math.Sin(Math.Pow(y10, 2)) - 2.8 * y10 + Math.Sqrt(Math.Abs(y10));
            Console.WriteLine($"H={H}");

            Console.WriteLine("Практическая работа №16");
            double S2, y11;
            Console.WriteLine("Введите значение - y11");
            y11 = Convert.ToDouble(Console.ReadLine());
            S2 = Math.Sqrt(Math.Cos(4) * Math.Pow(y11, 2) + 7.151);
            Console.WriteLine($"S2={S2}");

            Console.WriteLine("Практическая работа №17");
            double N2, y12;
            Console.WriteLine("Введите значение - y12");
            y12 = Convert.ToDouble(Console.ReadLine());
            N2 = 3 * Math.Pow(y12, 2) + Math.Sqrt(y12 + 1);
            Console.WriteLine($"N2={N2}");

            Console.WriteLine("Практическая работа №18");
            double Z, y13;
            Console.WriteLine("Введите значение - y13");
            y13 = Convert.ToDouble(Console.ReadLine());
            Z = 3 * Math.Pow(y13, 2) + Math.Sqrt(Math.Pow(y13, 3) + 1);
            Console.WriteLine($"Z={Z}");

            Console.WriteLine("Практическая работа №19");
            double P, n2, y14, g;
            Console.WriteLine("Введите значение - n2");
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - y14");
            y14 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - g");
            g = Convert.ToDouble(Console.ReadLine());
            P = n2 * Math.Sqrt(Math.Pow(y14, 3) + 1.09 * g);
            Console.WriteLine($"P={P}");

            Console.WriteLine("Практическая работа №20");
            double U2, e5, k2, y15, x8;
            Console.WriteLine("Введите значение - e5");
            e5 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - k2");
            k2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - y15");
            y15 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - x8");
            x8 = Convert.ToDouble(Console.ReadLine());
            U2 = Math.Pow(e5, k2 + y15) + Math.Tan(x8) * Math.Sqrt(y15);
            Console.WriteLine($"U2={U2}");

            Console.WriteLine("Практическая работа №21");
            double P2, e6, y16, h;
            Console.WriteLine("Введите значение - e6");
            e6 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - y16");
            y16 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - h");
            h = Convert.ToDouble(Console.ReadLine());
            P2 = Math.Pow(e6, y16 + 5.5) + 9.1 * Math.Pow(h, 3);
            Console.WriteLine($"P2={P2}");

            Console.WriteLine("Практическая работа №22");
            double T2, u, y17, x9;
            Console.WriteLine("Введите значение - u");
            u = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - y17");
            y17 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - x9");
            x9 = Convert.ToDouble(Console.ReadLine());
            T2 = Math.Sin(2 * u) * Math.Log(2 * Math.Pow(y17, 2) + Math.Sqrt(x9));
            Console.WriteLine($"T2={T2}");

            Console.WriteLine("Практическая работа №23");
            double G2, e7, y18, f;
            Console.WriteLine("Введите значение - e7");
            e7 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - y18");
            y18 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - f");
            f = Convert.ToDouble(Console.ReadLine());
            G2 = Math.Pow(e7, 2 * y18) + Math.Sin(f);
            Console.WriteLine($"G2={G2}");

            Console.WriteLine("Практическая работа №24");
            double F, y19;
            Console.WriteLine("Введите значение - y19");
            y19 = Convert.ToDouble(Console.ReadLine());
            F = 2 * Math.Sin(0.214 * Math.Pow(y19, 5) + 1);
            Console.WriteLine($"F={F}");

            Console.WriteLine("Практическая работа №25");
            double G3, e8, y20, f2;
            Console.WriteLine("Введите значение - e8");
            e8 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - y20");
            y20 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - f2");
            f2 = Convert.ToDouble(Console.ReadLine());
            G3 = Math.Pow(e8, 2 * y20) + Math.Sin(Math.Pow(f2, 2));
            Console.WriteLine($"G3={G3}");

            Console.WriteLine("Практическая работа №26");
            double Z2, p2;
            Console.WriteLine("Введите значение - p2");
            p2 = Convert.ToDouble(Console.ReadLine());
            Z2 = Math.Pow(Math.Sin(Math.Pow(p2, 2) + 0.4), 3);
            Console.WriteLine($"Z2={Z2}");

            Console.WriteLine("Практическая работа №27");
            double W, v, e9, y21, x10;
            Console.WriteLine("Введите значение - v");
            v = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - e9");
            e9 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - y21");
            y21 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - x10");
            x10 = Convert.ToDouble(Console.ReadLine());
            W = 1.03 * v + Math.Pow(e9, 2 * y21) + Math.Tan(Math.Abs(x10));
            Console.WriteLine($"W={W}");

            Console.WriteLine("Практическая работа №28");
            double T3, e10, y22, h2;
            Console.WriteLine("Введите значение - e10");
            e10 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - y22");
            y22 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - h2");
            h2 = Convert.ToDouble(Console.ReadLine());
            T3 = Math.Pow(e10, y22 + h2) + Math.Sqrt(Math.Abs(6.4 * y22));
            Console.WriteLine($"T3={T3}");

            Console.WriteLine("Практическая работа №29");
            double N3, y23;
            Console.WriteLine("Введите значение - y23");
            y23 = Convert.ToDouble(Console.ReadLine());
            N3 = 3 * Math.Pow(y23, 2) + Math.Sqrt(Math.Abs(y + 1));
            Console.WriteLine($"N3={N3}");

            Console.WriteLine("Практическая работа №30");
            double W2, e11, y24, r;
            Console.WriteLine("Введите значение - e11");
            e11 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - y24");
            y24 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение - r");
            r = Convert.ToDouble(Console.ReadLine());
            W2 = Math.Pow(e11, y24 + r) + 7.2 * Math.Sin(r);
            Console.WriteLine($"W2={W2}");

            //ВЫПОЛНИЛИ ЗАЙКА АРСЕНИЙ И КОСАЧЁВ МИХАИЛ (AK Suge Knight)
        }
    }
}

