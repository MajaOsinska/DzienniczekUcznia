﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace DzienniczekUcznia
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();
            //diary.AddRating(5);
            //diary.AddRating(8.5f);
            //diary.AddRating(4.7f);

            ////float avg = diary.CalculateAvercage();
            ////float max = diary.GiveMaxRating();
            ////float min = diary.GiveMinRating();

            for (; ; )
            {
                Console.WriteLine("Podaj ocenę z zakresu 1 - 10");

                float rating;
                bool result = float.TryParse(Console.ReadLine(), out rating);

                if (rating == 11)
                {
                    break;
                }

                if (result == true)
                {
                    if (rating > 0 && rating <= 10)
                    {
                        diary.AddRating(rating);
                    }
                    else
                    {
                        Console.WriteLine("Niepoprawna liczba, podaj liczbę z zakresu 1-10");
                    }
                   
                }

                diary.AddRating(rating);
            }
            Console.WriteLine("Średnia twoich ocen to: " + diary.CalculateAverage());
            Console.WriteLine("Najwyższa ocena to: " + diary.GiveMaxRating());
            Console.WriteLine("Najniższa ocena to: " + diary.GiveMinRating());
            Console.ReadKey();

            Diary diary2 = new Diary();
            Diary diary3 = new Diary();
            Diary diary4 = new Diary();
            Diary diary5 = new Diary();

        }
    }
}
