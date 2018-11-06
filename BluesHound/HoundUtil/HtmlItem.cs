using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace HoundUtil
{
    public abstract class HtmlItem
    {
        protected string html;
        public string Html
        {
            get { return html; }
            protected set
            {
                html = value;
                OnPropertyChanged();
            }
        }
        int ID { get; }
        bool IsDownLoading { get; }
        string LocationOrFile { get; }
    

        /// <summary>
        /// When implenting descendant be sure to mark method as 'async'
        /// </summary>
        /// <returns></returns>
        public abstract  Task<int> GrabAsync();
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}