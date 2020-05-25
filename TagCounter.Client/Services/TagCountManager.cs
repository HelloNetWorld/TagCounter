using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using TagCounter.Client.Models;

namespace TagCounter.Client.Services
{
    public class TagCountManager : ITagCountManager
    {
        private readonly IWebDataService _webDataService;

        public TagCountManager(IWebDataService webDataService)
        {
            _webDataService = webDataService;
        }

        public User User { get; private set; } = new User();

        public async Task LoadReasultsAsync(IEnumerable<string> urls, CancellationToken cancellationToken)
        {
            if (urls == null) throw new ArgumentNullException(nameof(urls));

            await Task.Run(() =>
            {
                foreach (var url in urls)
                {
                    if (cancellationToken.IsCancellationRequested)
                    {
                        User.Logs.Add($"Операция отменена...");
                        cancellationToken.ThrowIfCancellationRequested();
                    }

                    User.Logs.Add($"...");
                    User.Logs.Add($"Начало обработки URL:{url}");

                    var htmlDoc = _webDataService.GetHtmlDocumentAsync(url).Result;
                    var count = _webDataService.CountTags(htmlDoc);
                    User.Results.Add(new Result()
                    {
                        TagCount = count,
                        UrlLink = url
                    });

                    User.Logs.Add($"Подсчитано:{count} в {url}.");
                    User.Logs.Add($"Конец обработки URL:{url}.");
                }
                User.Logs.Add($"Обработка файла завершена.");
            });

            // Так же неплохой вариант:
            // await Task.Run(() => Parallel.ForEach(urls, (url) =>{}));
        }
    }
}
