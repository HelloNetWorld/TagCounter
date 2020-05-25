using System.Collections.ObjectModel;
using System.Windows.Data;
using TagCounter.Client.BaseClasses;

namespace TagCounter.Client.Models
{
    public class User
    {
        private readonly object _blockingResults = new object();
        private readonly object _blockingLogs = new object();

        public User()
        {
            Logs = new ObservableCollection<string>();
            Results = new ObservableCollection<Result>();

            BindingOperations.EnableCollectionSynchronization(Results, _blockingResults);
            BindingOperations.EnableCollectionSynchronization(Logs, _blockingLogs);
        }

        public ObservableCollection<string> Logs { get; }
        public ObservableCollection<Result> Results { get; }
    }
}
