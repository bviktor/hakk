using System;
using System.Collections.Generic;
using System.Text;

namespace HAKK
{
    public static class Calculator
    {
        static int forgalmi = 6000;
        static int torzskonyv = 6000;
        static int rendszam = 8500;

        public static int eredetCalc(int kobcenti)
        {
            if (kobcenti >= 2001)
            {
                return 20000;
            }
            else if (kobcenti > 1401)
            {
                return 18500;
            }
            else
            {
                return 17000;
            }
        }

        public static int gadoCalc(int evjarat, int power)
        {
            int ftPerKw;
            int kor = DateTime.Now.Year - evjarat;

            if (kor >= 16)
            {
                ftPerKw = 140;
            }
            else if (kor >= 12)
            {
                ftPerKw = 185;
            }
            else if (kor >= 8)
            {
                ftPerKw = 230;
            }
            else if (kor >= 4)
            {
                ftPerKw = 300;
            }
            else
            {
                ftPerKw = 345;
            }

            return ftPerKw * power;
        }

        public static int vagyonCalc(int evjarat, int power)
        {
            int kor = DateTime.Now.Year - evjarat;
            int[,] illetek = new int[4, 3] { {550, 450, 300}, {650, 550, 450}, {750, 650, 550}, {850, 750, 650} };
            int powerSav;
            int korSav;

            if (power >= 121)
            {
                powerSav = 3;
            }
            else if (power >= 81)
            {
                powerSav = 2;
            }
            else if (power >= 41)
            {
                powerSav = 1;
            }
            else
            {
                powerSav = 0;
            }


            if (kor >= 9)
            {
                korSav = 2;
            }
            else if (kor >= 4)
            {
                korSav = 1;
            }
            else
            {
                korSav = 0;
            }

            int ftPerKw = illetek[powerSav, korSav];

            return ftPerKw * power;
        }

        public static int forgalmiCalc()
        {
            return forgalmi;
        }

        public static int torzskonyvCalc()
        {
            return torzskonyv;
        }

        public static int rendszamCalc()
        {
            return rendszam;
        }

        public static int totalCalc(int evjarat, int kobcenti, int power)
        {
            return eredetCalc(kobcenti) + gadoCalc(evjarat, power) + vagyonCalc(evjarat, power) + forgalmiCalc() + torzskonyvCalc() + rendszamCalc();
        }
    }
}
