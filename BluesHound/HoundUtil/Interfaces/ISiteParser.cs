﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HoundUtil
{
    interface ISiteParser
    {
        Task<string> ParseCalendar(string html);
        Task<string> ParseVenues(string html);

    }
}
