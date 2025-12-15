using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.ShippingMethodChangeTaxCategoryChange))]
    public partial interface IShippingMethodChangeTaxCategoryChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        IReference PreviousValue { get; set; }

        IReference NextValue { get; set; }

    }
}
