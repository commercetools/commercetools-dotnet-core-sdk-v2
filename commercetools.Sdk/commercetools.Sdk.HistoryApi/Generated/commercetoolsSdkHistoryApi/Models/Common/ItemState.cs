

namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class ItemState : IItemState
    {
        public long Quantity { get; set; }

        public IStateReference State { get; set; }
    }
}
