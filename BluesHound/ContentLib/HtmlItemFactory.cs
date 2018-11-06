using ContentLib;
using System;
using static ContentLib.Constants;

namespace ContentLib
{
    public class HtmlItemFactory
    {
        public static HtmlItem GetHtmlItem(LocationType locType, string location)
        {
            switch (locType)
            {
                case LocationType.FILE:
                    {
                        return new ItemFromFile(location);

                    }
                case LocationType.WEB:
                    {
                        return new ItemFromUrl(location);
                    }
                case LocationType.FTP:
                default:
                    throw new Exception($"Unsupported HtmlItem [{locType}]");
            }
        }
    }
}
