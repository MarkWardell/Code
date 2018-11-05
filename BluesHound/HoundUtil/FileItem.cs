using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace HoundUtil
{
    public class FileItem : IHtmlItem
    {
        public string Html => throw new NotImplementedException();

        public int ID => throw new NotImplementedException();

        public bool IsDownLoading => throw new NotImplementedException();

        public string Url => throw new NotImplementedException();

        public event PropertyChangedEventHandler PropertyChanged;

        public Task<int> Grab()
        {
            throw new NotImplementedException();
        }
    }
}
