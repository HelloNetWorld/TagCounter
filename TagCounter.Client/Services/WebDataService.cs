using HtmlAgilityPack;
using System;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TagCounter.Client.Services
{
    public class WebDataService : IWebDataService
    {
        public async Task<HtmlDocument> GetHtmlDocumentAsync(string requestUriString)
        {
            if (!Uri.IsWellFormedUriString(requestUriString, UriKind.Absolute))
            {
                return null;
            }

            var htmlDocument = new HtmlDocument();
            try
            {
                var request = WebRequest.Create(requestUriString);
                request.Method = "GET";
                var responceTask = request.GetResponseAsync();

                using (var response = await responceTask)
                {
                    using (var stream = response.GetResponseStream())
                    {
                        htmlDocument.Load(stream, Encoding.Default);
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }

            return htmlDocument;
        }

        public int? CountTags(HtmlDocument htmlDocument) =>
            htmlDocument?.DocumentNode.SelectNodes("//a").Count;
    }
}
