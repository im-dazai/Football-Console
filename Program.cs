using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int x, y, z, spc;   // Header - Main Loop 1
            x = 6;
            y = 1;
            z = 1;
            spc = 1;
            while (y <= x)
            {
                z = 2;
                while (z <= x)
                {
                    Console.Write("  ");
                    z++;
                }

                z = y;
                while (z <= x)
                {
                    Console.Write("  ");
                    z++;
                }

                z = 1;
                while (z < y)
                {
                    Console.Write("# ");
                    z++;
                }

                z = 2;
                while (z <= x)
                {
                    Console.Write("# ");
                    z++;
                }

                z = 2;
                while (z <= x)
                {
                    Console.Write("# ");
                    z++;
                }

                z = 1;
                while (z <= y)
                {
                    Console.Write("# ");
                    z++;
                }
                z = y;  
                while (z <= x)
                {
                    Console.Write("# ");
                    z++;
                }

                z = 1;
                while (z <= y)
                {
                    Console.Write("# ");
                    z++;
                }

                Console.WriteLine();
                y++;
            }






            int a, b, c, d, e;            // Shoulder - Main Loop 2
            a = 5;
            b = 1;
            c = 1;
            d = 1;




            while (c <= a)  
            {
                d = c;                    
                while (d <= a)
                {
                    Console.Write("  ");
                    d++;
                }

                b = 1;                  
                while (b <= a)
                {
                    Console.Write("# ");
                    b++;
                }

                b = 1;                
                while (b <= c)
                {
                    Console.Write("  ");
                    b++;
                }
                b = 1;                  
                while (b <= c)
                {
                    Console.Write("  ");
                    b++;
                }

                d = c;                   
                while (d <= a)
                {
                    Console.Write("  ");
                    d++;
                }
                b = 1;               
                while (b <= c)
                {
                    Console.Write("  ");
                    b++;
                }
                d = c;                  
                while (d <= a)
                {
                    Console.Write("  ");
                    d++;
                }
                b = 1;                 
                while (b <= c)
                {
                    Console.Write("  ");
                    b++;
                }

                d = c;                  
                while (d <= a)
                {
                    Console.Write("  ");
                    d++;
                }
                b = 1;                  
                while (b <= c)
                {
                    Console.Write("  ");
                    b++;
                }

                b = 1;             
                while (b <= a)
                {
                    Console.Write("# ");
                    b++;
                }

                b = c;               
                while (b <= a)
                {
                    Console.Write("  ");
                    b++;
                }
                


                Console.WriteLine();
                c++;

            }
            int sp;         // Shoulder - Main Loop 3
            a = 5;
            sp = 1;
            b = 1;
            c = 1;
            while (c <= a)
            {
                sp = 1;
                b = 0;
                while (b <= sp)
                {
                    Console.Write(" ");
                    b++;
                }

                b = 1;
                while (b <= a)
                {
                    Console.Write("# ");
                    b++;
                }

                sp = 1;
                b = 0;
                while (b <= sp)
                {
                    Console.Write("  ");
                    b++;
                }
                sp = 1;
                b = 0;
                while (b <= sp)
                {
                    Console.Write("  ");
                    b++;
                }
                sp = 1;
                b = 0;
                while (b <= sp)
                {
                    Console.Write("  ");
                    b++;
                }

                sp = 1;
                b = 0;
                while (b <= sp)
                {
                    Console.Write("  ");
                    b++;
                }

            

                sp = 1;
                b = 0;
                while (b <= sp)
                {
                    Console.Write("  ");
                    b++;
                }

                sp = 1;
                b = 0;
                while (b <= sp)
                {
                    Console.Write("  ");
                    b++;
                }
                a = 1;
                b = 1;
                while (b <= a)
                {
                    Console.Write("R7Official");          // Text 
                    b++;
                }
                sp = 1;
                b = 0;
                while (b <= sp)
                {
                    Console.Write("  ");
                    b++;
                }

                

                sp = 1;
                b = 0;
                while (b <= sp)
                {
                    Console.Write("  ");
                    b++;
                }
                sp = 1;
                b = 0;
                while (b <= sp)
                {
                    Console.Write("  ");
                    b++;
                }


                sp = 1;
                b = 0;
                while (b <= sp)
                {
                    Console.Write("  ");
                    b++;
                }

                sp = 1;
                b = 0;
                while (b <= sp)
                {
                    Console.Write("  ");
                    b++;
                }
                sp = 1;
                b = 0;
                while (b <= sp)
                {
                    Console.Write(" ");
                    b++;
                }

                sp = 1;
                b = 0;
                while (b <= sp)
                {
                    Console.Write("# ");
                    b++;
                }
                sp = 1;
                b = 0;
                while (b <= sp)
                {
                    Console.Write("# ");
                    b++;
                }
                
                b = 1;
                while (b <= a)
                {
                    Console.Write("# ");
                    b++;
                }



                Console.WriteLine();
                c++;
            }

            int spa;                 // Body - Main Loop 4
            a = 5;
            sp = 1;
            b = 1;
            c = 1;
            while (c <= a)
            {
                sp = 1;
                b = 0;
                while (b <= sp)
                {
                    Console.Write(" ");
                    b++;
                }

                b = 1;
                while (b <= a)
                {
                    Console.Write("# ");
                    b++;
                }

                sp = 1;
                b = 0;
                while (b <= sp)
                {
                    Console.Write("  ");
                    b++;
                }
                sp = 1;
                b = 0;
                while (b <= sp)
                {
                    Console.Write("  ");
                    b++;
                }
                sp = 1;
                b = 0;
                while (b <= sp)
                {
                    Console.Write("  ");
                    b++;
                }

                sp = 1;
                b = 0;
                while (b <= sp)
                {
                    Console.Write("  ");
                    b++;
                }

                sp = 1;
                b = 0;
                while (b <= sp)
                {
                    Console.Write("  ");
                    b++;
                }
                sp = 1;
                b = 0;
                while (b <= sp)
                {
                    Console.Write("  ");
                    b++;
                }

                sp = 1;
                b = 0;
                while (b <= sp)
                {
                    Console.Write("  ");
                    b++;
                }

                sp = 1;
                b = 0;
                while (b <= sp)
                {
                    Console.Write("  ");
                    b++;
                }

                sp = 1;
                b = 0;
                while (b <= sp)
                {
                    Console.Write("  ");
                    b++;
                }
                sp = 1;
                b = 0;
                while (b <= sp)
                {
                    Console.Write("  ");
                    b++;
                }
                sp = 1;
                b = 0;
                while (b <= sp)
                {
                    Console.Write("  ");
                    b++;
                }
                sp = 1;
                b = 0;
                while (b <= sp)
                {
                    Console.Write("  ");
                    b++;
                }

                sp = 1;
                b = 0;
                while (b <= sp)
                {
                    Console.Write("  ");
                    b++;
                }
                sp = 1;
                b = 0;
                while (b <= sp)
                {
                    Console.Write("  ");
                    b++;
                }

                b = 1;
                while (b <= a)
                {
                    Console.Write("# ");
                    b++;
                }



                Console.WriteLine();
                c++;
            }

            int p, l, m;                // Legs - Main Loop 5
            p = 5;
            l = 1;
            m = 1;
            while (l <= p)
            {
                m = 1;
                while (m <= l)
                {
                    Console.Write("  ");
                    m++;
                }

                m = 1;                 
                while (m <= p)
                {
                    Console.Write("# ");
                    m++;
                }

                m = l;                
                while (m <= p)
                {
                    Console.Write("  ");
                    m++;
                }

                m = 1;                   
                while (m <= p)
                {
                    Console.Write("  ");
                    m++;
                }
                m = 1;                  
                while (m <= p)
                {
                    Console.Write("  ");
                    m++;
                }

                m = l;
                while (m <= p)
                {
                    Console.Write("  ");
                    m++;
                }

                m = 1;
                while (m <= l)
                {
                    Console.Write("  ");
                    m++;
                }

                m = 1;
                while (m < p)
                {
                    Console.Write(" ");
                    m++;
                }

                m = l;
                while (m <= p)
                {
                    Console.Write("  ");
                    m++;
                }

               

                m = 1;
                while (m <= p)
                {
                    Console.Write("# ");
                    m++;
                }

                Console.WriteLine();
                l++;
            }

            int t, u, v;
            t = 5;
            v = 1;
            u = 1;

            while (v <= t)          // Footer - Main Loop 6
            {
                u = 1;
                while (u <= t)
                {
                    Console.Write("  ");
                    u++;
                }

                u = 1;
                while (u <= v)
                {
                    Console.Write("  ");
                    u++;
                }
                u = v;
                while (u <= t)
                {
                    Console.Write("# ");
                    u++;
                }

                u = 1;
                while (u <= t)
                {
                    Console.Write("# ");
                    u++;
                }

                u = 1;
                while (u <= t)
                {
                    Console.Write("# ");
                    u++;
                }

                u = v;
                while (u <= t)
                {
                    Console.Write("# ");
                    u++;
                }

                u = 1;
                while (u <= v)
                {
                    Console.Write("# ");
                    u++;
                }

                u = 1;
                while (u <= t - 3)
                {
                    Console.Write("# ");
                    u++;
                }

                u = v;
                while (u <= t)
                {
                    Console.Write("# ");
                    u++;
                }

                Console.WriteLine();
                v++;
            }

            Console.ReadLine();
        }
    }
}
