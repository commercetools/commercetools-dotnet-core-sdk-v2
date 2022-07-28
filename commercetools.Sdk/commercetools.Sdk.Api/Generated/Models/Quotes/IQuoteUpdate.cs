using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Quotes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Quotes.QuoteUpdate))]
    public partial interface IQuoteUpdate
    {
        long Version { get; set; }

        List<IQuoteUpdateAction> Actions { get; set; }

    }
}
