using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace HoundUtil
{
    public class SiteUtilFromFile : ISiteUtil
    {

        public async Task<string> GrabCalendar(string fileName)
        {
            string retVal = string.Empty;
            if (System.IO.File.Exists(fileName))
            {

                retVal = await ReadTextAsync(fileName);

            }
            else
                await Task.Delay(10);
            return retVal;
        }
        private async Task<string> ReadTextAsync(string filePath)
        {
            using (FileStream sourceStream = new FileStream(filePath,
                FileMode.Open, FileAccess.Read, FileShare.Read,
                bufferSize: 4096, useAsync: true))
            {
                StringBuilder sb = new StringBuilder();

                byte[] buffer = new byte[0x1000];
                int numRead;
                while ((numRead = await sourceStream.ReadAsync(buffer, 0, buffer.Length)) != 0)
                {
                    string text = Encoding.ASCII.GetString(buffer, 0, numRead);
                    sb.Append(text);
                }

                return sb.ToString();
            }
        }
    }
}
