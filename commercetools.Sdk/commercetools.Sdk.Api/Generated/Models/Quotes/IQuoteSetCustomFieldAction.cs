using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Quotes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Quotes.QuoteSetCustomFieldAction))]
    public partial interface IQuoteSetCustomFieldAction : IQuoteUpdateAction
    {
        string Name { get; set; }

        Object Value { get; set; }
    }
}
