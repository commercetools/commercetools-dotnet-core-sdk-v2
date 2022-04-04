using commercetools.Sdk.Api.Models.Products;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ProductCreatedMessagePayload))]
    public partial interface IProductCreatedMessagePayload : IMessagePayload
    {
        IProductProjection ProductProjection { get; set; }
    }
}
