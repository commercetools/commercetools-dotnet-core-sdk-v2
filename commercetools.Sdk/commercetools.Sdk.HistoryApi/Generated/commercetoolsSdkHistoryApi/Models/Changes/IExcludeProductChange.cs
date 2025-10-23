using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.ExcludeProductChange))]
    public partial interface IExcludeProductChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        IProductVariantExclusion VariantExclusion { get; set; }

        IReference NextValue { get; set; }

    }
}
