using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetProductPriceCustomFieldChange))]
    public partial interface ISetProductPriceCustomFieldChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        ICustomFields PreviousValue { get; set; }

        ICustomFields NextValue { get; set; }

        string CatalogData { get; set; }

        string Variant { get; set; }

        string PriceId { get; set; }

        string CustomTypeId { get; set; }

        string Name { get; set; }

    }
}
