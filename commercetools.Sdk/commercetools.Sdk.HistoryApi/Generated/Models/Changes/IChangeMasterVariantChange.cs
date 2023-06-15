using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeMasterVariantChange))]
    public partial interface IChangeMasterVariantChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IVariant PreviousValue { get; set; }

        IVariant NextValue { get; set; }

        string CatalogData { get; set; }

    }
}
