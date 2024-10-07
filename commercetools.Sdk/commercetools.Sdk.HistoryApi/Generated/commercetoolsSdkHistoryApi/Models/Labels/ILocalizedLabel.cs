using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Labels
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Labels.LocalizedLabel))]
    public partial interface ILocalizedLabel : ILabel
    {
        new string Type { get; set; }

        ILocalizedString Value { get; set; }

    }
}
