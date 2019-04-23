using System.Windows.Input;

namespace XamarinUniverse.Mobile.Interfaces
{
    public interface ISupportIncrementalLoading
    {
        int PageSize { get; set; }
        bool IsIncrementalLoading { get; set; }
        bool HasMoreItems { get; set; }
        ICommand LoadMoreItemsCommand { get; }
    }
}
