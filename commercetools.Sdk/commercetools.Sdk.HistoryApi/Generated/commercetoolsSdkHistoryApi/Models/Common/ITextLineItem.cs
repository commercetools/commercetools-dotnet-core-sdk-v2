using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.TextLineItem))]
    public partial interface ITextLineItem
    {
        string AddedAt { get; set; }

        ICustomFields Custom { get; set; }

        ILocalizedString Description { get; set; }

        string Id { get; set; }

        ILocalizedString Name { get; set; }

        int Quantity { get; set; }

    }
}
