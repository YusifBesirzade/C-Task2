using System.Text;

namespace Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 __________________

            //int ilkeded = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("ilk eded:" + " " + ilkeded);
            //int ikincieded = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("ikinci eded:" + " " + ikincieded);
            //if (ilkeded > ikincieded)
            //{
            //    Console.WriteLine("En boyuk eded:" + " " + ilkeded);
            //}
            //else
            //{
            //    Console.WriteLine("En boyuk eded:" + " " + ikincieded);
            //}

            // 2 __________________

            //int verilenEded = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Verilen Ededimiz:" + " " + verilenEded);
            //if (verilenEded % 2 == 0)
            //{
            //    Console.WriteLine("Eded 2-ye qaliqsiz Bolunur!");
            //}
            //else
            //{
            //    Console.WriteLine("Eded 2-ye qaliqsiz Bolunmur!");
            //}

            // 3 ___________________

            //int eded = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Daxil edilen eded:" + " " + eded);
            //if (eded >= 100)
            //{
            //    Console.WriteLine("Boyuk");
            //}
            //else
            //{
            //    Console.WriteLine("Kicik");
            //}

            // 4 ___________________

            //int yas = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Daxil edilen yas:" + " " + yas);
            //if(yas > 18)
            //{
            //    Console.WriteLine("Adult");
            //}
            //else
            //{
            //    Console.WriteLine("Child");
            //}

            // 5 ____________________

            //int ededyoxla = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Daxil edilen eded:" + ededyoxla);
            //if(ededyoxla == 0)
            //{
            //    Console.WriteLine("0 ne musbetdir, ne de menfi");
            //}
            //else if ( ededyoxla > 0 )
            //{
            //    Console.WriteLine("Eded Musbetdir");
            //}
            //else
            //{
            //    Console.WriteLine("Eded Menfidir");
            //}

            // 6 _____________________

            //int hefteningunu = Convert.ToInt32(Console.ReadLine());
            //switch (hefteningunu)
            //{
            //    case 1:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    case 4:
            //        Console.WriteLine("Thursday");
            //        break;
            //    case 5:
            //        Console.WriteLine("Friday");
            //        break;
            //    case 6:
            //        Console.WriteLine("Saturday");
            //        break;
            //    case 7:
            //        Console.WriteLine("Sunday");
            //        break;
            //    default:
            //        Console.WriteLine("Gunu duzgun daxil edin");
            //        break;
            //}

            // 7 _____________________

            //int hesablanacaqeded = Convert.ToInt32(Console.ReadLine());
            //int kubhesabla = hesablanacaqeded * hesablanacaqeded * hesablanacaqeded;
            //Console.WriteLine("Ededin Kubu:" + kubhesabla);


            // 8 _____________________

            //int aygunleri = Convert.ToInt32(Console.ReadLine());
            //switch(aygunleri)
            //{
            //    case 1:
            //        Console.WriteLine("Yanvar 31 gundur");
            //        break;
            //    case 2:
            //        Console.WriteLine("Fevral 28 gundur");
            //        break;
            //    case 3:
            //        Console.WriteLine("Mart 31 gundur");
            //        break;
            //    case 4:
            //        Console.WriteLine("Aprel 30 gundur");
            //        break;
            //    case 5:
            //        Console.WriteLine("May 31 gundur");
            //        break;
            //    case 6:
            //        Console.WriteLine("Iyun 30 gundur");
            //        break;
            //    case 7:
            //        Console.WriteLine("Iyul 31 gundur");
            //        break;
            //    case 8:
            //        Console.WriteLine("Avqust 31 gundur");
            //        break;
            //    case 9:
            //        Console.WriteLine("Sentyabr 30 gundur");
            //        break;
            //    case 10:
            //        Console.WriteLine("Oktyabr 31 gundur");
            //        break;
            //    case 11:
            //        Console.WriteLine("Noyabr 30 gundur");
            //        break;
            //    case 12:
            //        Console.WriteLine("Dekabr 31 gundur");
            //        break;
            //}

            // 9 _____________________

            //string[] fruit = { "Alma", "Armud", "Heyva", "Nar", "Banan", "Alca", "Gilas" };

            // 10 _____________________

            //string[] students = { "Eli", "Mehemmmed", "Yusif", "Nihad", "Seyid", "Huseyin", "Letif", "Nicat", "Fuad", "Anar" };

            // 11 _____________________

            //string[] students = { "Eli", "Mehemmmed", "Yusif", "Nihad", "Seyid", "Huseyin", "Letif", "Nicat", "Fuad", "Anar" };
            //for (int i = 0; i < students.Length; i++)
            //{
            //    Console.WriteLine(students[i]);
            //}

            // 12 _____________________

            //string[] students = { "Eli", "Mehemmmed", "Yusif", "Nihad", "Seyid", "Huseyin", "Letif", "Nicat", "Fuad", "Anar" };
            //Console.WriteLine(students[4]);

            // 13 _____________________

            //string[] travels = { "Turkiye", "Almaniya", "Rusiya", "Amerika", "Italiya"};

            // 14 _____________________

            //int[] ededler = {20, 34, 21, 98, 45, 12, 34, 65, 11, 34, 54, 30 };
            //for (int i = 0; i < ededler.Length; i++)
            //{
            //    if (ededler[i] % 3 == 0)
            //    {
            //        Console.WriteLine(ededler[i]);
            //    }
            //}

            // 15 _____________________

            //int[] ededler = { 20, 34, 21, 98, 45, 12, 34, 65, 11, 34, 54, 30 };
            //Array.Sort(ededler);
            //Console.WriteLine("Minimum:" + " " + ededler[0]);
            //Console.WriteLine("Maximum:" + " " + ededler[ededler.Length-1]);
            //int cem = 0;
            //for (int i = 0; i < ededler.Length; i++)
            //{
            //    cem+=ededler[i];
            //}
            //int edediorta = cem / ededler.Length;
            //Console.WriteLine("Ededi orta:" + " " + edediorta);


            // 16 _____________________

            //int eded = Convert.ToInt32(Console.ReadLine());
            //bool isPrime = false;
            //for (int i = 2; i < eded; i++)
            //{
            //    if (eded % i == 0) { isPrime = false; break; }
            //    else isPrime = true;
            //}

            //if (!isPrime) Console.WriteLine("Prime Deyil");
            //else Console.WriteLine("Primedir");




            // 17 _____________________

            //int[] arr = [23, 60, 12, 43, 56, 100, 23, 43, 21, 36, 72];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i]%6==0)
            //    {
            //        Console.WriteLine(arr[i]);
            //    }
            //}

            // 18 _____________________ Calculator qalib

            //Console.WriteLine("ilk ededi daxil edin:");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("ikinci ededi daxil edin:");
            //int b = Convert.ToInt32(Console.ReadLine());

            // 19 _____________________

            //double[] productsprice = [100.0, 1300.50, 259.99, 430.30, 168.99, 320.0];
            //double discount = 0.2;
            //for (int i = 0; i < productsprice.Length; i++)
            //{
            //    double newprice = productsprice[i] - (productsprice[i] * discount);
            //    Console.WriteLine(newprice);
            //}

            // 20 _____________________

            //int[] isciyasi = [23, 34, 19, 65, 40, 66, 29, 35, 67, 64, 60, 32, 57];
            //for (int i = 0; i < isciyasi.Length; i++)
            //{
            //    if (isciyasi[i] >= 65)
            //    {
            //        Console.WriteLine(isciyasi[i] + " " + "Teqaude Ayrildiniz");
            //    }
            //}

            // 21 _____________________

            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Convert.ToInt32(Console.ReadLine());
            //int kvadratcem = (a * a) + (b * b);
            //if (c*c == kvadratcem)
            //{
            //    Console.WriteLine("Duzbucaqli Ucbucaqdir");
            //}
            //else if (a == b && a == c && b == c)
            //{
            //    Console.WriteLine("Beraberterefli Ucbucaqdir");
            //}
            //else if (a == b || a == c || b == c)
            //{
            //    Console.WriteLine("Beraberyanli Ucbucaqdir");
            //}
            //else
            //{
            //    Console.WriteLine("Muxtelifterefli Ucbucaqdir");
            //}

            // 22 _____________________

            for (int i = 0; i < 100; i++)
            {
                int teyinolunmus = 34;
                Console.WriteLine(i);
                for (int say = 1; say <= 5; say++)
                {
                    int eded = Convert.ToInt32(Console.ReadLine());
                    if (eded == teyinolunmus)
                    {
                        Console.WriteLine("You Won");
                        break;
                    }
                    else if(say == 5)
                    {
                        Console.WriteLine("Game Over");
                    }
                }  
                break;
            }

            // 23 _____________________

            // Kvadratin, duzbucaqli dordbucagin, ucbucagin sahelerini hesablayan alqoritm yazin

            // 24 _____________________

            // Verilmis ededin polindron oldugunu yoxlayin (1221, 3443) (String convertsiz)
        }
    }
}
