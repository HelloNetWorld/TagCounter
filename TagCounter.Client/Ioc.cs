using Microsoft.Extensions.DependencyInjection;
using TagCounter.Client.Services;
using TagCounter.Client.ViewModels;

namespace TagCounter.Client
{
    public static class Ioc
    {
        private static readonly ServiceProvider _provider;

        static Ioc()
        {
            var services = new ServiceCollection();

            services.AddSingleton<MainViewModel>();
            services.AddSingleton<ITagCountManager, TagCountManager>();
            services.AddSingleton<IWebDataService, WebDataService>();
            services.AddSingleton<IDialogService, DialogService>();

            _provider = services.BuildServiceProvider();
        }

        public static T Resolve<T>() => _provider.GetRequiredService<T>();
    }
}
