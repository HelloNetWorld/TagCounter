using HtmlAgilityPack;
using System.Threading.Tasks;

namespace TagCounter.Client.Services
{
    public interface IWebDataService
    {
        int? CountTags(HtmlDocument htmlDocument);
        Task<HtmlDocument> GetHtmlDocumentAsync(string requestUriString);
    }
}