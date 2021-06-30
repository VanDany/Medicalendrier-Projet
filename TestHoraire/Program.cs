using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace TestHoraire
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TimeSpan> Horaires = new List<TimeSpan>();

            //GET DUREE CONSULT
            int duree_consult = 15;
            Console.WriteLine("Durée de consultation = " + duree_consult);

            //GET HEURE DEBUT
            TimeSpan Heure_Debut = TimeSpan.Parse("09:00");

            Console.WriteLine("Heure_Debut = "+Heure_Debut);
            

            //GET HEURE FIN
            TimeSpan Heure_Fin = TimeSpan.Parse("14:45");

            Console.WriteLine("Heure_Fin = " + Heure_Fin);

            Console.WriteLine("RDV déjà pris = 10:00");
            Console.WriteLine("RDV déjà pris = 12:30");

            Console.WriteLine("--------------");

            TimeSpan totalMinutes = Heure_Fin.Subtract(Heure_Debut);
            int total = Convert.ToInt32(totalMinutes.TotalMinutes);
            Console.WriteLine("Total en minutes dans l'intervalle = "+total);

            int nb_Slots = total / duree_consult;
            Console.WriteLine("Nombre de slots de rdv = "+ nb_Slots);

            TimeSpan consult = TimeSpan.FromMinutes(duree_consult);
            for (int i = 0; i < nb_Slots; i++)
            {
                Horaires.Add(Heure_Debut);
                Heure_Debut = Heure_Debut.Add(consult);
            }

            List<TimeSpan> Acomparer = new List<TimeSpan>();
            Acomparer.Add(TimeSpan.Parse("10:00"));
            Acomparer.Add(TimeSpan.Parse("12:30"));


            Console.WriteLine("Disponibilités : ");
            bool ok = false;
            for (int i = 0; i < Horaires.Count; i++)
            {
                for (int j = 0; j < Acomparer.Count; j++)
                {
                    if (Horaires[i] == Acomparer[j])
                    {
                        ok = true;
                        Console.WriteLine(Horaires[i] + " Slot déjà réservé");
                    }
                }

                if (!ok)
                {
                    Console.WriteLine(Horaires[i]);
                }

                ok = false;

            }
            Console.ReadKey(true);

        }
    }
}
