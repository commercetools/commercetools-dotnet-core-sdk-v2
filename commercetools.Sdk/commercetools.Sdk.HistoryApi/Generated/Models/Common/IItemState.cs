using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Common.ItemState))]
    public partial interface IItemState
    {
        int Quantity { get; set; }

        IReference State { get; set; }
    }
}
