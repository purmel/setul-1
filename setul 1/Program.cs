using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace setul_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ex1();
            //ex2();
            //ex3();  
            //ex4();
            //ex5();
            //ex6();
            //ex7();
            //ex8();
            //ex9();
            //ex10();
            //ex11();
            //ex12();
            //ex13();
            //ex14();
            //ex15();
            //ex16();
            //ex17();
            //ex18();
            //ex19();
        }

        private static void ex19()
        {
            Console.Write("Introduceti un numar: ");
            string input = Console.ReadLine();

            if (EsteNumarCuDouaCifreRepetate(input))
                Console.WriteLine("Numarul este format doar din doua cifre care se pot repeta ");

            else
                Console.WriteLine("Numarul nu este format doar din doua cifre care se pot repeta ");
        }

        static bool EsteNumarCuDouaCifreRepetate(string input)
        {
            if (!SuntDoarCifre(input))
            {
                return false;
            }

            var cifreDistincte = NumarCifreDistincte(input);
            return cifreDistincte == 2;
        }

        static bool SuntDoarCifre(string input)
        {
            foreach (char caracter in input)
            {
                if (!char.IsDigit(caracter))
                    return false;

            }
            return true;
        }

        static int NumarCifreDistincte(string input)
        {
            int cifreDistincte = 0;
            for (int i = 0; i < input.Length; i++)
            {
                bool esteCifraDistincta = true;
                for (int j = 0; j < i; j++)
                {
                    if (input[i] == input[j])
                    {
                        esteCifraDistincta = false;
                        break;
                    }
                }

                if (esteCifraDistincta)
                    cifreDistincte++;

            }

            return cifreDistincte;
        }

        private static void ex18()
        {
            int n;
            Console.Write("Introduceti numarul: ");
            n= int.Parse(Console.ReadLine());
            Console.Write($"{n}= ");
            for(int d=2; d*d<=n;d++)
            {
                int p = 0;
                while (n%d==0)
                {
                    n = n / d;
                    p++;
                }
                if(p>0)
                    Console.Write($"{d}^{p} x ");
            }
            if (n > 1)
                Console.Write($"{n}^1");
        }

        private static void ex17()
        {
            int a, b;
            Console.Write("Introduceti primul numar: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Introduceti al doilea numar: ");
            b = int.Parse(Console.ReadLine());
            Cmmdc(a,b);
            Console.WriteLine($"Cel mai mare divizor comun este {a}.");
            Console.WriteLine($"Cel mai mic multiplu comun ale celor doua numere {a} si {b} este: "+ (a * b)/ Cmmdc(a,b));
        }

        private static int Cmmdc(int a, int b)
        {
            if (a != b)
            {
                if (a > b)
                    a = a - b;
                else b = b - a;
            }
            return a;
        }

        private static void ex16()
        {
            int a, b, c, d, e;
            Console.Write("Introduceti primul numar: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Introduceti al doilea numar: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Introduceti al treilea numar: ");
            c = int.Parse(Console.ReadLine());
            Console.Write("Introduceti al patrulea numar: ");
            d= int.Parse(Console.ReadLine());
            Console.Write("Introduceti al cincilea numar: ");
            e = int.Parse(Console.ReadLine());
            int aux = 0;
            if (a > b)
            {
                aux = a;
                a = b;
                b = aux;
            }
            if (b > c)
            {
                aux = b;
                b = c;
                c = aux;
            }
            if (a > b)
            {
                aux = a;
                a = b;
                b = aux;
            }
            if (d > e)
            {
                aux = d;
                d = e;
                e = aux;
            }
            if (c > d)
            {
                aux = c;
                c = d;
                d = aux;
            }
            if (b > c)
            {
                aux = b;
                b = c;
                c = aux;
            }
            if (a > b)
            {
                aux = a;
                a = b;
                b = aux;
            }
            Console.WriteLine($"Numerele in ordine crescatoare sunt {a}, {b}, {c}, {d}, {e}.");
        }

        private static void ex15()
        {
            int a, b, c;
            Console.Write("Introduceti primul numar: ");
            a=int.Parse(Console.ReadLine());
            Console.Write("Introduceti al doilea numar: ");
            b=int.Parse(Console.ReadLine());
            Console.Write("Introduceti al treilea numar: ");
            c=int.Parse(Console.ReadLine());
            int aux = 0;
            if(a>b)
            {
                aux = a;
                a = b;
                b=aux;
            }
            if(b>c)
            {
                aux = b;
                b = c;
                c = aux;
            }
            if(a>b)
            {
                aux = a;
                a = b;
                b = aux;
            }
            Console.WriteLine($"Numerele in ordinea crescatoare sunt {a}, {b}, {c}");
            
        }

        private static void ex14()
        {
            int n, pali=0;
            Console.Write("Introduceti un numar: ");
            n=int.Parse(Console.ReadLine());
            int aux = n;
            while(n!=0)
            {
                pali = pali * 10 + n % 10;
                n = n / 10;
            }
            if (pali == aux)
                Console.WriteLine($"Numarul {aux} este palindrom.");
            else Console.WriteLine($"Numarul {aux} nu este palindrom.");
        }

        private static void ex13()
        {
            int y1, y2, cont=0;
            Console.Write("Introducet primul an: ");
            y1=int.Parse(Console.ReadLine());
            Console.Write("Introduceti al doilea an: ");
            y2=int.Parse(Console.ReadLine());
            for(int i = y1+1; i < y2; i++)
            {
                if (i % 4 == 0 && i % 100 != 0)
                    cont++;
            }
            Console.WriteLine($"Numarul anilor bisecti intre anii {y1} si {y2} este {cont}.");
        }

        private static void ex12()
        {
            int a, b, n;
            Console.Write("Introduceti parametrul minim al intervalului: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Introduceti parametrul maxim al intervalului: ");
            b= int.Parse(Console.ReadLine());
            Console.Write("Introduceti o valoare pentru n: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Numerele divizibile cu n din intervalul [a,b] sunt: ");
            for(int i=a; i<=b; i++)
            {
                if (i % n == 0)
                    Console.Write(i + " ");
            }
        }

        private static void ex11()
        {
            int n;
            n= int.Parse(Console.ReadLine());
            while(n!=0)
            {
                Console.Write(n%10+" ");
                n = n / 10;
            }
        }

        private static void ex10()
        {
            int n, cont=1;
            n= int.Parse(Console.ReadLine());
            if (n < 2)
                Console.WriteLine($"Numarul {n} nu e prim.");
            if (n == 2 || n == 3)
                Console.WriteLine($"Numarul {n} este prim");
            if (n % 2 == 0 || n % 3 == 0)
                Console.WriteLine($"Numarul {n} nu este prim");
            for (int d=3; d*d<=n;d+=2)
            {
                 if (n % d == 0)
                     cont=0;
            }
            if (cont == 0)
                Console.WriteLine($"Numarul {n} nu este prim");
            else Console.WriteLine($"Numarul {n} este prim");
        }

        private static void ex9()
        {
            int n;  
            Console.Write("Introduceti valoarea lui n:");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
               if (n % i == 0)
               {
                   Console.Write(i + " ");
               }
            }
        }

        private static void ex8()
        {
            int a, b;
            Console.Write("Introduceti valoarea primului numar: ");
            a= int.Parse(Console.ReadLine());
            Console.Write("Introduceti valoarea celui de al doilea numar: ");
            b= int.Parse(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"{a} {b}"); 
        }

        private static void ex7()
        {
            int a, b, aux=0;
            Console.Write("Introduceti primul numar: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Introduceti al doilea numar: ");
            b=int.Parse(Console.ReadLine());
            aux = a;
            a=b; 
            b=aux;
            Console.WriteLine($"{a} si {b}");
        }

        private static void ex6()
        {
            float a, b, c;
            Console.Write("Valoarea lungimii primei laturi este: ");
            a=float.Parse(Console.ReadLine());
            Console.Write("Valoarea lungimii celei de a doua laturi este: ");
            b=float.Parse(Console.ReadLine());
            Console.Write("Valoarea celei de a treia latura este: ");
            c=float.Parse(Console.ReadLine());
            if(a>0 && b>0 && c>0)
            {
                if (a < b + c && b < a + c && c < a + b)
                    Console.WriteLine("Valorile introduse pot fii lungimile laturilor unui triunghi.");
                else
                    Console.WriteLine("Valorile introduse nu pot fii lungimile laturilor unui triunghi.");
            }
        }

        private static void ex5()
        {
            int k;
            long n, x;
            n= long.Parse(Console.ReadLine());
            k= int.Parse(Console.ReadLine());
            if (k == 1) Console.WriteLine(n % 10);
            else
            {
                while (k > 1)
                {
                    k--;
                    n = n / 10;
                }
                x = n % 10;
                Console.WriteLine(x);
            }
            
        }

        private static void ex4()
        {
            int y;
            y= int.Parse(Console.ReadLine());
            if (y % 4 == 0 && y%100!=0)
            {
                Console.WriteLine("Anul {0} este bisect.", y);
            }
            else Console.WriteLine("Anul {0} nu este bisect.", y);
        }

        private static void ex3()
        {
            int n, k;
            n= int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            if (n % k == 0)
            {
                Console.WriteLine("Numarul {0} se divide cu {1}", n, k);
            }
            else
                Console.WriteLine("Numarul {0} nu este divizibil cu {1}", n, k);
        }

        private static void ex2()
        {
            float a, b, c, delta;
            double x1, x2;
            Console.Write("a = ");
            a = float.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = float.Parse(Console.ReadLine());
            Console.Write("c = ");
            c = float.Parse(Console.ReadLine());
            if (a == 0)
                if (b == 0)
                    if (c == 0) Console.WriteLine("Ecuatie nedeterminata");
                    else Console.WriteLine("Ecuatie imposibila");
                else
                {
                    x1 = -c / b;
                    Console.WriteLine("Ecuatia de gradul I cu x1 = {0}", x1);
                }
            else
            {
                delta = b * b - 4 * a * c;
                if (delta < 0)
                    Console.WriteLine("Ecuatia are solutii complxe");
                else
                {
                    if (delta == 0)
                    {
                        x1 = x2 = -b / (2 * a);
                        Console.WriteLine("x1 = x2 = {0}", x1);
                    }
                    else
                    {
                        x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                        x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                        Console.WriteLine("Solutiile sunt x1 = {0}, x2 = {1}", x1, x2);
                    }
                }
            }
            Console.ReadLine();
        }

        private static void ex1()
        {
            int a, b;
            float x;
            Console.Write("Introduceti valoarea coeficientului lui a pentru functia de gradul I ax + b: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Introduceti valoarea pentru termenul liber al functiei de gardul I: ");
            b = int.Parse(Console.ReadLine());
            if (a == 0)
            {
                if (b == 0) Console.WriteLine("Avem o infinitate de solutii");
                else Console.WriteLine("Nu avem solutie");
            }
            else
            {
                x = -b / a;
                Console.Write("x= " + x);
            }
        }
    }
}
