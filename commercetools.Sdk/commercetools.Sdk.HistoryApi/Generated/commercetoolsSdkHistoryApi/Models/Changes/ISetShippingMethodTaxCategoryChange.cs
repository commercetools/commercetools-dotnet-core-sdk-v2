using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetShippingMethodTaxCategoryChange))]
    public partial interface ISetShippingMethodTaxCategoryChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        ITaxMode TaxMode { get; set; }

        IReference PreviousValue { get; set; }

        IReference NextValue { get; set; }

    }
}
