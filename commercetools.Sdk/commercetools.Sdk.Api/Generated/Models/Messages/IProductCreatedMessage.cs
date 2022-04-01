using commercetools.Sdk.Api.Models.Products;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ProductCreatedMessage))]
    public partial interface IProductCreatedMessage : IMessage
    {
        IProductProjection ProductProjection { get; set; }
    }
}
