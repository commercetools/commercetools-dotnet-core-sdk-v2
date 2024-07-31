using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.ChangeValues
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.ChangeValues.TextLineItemValue))]
    public partial interface ITextLineItemValue
    {
        string Id { get; set; }

        ILocalizedString Name { get; set; }

    }
}
