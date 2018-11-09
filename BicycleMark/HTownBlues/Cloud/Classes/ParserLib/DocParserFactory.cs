using System;
using System.Collections.Generic;
using System.Text;
using ParserLib;
using ParserLib.DocParsers;

namespace ParserLib
{
    public class DocParserFactory
    {
        public static AbstractDocParser GetParser(Constants.Site        site, 
                                                  Constants.SiteType    siteType,
                                                  string                html)
        {
            switch (site)
            {


                case (Constants.Site.BluesHound):
                    {
                        switch(siteType)
                        {
                            case Constants.SiteType.CALENDAR:
                                return new BluesHoundCalendar();
                            case Constants.SiteType.VENUE:
                                return new BluesHoundVenue();
                            default:
                                throw new Exception($"For {site} [{siteType}] is unsupported");
                        }
                    }
                default:
                    {
                        throw new Exception($"Unsupported site [{site}]");
                    }
                    
            }
        }
    }
}
