using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.CustomLineItem))]
    public partial interface ICustomLineItem
    {
        string Id { get; set; }

        ILocalizedString Name { get; set; }

        IMoney Money { get; set; }

        ITaxedItemPrice TaxedPrice { get; set; }

        IMoney TotalPrice { get; set; }

        string Slug { get; set; }

        int Quantity { get; set; }

    }
}
