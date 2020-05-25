using TagCounter.Client.ViewModels;

namespace TagCounter.Client
{
    public class ViewModelLocator
    {
        public MainViewModel MainViewModel => Ioc.Resolve<MainViewModel>();
    }
}
