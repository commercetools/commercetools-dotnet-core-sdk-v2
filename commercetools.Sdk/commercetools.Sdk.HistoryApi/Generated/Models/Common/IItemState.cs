using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.ItemState))]
    public partial interface IItemState
    {
        int Quantity { get; set; }

        IReference State { get; set; }

    }
}
