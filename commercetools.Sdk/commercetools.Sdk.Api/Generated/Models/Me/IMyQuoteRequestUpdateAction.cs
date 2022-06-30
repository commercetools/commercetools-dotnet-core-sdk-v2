using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Me
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Me.MyQuoteRequestUpdateAction))]
    [SubTypeDiscriminator("cancelQuoteRequest", typeof(commercetools.Sdk.Api.Models.Me.MyQuoteRequestCancelAction))]
    public partial interface IMyQuoteRequestUpdateAction
    {
        string Action { get; set; }
    }
}
