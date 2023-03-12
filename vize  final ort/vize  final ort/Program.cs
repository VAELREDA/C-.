using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vize__final_ort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vize, final, ort;

            Console.WriteLine("vize notu giriniz");
            vize =Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("final notu giriniz");
            final = Convert.ToDouble(Console.ReadLine());

            ort= vize*0.4+final*0.6;

            Console.WriteLine("***** ogrenci durumu *****");
            Console.WriteLine("vize notu: "+vize);
            Console.WriteLine("final notu: "+ final);
            Console.WriteLine("ort: "+ ort);
            /* 90-100 AA
             * 85-89 BA
             * 75-84 BB
             * 70-74 CB
             * 60-69 CC
             * 55-59 DC
             * 50-54 DD
             * 40-49 FD
             * 0-39 FF */
            if (ort >= 60) 
            {
                if (ort >= 90 && ort <= 100) Console.WriteLine("ortalama harfle: AA");
                if (ort >= 85 && ort < 90) Console.WriteLine("ortalama harfle: BA");
                if (ort >= 75 && ort < 85) Console.WriteLine("ortalama harfle: BB");
                if (ort >= 70 && ort < 75) Console.WriteLine("ortalama harfle: CB");
                if (ort >= 60 && ort < 70) Console.WriteLine("ortalama harfle: CC");
                Console.WriteLine("GECTINIZ");
            }
            if (ort < 60) 
            {
                if (ort >= 55 && ort < 60) Console.WriteLine("ortalama harfle: DC");
                if (ort >= 50 && ort < 55) Console.WriteLine("ortalama harfle: DD");
                if (ort >= 40 && ort < 50) Console.WriteLine("ortalama harfle: FD");
                if (ort >= 0 && ort < 40) Console.WriteLine("ortalama harfle: FF");
                Console.WriteLine("KALDINIZ");
            }
            Console.ReadLine(); 

        }


    }
}

