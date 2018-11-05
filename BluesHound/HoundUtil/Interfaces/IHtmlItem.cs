using System.ComponentModel;
using System.Threading.Tasks;

namespace HoundUtil
{
    public interface IHtmlItem
    {
        string Html { get; }
        int ID { get; }
        bool IsDownLoading { get; }
        string Url { get; }

        event PropertyChangedEventHandler PropertyChanged;

        Task<int> Grab();
    }
}