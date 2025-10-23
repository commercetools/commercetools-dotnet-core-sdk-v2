using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetImageLabelChange))]
    public partial interface ISetImageLabelChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IImage PreviousValue { get; set; }

        IImage NextValue { get; set; }

        string CatalogData { get; set; }

        string Variant { get; set; }

    }
}
