using System;
using System.Collections.Generic;
using System.Linq;

namespace Dzienniczek_Ucznia
{
    class Dzienniczek
    {
        // stan (zmienne - pola)
        List<float> oceny;

        //zachowanie

        /// <summary>
        /// dodawanie ocen
        /// </summary>
        /// <param name="ocena"></param>
        public void AddRating(float ocena)
        {
            oceny.Add(ocena);
        }
        /// <summary>
        /// Obliczanie średniej i sumy ocen
        /// </summary>
        /// <returns></returns>
        public float CalculateAverage()
        {
            float suma = 0, srednia = 0;

            foreach (var ocena in oceny)
            {
                suma += ocena;
            }

            srednia = suma / oceny.Count();

            return srednia;
        }
        /// <summary>
        /// Wyznaczanie maksymalnej oceny
        /// </summary>
        /// <returns></returns>
        public float pobierzMaxOcene()
        {
            return oceny.Max();
        }
        /// <summary>
        /// Wyznaczanie minimalnej oceny
        /// </summary>
        /// <returns></returns>
        public float PobierzMinOcena()
        {
            return oceny.Min();
        }
    }
}
