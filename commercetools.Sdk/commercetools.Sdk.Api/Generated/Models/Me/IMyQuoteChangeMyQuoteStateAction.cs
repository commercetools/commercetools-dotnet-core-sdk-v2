using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyQuoteChangeMyQuoteStateAction))]
    public partial interface IMyQuoteChangeMyQuoteStateAction : IMyQuoteUpdateAction
    {
        IMyQuoteState QuoteState { get; set; }

    }
}
