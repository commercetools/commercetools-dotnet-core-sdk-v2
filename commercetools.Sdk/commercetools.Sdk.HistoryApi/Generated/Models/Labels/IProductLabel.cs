using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Labels
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Labels.ProductLabel))]
    public partial interface IProductLabel : ILabel
    {
        new string Type { get; set; }

        ILocalizedString Slug { get; set; }

        ILocalizedString Name { get; set; }

    }
}
