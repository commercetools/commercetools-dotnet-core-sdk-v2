using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.AddProductChange))]
    public partial interface IAddProductChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IReference NextValue { get; set; }

        IProductVariantSelection VariantSelection { get; set; }

    }
}
