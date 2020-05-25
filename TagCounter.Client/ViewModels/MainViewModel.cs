using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using TagCounter.Client.BaseClasses;
using TagCounter.Client.Models;
using TagCounter.Client.Services;

namespace TagCounter.Client.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly ITagCountManager _countManager;
        private readonly IDialogService _dialogService;
        private readonly CancellationTokenSource _cancelTokenSource;
        private readonly CancellationToken _token;
        private bool _isCounting;

        public MainViewModel(ITagCountManager countManager, IDialogService dialogService)
        {
            _countManager = countManager;
            _dialogService = dialogService;
            _cancelTokenSource = new CancellationTokenSource();
            _token = _cancelTokenSource.Token;

            _countManager.User.Results.CollectionChanged +=
                (o, s) => { OnPropertyChanged(nameof(Results)); };

            _countManager.User.Logs.CollectionChanged +=
                (o, s) => { OnPropertyChanged(nameof(LogEvents)); };
        }

        public ObservableCollection<Result> Results => _countManager.User.Results;

        public ObservableCollection<string> LogEvents => _countManager.User.Logs;

        public ICommand StartCount =>
            new RelayCommand(Execute_StartCount, 
                obj => !_token.IsCancellationRequested && !_isCounting && _dialogService.FilePath != null);

        public ICommand StopCount =>
            new RelayCommand(obj => { _cancelTokenSource.Cancel(); _cancelTokenSource.Dispose();}, 
                obj => !_token.IsCancellationRequested && _dialogService.FilePath != null);

        public ICommand Open => new RelayCommand(Execute_Open);

        private void Execute_StartCount(object obj)
        {
            if( _dialogService.FilePath == null)
            {
                _dialogService.ShowMessage("Не выбран файл со списком URL.");
            }

            _isCounting = true;

            Task.Factory.StartNew(async () =>
            {
                var urls = SaverLoader.Load<IEnumerable<string>>(_dialogService.FilePath);
                await _countManager.LoadReasultsAsync(urls, _token);
            }, _token);
        }


        private void Execute_Open(object obj)
        {
            _dialogService.OpenFileDialog();
        }
    }
}
