namespace commercetools.Sdk.HistoryApi.Models.Common
{
    public partial class ItemState : IItemState
    {
        public int Quantity { get; set; }

        public IReference State { get; set; }
    }
}
