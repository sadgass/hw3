using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class Program
    {
        class Complex
        {
            public Complex Copy()
            {
                return new Complex(re: a, im: b);
            }

            public int a, b;

            public Complex(int re, int im)
            {
                a = re;
                b = im;
            }


            public static Complex operator +(Complex x, Complex y)
            {

                return new Complex(re: x.a + y.a, im: x.b + y.b);
            }

            public static Complex operator -(Complex x, Complex y)
            {
                return new Complex(re: x.a - y.a, im: x.b - y.b);
            }
            public static Complex operator *(Complex x, Complex y)
            {
                return new Complex(re:(x.a * y.a)-(x.b * y.b), im: (x.b * y.a)+(x.a * y.b));
            }



            public override string ToString()
            {
                return b >= 0 ? $"{a} + {b}i" : $"{a} - {-b}i";
            }

        }
        static void Main(string[] args)
        {
            Complex complex1 = new Complex(5,11);
            Complex complex2 = new Complex(11,27);
           
            Complex result = complex1+complex2;
            Console.WriteLine( "(" + complex1.ToString()+ ")" + " + " + "(" + complex2.ToString() + ")" + " = "
                +result.ToString());
            result = complex1*complex2;
            Console.WriteLine( "(" + complex1.ToString()+ ")" + " * " + "(" + complex2.ToString() + ")" + " = "
               + result.ToString());
            result = complex1-complex2;
            Console.WriteLine( "(" + complex1.ToString()+ ")" + " - " + "(" + complex2.ToString() + ")" + " = "
               + result.ToString());
        }
    }
}
