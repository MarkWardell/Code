using HoundUtil;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ContentLib
{
    public class WebStiteGrabber
    {

        private HtmlItem htmlItem = null;
        public WebStiteGrabber(HtmlItem hItem)
        {

            htmlItem = hItem;
        }

        public async Task<string> GrabAsync()
        {
            
            int i = await htmlItem.GrabAsync();
            if (i != 0)
                return htmlItem.Html;
            else
                return string.Empty;
            

        }
    }
}
