using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HoundUtil
{
    public interface ISiteUtil
    {
      
        Task<string> GrabCalendar(string url); 
    }
}
