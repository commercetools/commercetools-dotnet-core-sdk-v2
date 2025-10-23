using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetVariantExclusionChange))]
    public partial interface ISetVariantExclusionChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        IReference Product { get; set; }

        IProductVariantExclusion PreviousValue { get; set; }

        IProductVariantExclusion NextValue { get; set; }

    }
}
