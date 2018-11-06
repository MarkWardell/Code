using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HoundUtil
{
    public class ItemFromUrl :  HtmlItem
    {
        static int count = 1;
        // private static HttpClient myClient;
        public ItemFromUrl(string url)
        {
            Url = url;
            ID = ++count;

        }
        public ItemFromUrl(string url, int id)
        {
            Url = url;
            ID = id;

        }
        bool isDownloading = false;
        public bool IsDownLoading
        {
            get { return isDownloading; }
            protected set
            {
                isDownloading = value;
                OnPropertyChanged();
            }
        }
        int id;
        public int ID
        {
            get { return id; }
            protected set
            {
                id = value;
                OnPropertyChanged();
            }
        }
        private string url;
        public string Url
        {
            get { return url; }
            protected set
            {
                url = value;
                OnPropertyChanged();
            }
        }

       
        static ItemFromUrl()
        {
            //myClient = new HttpClient();

        }

       

        public async Task<int> Grab()
        {
            IsDownLoading = true;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
            var resp = await request.GetResponseAsync();
            var response = (HttpWebResponse)resp;

            if (response.StatusCode == HttpStatusCode.OK)
            {
                try
                {
                    Stream receiveStream = response.GetResponseStream();
                    Encoding enCoding = null;


                    if (response.CharacterSet == null)
                    {
                        enCoding = Encoding.Default;
                    }
                    else
                    {
                        enCoding = Encoding.GetEncoding(response.CharacterSet);
                    }
                    //readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                    using (StreamReader readStream = new StreamReader(receiveStream, enCoding))

                    {
                        Html = await readStream.ReadToEndAsync();


                        readStream.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }



            }
            IsDownLoading = false;
            return Html.Length;
        }

       

        public override async Task<int> GrabAsync()
        {
            IsDownLoading = true;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
            var resp = await request.GetResponseAsync();
            var response = (HttpWebResponse)resp;

            if (response.StatusCode == HttpStatusCode.OK)
            {
                try
                {
                    Stream receiveStream = response.GetResponseStream();
                    Encoding enCoding = null;


                    if (response.CharacterSet == null)
                    {
                        enCoding = Encoding.Default;
                    }
                    else
                    {
                        enCoding = Encoding.GetEncoding(response.CharacterSet);
                    }
                    //readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                    using (StreamReader readStream = new StreamReader(receiveStream, enCoding))

                    {
                        Html = await readStream.ReadToEndAsync();


                        readStream.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            IsDownLoading = false;
            return Html.Length;
        }
    }
}
