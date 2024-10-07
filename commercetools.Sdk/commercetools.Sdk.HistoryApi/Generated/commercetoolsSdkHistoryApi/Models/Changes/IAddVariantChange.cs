using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.AddVariantChange))]
    public partial interface IAddVariantChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IVariant PreviousValue { get; set; }

        IVariant NextValue { get; set; }

        string CatalogData { get; set; }

    }
}
