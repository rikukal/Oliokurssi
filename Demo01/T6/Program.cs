using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Auton kulutus on 7.02 litraa 100 kilometrin matkalla ja bensan hinta on 1.595 Euroa. 
            Tee ohjelma, joka tulostaa ajetulla matkalla (kysytään käyttäjältä) kuluvan bensan määrän sekä bensaan menevän rahan määrän.
            Esimerkkitoiminta:
            Anna matka > 250 [Enter]
            Bensaa kuluu 17,55 litraa, kustannus 27,99 eurolhlha
            */
            Console.WriteLine("Kuinka monta kilometriä ajoit?");
            string input = Console.ReadLine();

            double matka = Convert.ToDouble(input);            //Tähän matka                 
             
            double  bensa = matka / 100 * 7.02  ;   //  Tähän bensan kulutus

            double euro = bensa * 1.595;          //Tässä tuhlattu € -bensasta

            Console.WriteLine("Ajoit:{0}km, kulutit {1} litraa bensaa ja rahaa bensaan kului {2} euroa", matka, bensa, euro);
        }
    }
}
