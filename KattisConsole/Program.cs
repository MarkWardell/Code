using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace KattisConsole
{
    class Program
    {
        static async Task<int> Main(string[] args)
        {
            var s = await LogonAsync();
            return 0;
           
        }
        const string strUrl = @"https://open.kattis.com/login";
        const string strArgs = @"{'script': 'true', 'token': aa14d4dd381062429ac55d28c90b65b7715dfe30726ad37847557216cf6261df', 'user': 'mark-wardell'}";
        private static async Task<string> LogonAsync()
        {
            var parms = new NameValueCollection()
            {
                { "username","mark.d.wardell@gmail.com"},
                //new KeyValuePair<string, string>("token",   "aa14d4dd381062429ac55d28c90b65b7715dfe30726ad37847557216cf6261df")
                { "password",   "Atlant1960!" }
            };
            /*
             * CookieContainer cookies = new CookieContainer();
HttpClientHandler handler = new HttpClientHandler();
handler.CookieContainer = cookies;

HttpClient client = new HttpClient(handler);
HttpResponseMessage response = client.GetAsync("http://google.com").Result;

Uri uri = new Uri("http://google.com");
IEnumerable<Cookie> responseCookies = cookies.GetCookies(uri).Cast<Cookie>();
foreach (Cookie cookie in responseCookies)
    Console.WriteLine(cookie.Name + ": " + cookie.Value);

Console.ReadLine();
             */
            //using (var hclient = new HttpClient())
            //{

            //    HttpRequestMessage hr = new HttpRequestMessage(HttpMethod.Post, strUrl);
            //    hr.Headers.Add("User-Agent", "kattis-cli-submit");
            //    hr.Content = new StringContent("{ 'script': 'true', 'password': 'Atlanta190!', 'user': 'mark-wardell'}");
            //    var response = await hclient.PostAsync(strUrl, new StringContent("{ 'script': 'true', 'password': 'Atlanta1960!', 'user': 'mark-wardell'}"));
            //    response.EnsureSuccessStatusCode();
            //    return response.ToString();



            //}
            CookieContainer cookies = new CookieContainer();
            HttpClientHandler handler = new HttpClientHandler();
            handler.CookieContainer = cookies;

           
           
            HttpClient client = new HttpClient();

            Dictionary<string, string> pairs = new Dictionary<string, string>();
            pairs.Add("user", "mark.d.wardell@gmail.com");
            pairs.Add("password", "Atlanta1960!");
            FormUrlEncodedContent frm = new FormUrlEncodedContent(pairs);


            client.DefaultRequestHeaders.Add("User-Agent","kattis-cli-submit");
            HttpResponseMessage response = await client.PostAsync(strUrl, frm);
            Uri uri = new Uri(strUrl);
            IEnumerable<Cookie> responseCookies = cookies.GetCookies(uri).Cast<Cookie>();
            foreach (Cookie cookie in responseCookies)
                Console.WriteLine(cookie.Name + ": " + cookie.Value);
            return "Hello";


        }
    }
}
