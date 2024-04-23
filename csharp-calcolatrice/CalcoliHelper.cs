using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace csharp_calcolatrice
{
    internal static class CalcoliHelper
    {
        // POLIMORFIZMO
        public static int Somma(int a, int b)
        {
            return a + b;
        }

        public static double Somma(double a, double b)
        {
            return a + b;
        }

        public static int Sottrazione(int a, int b)
        {
            return a - b;
        }

        public static double Sottrazione(double a, double b)
        {
            return a - b;
        }

        public static int Moltiplicazione(int a, int b)
        {
            return a * b;
        }

        public static double Moltiplicazione(double a, double b)
        {
            return a * b;
        }

        public static int ValoreAssoluto(int a)
        {
            return a < 0 ? -a : a;
        }

        public static double ValoreAssoluto(double a)
        {
            return a < 0 ? -a : a;
        }

        public static int Min(int a, int b)
        {
            return a <= b ? a : b;
        }

        public static double Min(double a, double b)
        {
            return a <= b ? a : b;
        }

        public static int Max(int a, int b)
        {
            return a >= b ? a : b;
        }

        public static double Max(double a, double b)
        {
            return a >= b ? a : b;
        }
    }
}
