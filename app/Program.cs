using System;
using System.Collections.Generic;
#nullable enable

namespace name
{
    class Program
    {
        static void Main(string[] rags)
        {
            Zadaine[] zadaines = new Zadaine[]
            {
                new Zadaine
                (
                    "Вопрос",
                    new List<string>{
                        "Ответ1",
                        "Ответ2",
                        "Ответ3",
                        "Ответ4",
                    },
                    "0010"
                ),

                new Zadaine
                (
                    "",
                    new List<string>{

                    },
                    ""
                ),

            };

            Console.Clear();

            int number = 0;
            while (number < zadaines.Length - 1)
            {
                try
                {
                    zadaines[number].ShowQestion();
                    zadaines[number].checkAnsver(Console.ReadLine());
                    number++;
                    Console.Clear();
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex);
                }
            }

        }
    }

    //*класс для заданий
    class Zadaine
    {
        string Qestion { get; set; }//наш вопрос
        List<string> Ansvers { get; set; }//ответы на вопрос
        string CorrectAnsver { get; set; } //правильный ответ //! записывается в формате 0010 или 1100, где 0-неправильный ответ, а 1-правильный



        public Zadaine(string Qestion, List<string> ansvers, string correctAnsver)
        {
            if (ansvers.Count < 3 && ansvers.Count > 4)
            {
                throw new Exception("Неверное количество вопросов");
            }
            if (correctAnsver.Length != ansvers.Count)
            {
                throw new Exception("Формат ответов неправильный");
            }

            this.Qestion = Qestion;
            this.Ansvers = ansvers;

            this.CorrectAnsver = correctAnsver;
        }

        public bool checkAnsver(string ansver)
        {
            if (ansver.ToString().Length != Ansvers.Count)
            {
                throw new Exception("Неправильный формат ответа");
            }

            if (CorrectAnsver != ansver)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void ShowQestion(int? number = null)
        {
            if (number == null)
            {
                Console.WriteLine($"{Qestion}");
            }
            else
            {
                Console.WriteLine($"{number}) {Qestion}");
            }

            foreach (string ansver in Ansvers)
            {
                Console.WriteLine($"{Ansvers.IndexOf(ansver)}) {ansver}");
            }

            Console.WriteLine();


            Console.WriteLine($"Введите правильный ответ в следующем формате\nAAAA(Количество A - Количество ответов),\n где A это либо 1(согласие с ответом), либо 0(несогласие с ответом)");
        }
    }
}