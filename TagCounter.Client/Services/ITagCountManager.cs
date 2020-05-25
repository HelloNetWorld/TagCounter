using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using TagCounter.Client.Models;

namespace TagCounter.Client.Services
{
    public interface ITagCountManager
    {
        User User { get; }

        Task LoadReasultsAsync(IEnumerable<string> urls, CancellationToken cancellationToken);
    }
}