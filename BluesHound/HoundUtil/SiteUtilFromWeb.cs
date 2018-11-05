using RestSharp;
using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace HoundUtil
{
    public class SiteUtilFromWeb : ISiteUtil
    {

        public async Task<string> GrabCalendar(string urlStr)
        {
            UrlItem urlItem = new UrlItem(urlStr);
            int i = await urlItem.Grab();
            string repStr = urlItem.Html;
            return repStr;
        }
    }
    
}
