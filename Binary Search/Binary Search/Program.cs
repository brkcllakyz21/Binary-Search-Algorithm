using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[10];
            int başlangıç = 0, bitiş = sayilar.GetUpperBound(0), orta = (başlangıç + bitiş) / 2, arananSayi = 0;
            Console.WriteLine("Aranacak sayıyı giriniz = ");
            arananSayi = Convert.ToInt32(Console.ReadLine());
            while (başlangıç <= bitiş)
            {
                orta = (başlangıç + bitiş) / 2;
                if (sayilar[orta] > arananSayi)
                {
                    bitiş = orta - 1;
                }
                else if (sayilar[orta] < arananSayi)
                {
                    başlangıç = orta + 1;
                }
                else
                {

                }

            }




        }
    }
}
