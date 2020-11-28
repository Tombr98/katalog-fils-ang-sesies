using System;
using System.Collections.Generic;
using курсач.Films.Film;
namespace курсач.Films
{
    static class FilmsC
    {
        public static List<FilmC> FilmsList = new List<FilmC>();

        static FilmsC()
        {
            AddFilm(
                new FilmC[] 
                {
                    new FilmC() {Name = "Закляття 2", Duration = 133,
                        IsNew = true, Jenres = "Хорор", 
                        Producer = "Джеймс Ван", Country = "USA", 
                        Description = "1976 рік. Дослідники паранормальних явищ Ед і Лоррейн Воррен розслідують вбивства в\nАмітівіллі, коли Рональд Дефео розстріляв усю свою родину. Під час спіритичного\nсеансу на Лоррейн нападає невідомий демон у вигляді монахині,\nа після цього вона бачить видіння — смерть свого чоловіка, Еда",
                        TypeF = TypeOfFilm.Film,
                        TrailerURL = "https://www.youtube.com/watch?v=A5PaKL70hcI",
                        Rating = "7.7/10", Translation = "Дубляж",
                        ReleaseData = new DateTime(2020,11,10), 
                        Poster = Properties.Resources.Procklyatie},

                    new FilmC() {Name = "Закляття", Duration = 112,
                        IsNew = true, Jenres = "Хорор",
                        Producer = "Джеймс Ван", Country = "USA",
                        Description = "У 1971 році Роджер і Керолайн переїжджають у напівзруйнований будинок у Харрісвіллі,\nРод-Айленд,зі своїми п'ятьма доньками. Перший день минає гладко, хоча їх собака,\nСеді,відмовляєтьсяувійти в будинок, а одна з дочок знаходить забитий вхід до підвалу.",
                        TypeF = TypeOfFilm.Film,
                        TrailerURL = "https://www.youtube.com/watch?v=Ca_9vIwQ7rA",
                        Rating = "8.5/10", Translation = "Дубляж",
                        ReleaseData = new DateTime(2020,10,10),
                        Poster = Properties.Resources.Zakla},

                    new FilmC() {Name = "Астрал2", Duration = 105,
                        IsNew = false, Jenres = "Хорор",
                        Producer = "Джеймс Ван", Country = "USA",
                        Description = "Виявилося, що в дитинстві мати жорстоко поводилася з малолітнім Паркером,\nзмушуючи його носити жіночий одяг і вести себе як дівчинка.Після смерті матері Паркера\nїї привид продовжив мучити сина, наказуючи йому вбивати дівчат.Під час викрадення дівчат\nПаркер гримувався під стару жінку і надягав на себе чорну сукню",
                        TypeF = TypeOfFilm.Film,
                        TrailerURL = "https://www.youtube.com/watch?v=ar5aw8tT5_8",
                        Rating = "8.7/10", Translation = "Дубляж",
                        ReleaseData = DateTime.Now,
                        Poster = Properties.Resources.Astral_2},

                    new FilmC() {Name = "Астрал", Duration = 103,
                        IsNew = false, Jenres = "Хорор",
                        Producer = "Джеймс Ван", Country = "USA",
                        Description = "Вчитель Джош, його дружина Рене і троє їхніх дітей (Далтон, Фостер і Келлі)\nпереїжджають в новий будинок. Ще навіть не встигнувши розпакувати речі,\nРене починає помічати дивні речі.",
                        TypeF = TypeOfFilm.Film,
                        TrailerURL = "https://www.youtube.com/watch?v=Xue-JaOwEec",
                        Rating = "8.1/10", Translation = "Дубляж",
                        ReleaseData = DateTime.Now,
                        Poster = Properties.Resources.Astral},

                    new FilmC() {Name = "LOST", Duration = 42,
                        IsNew = true, Jenres = "Приключения",
                        Producer = "Джей Джей Абрамс, Дэниэл Аттиас, Джек Бендер", Country = "USA",
                        Description = "Літак, що виконує рейс маршрутом «Сідней — Лос-Анджелес», зазнає катастрофи.\n48 пасажирів дивом рятуються від смерті і опиняються на загубленому в океані острові.\nШанси на те, що їх знайдуть, мізерно малі.",
                        TypeF = TypeOfFilm.Series,
                        TrailerURL = "https://www.youtube.com/watch?v=Syt-W_6nyFE",
                        Rating = "9.6/10", Translation = "Дубляж",
                        ReleaseData =  new DateTime(2020,08,10),
                        Poster = Properties.Resources.lost},

                    new FilmC() {Name = "Игра на выживание", Duration = 53,
                        IsNew = false, Jenres = "Приключения",
                        Producer = "Валерий Федорович,Евгений Никишов,\nНелли ЯраловаЛен Блаватник,Мария Шухнина,\nЮрий Сапронов, ", Country = "USA",
                        Description = "16 осіб з різних регіонів Росії приїжджають в сибірську тайгу на зйомки екстремального\nреаліті-шоу «Вижилий». У радіусі більше ста кілометрів немає жодного населеного пункту,\nдоріг, Інтернету і стільникового зв'язку",
                        TypeF = TypeOfFilm.Series,
                        TrailerURL = "https://www.youtube.com/watch?v=m3sKTRQ3SkI",
                        Rating = "6.9/10", Translation = "Дубляж",
                        ReleaseData =  new DateTime(2019,05,04),
                        Poster = Properties.Resources.Play_Survival},

                    new FilmC() {Name = "Роксолана", Duration = 120,
                        IsNew = false, Jenres = "Історія",
                        Producer = "Дурул Тайлан, Ягмур Тайлан, Ягыз Алп Акайдын", Country = "Tуреччина",
                        Description = "Телесеріал знятий за мотивами реальних подій, заснований на історичних документах.\nГоловним героєм телесеріалу є султан Сулейман I Пишний, якого самі турки називали Кануні,\nтобто «законодавець», що правив Османською імперією в XVI столітті,\nна яке і припав її розквіт.",
                        TypeF = TypeOfFilm.Series,
                        TrailerURL = "https://www.youtube.com/watch?v=GyW6UTuIHqQ",
                        Rating = "4.1/10", Translation = "Дубляж",
                        ReleaseData = DateTime.Now,
                        Poster = Properties.Resources.Rocksolana},


                }
                );
        }
        

        private static void AddFilm(FilmC[] films)
        {
            foreach (FilmC film in films)
            {
                FilmsList.Add(film);
            }
        }
    }
}
