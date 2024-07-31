using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.QuoteRequests
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.QuoteRequests.QuoteRequestSetCustomFieldAction))]
    public partial interface IQuoteRequestSetCustomFieldAction : IQuoteRequestUpdateAction
    {
        string Name { get; set; }

        Object Value { get; set; }

    }
}
