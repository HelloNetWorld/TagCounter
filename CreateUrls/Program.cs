﻿using System.Collections.Generic;
using TagCounter.Client.BaseClasses;
using TagCounter.Client.Services;

namespace CreateUrls
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> urls = new List<string>() 
            { 
                "https://mail.ru/",
                "https://stackoverflow.com/",
                "https://www.chess.com/",
                "https://ru.wikipedia.org/wiki/%D0%97%D0%B0%D0%B3%D0%BB%D0%B0%D0%B2%D0%BD%D0%B0%D1%8F_%D1%81%D1%82%D1%80%D0%B0%D0%BD%D0%B8%D1%86%D0%B0",
                "https://ru.wikipedia.org/wiki/%D0%9E%D0%B1%D1%8B%D0%BA%D0%BD%D0%BE%D0%B2%D0%B5%D0%BD%D0%BD%D0%B0%D1%8F_%D0%BB%D0%B0%D0%B7%D0%BE%D1%80%D0%B5%D0%B2%D0%BA%D0%B0",
                "https://lenta.ru/news/2020/05/21/newbuilt_crisis/",
                "https://qna.habr.com/",
                "https://career.habr.com/vacancies?type=suitable",
                "https://docs.microsoft.com/ru-ru/archive/msdn-magazine/2015/july/async-programming-brownfield-async-development",
                "https://docs.microsoft.com/ru-ru/dotnet/api/system.windows.data.bindingoperations.enablecollectionsynchronization?view=netcore-3.1",
                "https://docs.microsoft.com/ru-ru/dotnet/api/system.windows.data.bindingoperations.enablecollectionsynchronization?view=netcore-3.1",
                "https://docs.microsoft.com/ru-ru/dotnet/api/system.windows.data.bindingoperations.enablecollectionsynchronization?view=netcore-3.1",
                "https://docs.microsoft.com/ru-ru/dotnet/api/system.windows.data.bindingoperations.enablecollectionsynchronization?view=netcore-3.1",
                "https://career.habr.com/vacancies?type=suitable",
                "https://career.habr.com/vacancies?type=suitable",
                "https://career.habr.com/vacancies?type=suitable",
                "https://career.habr.com/vacancies?type=suitable",
                "https://career.habr.com/vacancies?type=suitable",
                "Not available",
                "Not available",
                "222",
                "http:",
                "https://yandex.ru/",
                "https://www.offlinepad.com"
            };

            SaverLoader.Save(urls, $@"C:\Users\Виктор\source\repos\TagCounter\TagCounter.Client\bin\Release\{Constants.URLS_FILENAME}");
        }
    }
}
