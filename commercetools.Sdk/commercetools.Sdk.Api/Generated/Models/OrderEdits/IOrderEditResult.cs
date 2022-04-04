using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.OrderEdits.OrderEditResult))]
    [SubTypeDiscriminator("Applied", typeof(commercetools.Sdk.Api.Models.OrderEdits.OrderEditApplied))]
    [SubTypeDiscriminator("NotProcessed", typeof(commercetools.Sdk.Api.Models.OrderEdits.OrderEditNotProcessed))]
    [SubTypeDiscriminator("PreviewFailure", typeof(commercetools.Sdk.Api.Models.OrderEdits.OrderEditPreviewFailure))]
    [SubTypeDiscriminator("PreviewSuccess", typeof(commercetools.Sdk.Api.Models.OrderEdits.OrderEditPreviewSuccess))]
    public partial interface IOrderEditResult
    {
        string Type { get; set; }
    }
}
