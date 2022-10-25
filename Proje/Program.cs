using System;

namespace ConsoleApp1
{
    internal class Program
    {

        static int asal(int x)
        {
            int control = 0;
            for (int i = 2; i < x; i++)
            {
                if (x % i == 0)
                {
                    control++;
                    break;
                }

            }

            if (control == 0)
            {
                Console.WriteLine("sayi:" + x);
                return 1;
            }
            else
            {
                return 0;
            }

        }

        static void Main(string[] args)
        {
            int[] numbers = new int[15]; int sum = 0; double ort = 0; int sayma = 0; int Kontrol = 0; int eleman = 0; int asalsum = 0; int asalort = 0;

            Console.WriteLine("Sayilari Giriniz\n");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write((i + 1) + ".sayi:");
                numbers[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                {
                    sum += numbers[i];
                }
                ort = Convert.ToDouble(sum) / 15;
            }
            Console.Write("\nSayilarin toplami:" + sum); Console.Write("  Sayilarin ortalamasi:" + ort + "\n");
            Console.WriteLine("\nOrtalamadan buyuk Sayilar");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (ort < numbers[i])
                {
                    sayma++;
                    Console.WriteLine("Sayi:" + numbers[i]);
                }
            }
            Console.WriteLine("\nOrtalamadan buyuk Asal sayilar");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (ort < numbers[i])
                {
                    int a = numbers[i];
                    Kontrol = asal(a);
                    if (Kontrol == 1)
                    {
                        eleman++;
                        asalsum = asalsum + numbers[i];
                    }
                }
            }
            asalort = asalsum / eleman;
            Console.Write("\nAsal sayilarin toplami:" + asalsum); Console.Write("  Asal sayilarin ortalamasi:" + asalort+"\n");
            /*
⡴⠑⡄⠀⠀⠀⠀⠀⠀⠀ ⣀⣀⣤⣤⣤⣀⡀
⠸⡇⠀⠿⡀⠀⠀⠀⣀⡴⢿⣿⣿⣿⣿⣿⣿⣿⣷⣦⡀
⠀⠀⠀⠀⠑⢄⣠⠾⠁⣀⣄⡈⠙⣿⣿⣿⣿⣿⣿⣿⣿⣆
⠀⠀⠀⠀⢀⡀⠁⠀⠀⠈⠙⠛⠂⠈⣿⣿⣿⣿⣿⠿⡿⢿⣆
⠀⠀⠀⢀⡾⣁⣀⠀⠴⠂⠙⣗⡀⠀⢻⣿⣿⠭⢤⣴⣦⣤⣹⠀⠀⠀⢀⢴⣶⣆
⠀⠀⢀⣾⣿⣿⣿⣷⣮⣽⣾⣿⣥⣴⣿⣿⡿⢂⠔⢚⡿⢿⣿⣦⣴⣾⠸⣼⡿
⠀⢀⡞⠁⠙⠻⠿⠟⠉⠀⠛⢹⣿⣿⣿⣿⣿⣌⢤⣼⣿⣾⣿⡟⠉
⠀⣾⣷⣶⠇⠀⠀⣤⣄⣀⡀⠈⠻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇
⠀⠉⠈⠉⠀⠀⢦⡈⢻⣿⣿⣿⣶⣶⣶⣶⣤⣽⡹⣿⣿⣿⣿⡇
⠀⠀⠀⠀⠀⠀⠀⠉⠲⣽⡻⢿⣿⣿⣿⣿⣿⣿⣷⣜⣿⣿⣿⡇
⠀⠀ ⠀⠀⠀⠀⠀⢸⣿⣿⣷⣶⣮⣭⣽⣿⣿⣿⣿⣿⣿⣿⠇
⠀⠀⠀⠀⠀⠀⣀⣀⣈⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠇
⠀⠀⠀⠀⠀⠀⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿             
                     */                   
             
        }
    }
}
