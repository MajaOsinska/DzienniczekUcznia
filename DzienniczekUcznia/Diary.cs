using System;
using System.Collections.Generic;
using System.Linq;

namespace DzienniczekUcznia
{
    class Diary
    {
        // Stan (zmienne - pola)
        List<float> ratings = new List<float>();


        // Zachowania
        public void AddRating(float rating)
        {
            ratings.Add(rating);
        }

        internal void AddRating(int v1, int v2)
        {
            throw new NotImplementedException();
        }

        public float CalculateAverage()
        {
            float sum = 0,avg = 0;

            foreach (var rating in ratings)
            {
                sum = sum + rating;
            }

            avg = sum / ratings.Count();

            return avg;
        }  

        public float GiveMaxRating()
        {
            return ratings.Max();
        }

        public float GiveMinRating()
        {
            return ratings.Min();
        }
    }

}
