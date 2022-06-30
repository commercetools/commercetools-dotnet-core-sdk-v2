using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.StagedQuotes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.StagedQuotes.StagedQuoteReference))]
    public partial interface IStagedQuoteReference : IReference
    {
        IStagedQuote Obj { get; set; }
    }
}
