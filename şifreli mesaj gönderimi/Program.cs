using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace şifreli_mesaj_gönderimi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("mesajınzı giriniz");
            string a = Console.ReadLine();
            Console.WriteLine("sifrelenmiş mesaj");
            char[] sifreliMesaj = new char[a.Length];
            for (int i = 0; i < sifreliMesaj.Length; i++)
            {
                sifreliMesaj[i] = Convert.ToChar((int)a[i] + 60);
                Console.Write(Convert.ToChar((int)a[i] + 60));
            }
            Console.WriteLine("\nDeşifreEdilimiş mesaj");
            for (int i = 0; i < sifreliMesaj.Length; i++)
            {
                Console.Write((char)((int)sifreliMesaj[i] - 60));
            }
            Console.ReadKey();
        }
    }
}
