﻿using System;
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
                    " Что такое тестирование в программировании? ",
                    new List<string>{
                        " Поиск ошибок ",
                        " Написание кода ",
                        " Оптимизация производительности ",
                        " Разработка интерфейса ",
                    },
                    "1000"
                ),
            new Zadaine
                (
                    "Какие из перечисленных видов тестирования направлены на проверку работоспособности отдельных модулей программы? (Выберите все подходящие варианты)",
                    new List<string>{
                        " Модульное тестирование ",
                        " Интеграционное тестирование ",
                        " Системное тестирование ",
                        " Приемочное тестирование ",
                    },
                    "1100"
                ),
new Zadaine
                (
                   "Какие виды тестирования направлены на проверку соответствия программы всем требованиям заказчика? (Выберите все подходящие варианты)",
                    new List<string>{
          " Модульное тестирование ",
                        " Интеграционное тестирование ",
                        " Системное тестирование ",
                        " Приемочное тестирование ",
                    },
                    "0011"
                ),
new Zadaine
                (
                    "Какие из следующих методов тестирования используются для проверки производительности приложения под нагрузкой? (Выберите все подходящие варианты)",
                    new List<string>{
                        "Функциональное тестирование",
                        " Нагрузочное тестирование",
                        "Регрессионное тестирование",
                        "Статическое тестирование",
                    },
                    "0100"
                ),
new Zadaine
                (
                    "Какие фазы тестирования выполняются перед выпуском окончательной версии продукта? (Выберите все подходящие варианты)?",
                    new List<string>{
                        " Альфа-тестирование",
                        " Бета-тестирование",
                        "Гамма-тестирование",
                    },
                    "010"
                ),
new Zadaine
                (
                    "Какие из следующих документов содержат информацию о целях тестирования, его стратегии и плане? (Выберите все подходящие варианты)",
                    new List<string>{
                        "Тест-кейсы",
                        "Тест-план",
                        "Тест-скрипты",
                    },
                    "010"
                ),
new Zadaine
                (
                    "Какие критерии обычно используются при выборе тестовых случаев? (Выберите все подходящие варианты)",
                    new List<string>{
                        "Случайный выбор",
                        "Точные копии продукции",
                        "Комбинация важных и критических функций",
                        " Только сложные сценарии использования",
                    },
                    "0010"
                ),
new Zadaine
                (
                    "Какие виды тестирования направлены на проверку того, не повлияли ли новые изменения на уже существующий функционал? (Выберите все подходящие варианты)",
                    new List<string>{
                        "Регрессионное тестирование",
                        " Модульное тестирование",
                        "Интеграционное тестирование",
                        "Системное тестирование",
                    },
                    "1000"
                ),
new Zadaine
                (
                    "Какие виды тестирования направлены на выявление уязвимостей и защиту от атак? (Выберите все подходящие варианты",
                    new List<string>{
                        "Функциональное тестирование",
                        "Тестирование производительности",
                        "Тестирование совместимости",
                        "Тестирование безопасности",
                    },
                    "0110"
                ),
new Zadaine
                (
                    "Какие из следующих инструментов используются для автоматизации тестирования интерфейса пользователя? (Выберите все подходящие варианты)",
                    new List<string>{
                        " JIRA",
                        "Selenium",
                        "Git",
                        "Jenkins",
                    },
                    "0100"
                ),
new Zadaine
                (
                    "Какие виды тестирования направлены на проверку работоспособности программы на различных платформах и браузерах? (Выберите все подходящие варианты)",
                    new List<string>{
                        "Тестирование совместимости",
                        "Тестирование производительности",
                        "Тестирование безопасности",
                        "Тестирование производительности",
                    },
                    "1010"
                ),
new Zadaine
                (
                    "Какие виды тестирования проверяют, как быстро и эффективно выполняется программа при нагрузке? (Выберите все подходящие варианты)",
                    new List<string>{
                        " Тестирование производительности",
                        "Тестирование совместимости",
                        " Тестирование безопасности",
                        "Тестирование сценариев использования",
                    },
                    "1000"
                ),
new Zadaine
                (
                    "Какие виды тестирования направлены на проверку функционала мобильного приложения на различных устройствах? (Выберите все подходящие варианты)",
                    new List<string>{
                        " Мобильное тестирование",
                        "Тестирование совместимости",
                        "Тестирование безопасности",
                        " Тестирование производительности",
                    },
                    "1100"
                ),
new Zadaine
                (
                    "Какие виды тестирования проверяют удобство использования и соответствие интерфейса стандартам? (Выберите все подходящие варианты)",
                    new List<string>{
                        "Тестирование интерфейса",
                        "Тестирование производительности",
                        "Тестирование безопасности",
                        " Тестирование совместимости",
                    },
                    "1000"
                ),
new Zadaine
                (
                    "Какие виды тестирования выполняются в процессе написания кода разработчиком? (Выберите все подходящие варианты)",
                    new List<string>{
                        "Модульное тестирование",
                        "Интеграционное тестирование",
                        "Системное тестирование",
                        "Приемочное тестирование",
                    },
                    "1100"
                )
            };

            Console.Clear();

            int number = 0;
            int score = 0;
            while (number < zadaines.Length - 1)
            {
                try
                {
                    zadaines[number].ShowQestion(number + 1);

                    bool result = zadaines[number].checkAnsver(Console.ReadLine());

                    Console.Clear();

                    if (result)
                    {
                        Console.WriteLine("Правильно");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("Неправильно");
                    }


                    number++;
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex);
                }
            }

            Console.WriteLine($"Результат {score} из {zadaines.Length}");

        }
    }

    //*класс для заданий
    class Zadaine
    {
        string Qestion { get; set; }//наш вопрос
        List<string> Ansvers { get; set; }//ответы на вопрос
        string CorrectAnsver { get; set; } //правильный ответ //? записывается в формате 0010 или 1100, где 0-неправильный ответ, а 1-правильный



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
            Console.WriteLine("Ответы:");

            foreach (string ansver in Ansvers)
            {
                Console.WriteLine($"{Ansvers.IndexOf(ansver) + 1}) {ansver}");
            }

            Console.WriteLine();


            Console.WriteLine($"Введите правильный ответ в следующем формате\nAAAA(Количество A - Количество ответов),\n где A это либо 1(согласие с ответом), либо 0(несогласие с ответом)");
        }
    }
}