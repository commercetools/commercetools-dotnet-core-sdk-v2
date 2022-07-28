using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.QuoteRequests
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.QuoteRequests.QuoteRequestUpdate))]
    public partial interface IQuoteRequestUpdate
    {
        long Version { get; set; }

        List<IQuoteRequestUpdateAction> Actions { get; set; }

    }
}
