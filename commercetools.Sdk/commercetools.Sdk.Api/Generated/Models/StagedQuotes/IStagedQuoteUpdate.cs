using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.StagedQuotes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.StagedQuotes.StagedQuoteUpdate))]
    public partial interface IStagedQuoteUpdate
    {
        long Version { get; set; }

        List<IStagedQuoteUpdateAction> Actions { get; set; }
    }
}
