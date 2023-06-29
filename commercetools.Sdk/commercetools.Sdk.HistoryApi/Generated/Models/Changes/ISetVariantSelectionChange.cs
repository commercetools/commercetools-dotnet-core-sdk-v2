using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetVariantSelectionChange))]
    public partial interface ISetVariantSelectionChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IProductVariantSelection PreviousValue { get; set; }

        IProductVariantSelection NextValue { get; set; }

        IReference Product { get; set; }

    }
}
