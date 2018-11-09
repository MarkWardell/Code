using System;
using System.Collections.Generic;
using System.Text;

namespace ParserLib
{
    public abstract class AbstractDocParser 
    {
        public AbstractDocParser()
        {
            

        }

        public abstract void Parse(string html);
       
       
    }
}
