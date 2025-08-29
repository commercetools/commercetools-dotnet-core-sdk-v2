using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Responses
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.Responses.ResponseMessage))]
    public partial interface IResponseMessage : IMessage
    {
        new string CorrelationId { get; set; }

    }
}
