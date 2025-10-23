using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.TextLineItem))]
    public partial interface ITextLineItem
    {
        DateTime AddedAt { get; set; }

        ICustomFields Custom { get; set; }

        ILocalizedString Description { get; set; }

        string Id { get; set; }

        string Key { get; set; }

        ILocalizedString Name { get; set; }

        long Quantity { get; set; }

    }
}
